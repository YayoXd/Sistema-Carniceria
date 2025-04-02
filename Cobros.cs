using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Carniceria
{
    public partial class Cobros : Form
    {
        //SqlConnection conn = new SqlConnection("server=Enrique; database=SistemaCarniceria; integrated security = true");
        //SqlConnection conn = new SqlConnection("server=ALEXA-13; database=SistemaCarniceria; integrated security = true");
        SqlConnection conn = new SqlConnection("server=DESKTOP-14CCMAH\\SQLEXPRESS; database=SistemaCarniceria; integrated security = true");
        SqlCommand comando = new SqlCommand(); //Creamos un objeto que venga con toda la informacion
        SqlDataReader lector; //Ejecuta la accion del comando
        public Cobros()
        {
            InitializeComponent();
        }

        private void Cobros_Load(object sender, EventArgs e)
        {
            conn.Open();
            comando = conn.CreateCommand(); //Se enlaza el comando con la conexion
            cboCliente.Enabled = false;
            txtImporte.Enabled = false;
            cboIDVenta.Enabled = false;
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            txtDomicilio.Text = "";
            txtFecha.Text = "";
            txtIDCliente.Text = "";
            txtIDCobro.Text = "";
            txtImporte.Text = "";
            txtSakdoTotal.Text = "";
            txtTelefono.Text = "";
            cboCliente.Enabled = true;
            txtImporte.Enabled = true;
            cboIDVenta.Enabled = true;
            cboCliente.Items.Clear();
            cboIDVenta.Items.Clear();
            // Variables necesarias
            string a, fecha, conteo;
            int conteo2;

            // Consulta para obtener la fecha actual en formato 'dd/MM/yyyy'
            a = "SELECT FORMAT(GETDATE(), 'dd/MM/yyyy')";
            comando.CommandText = a;

            // Ejecuta la consulta y asigna el resultado a la variable 'fecha'
            fecha = (string)comando.ExecuteScalar();
            txtFecha.Text = fecha;

            // Consulta para obtener el conteo de registros en la tabla 'cobrocliente'
            comando.CommandText = "SELECT COUNT(*) FROM Cobro";
            conteo = comando.ExecuteScalar().ToString();

            // Convierte el conteo a entero, le suma 1 y lo asigna al cuadro de texto
            conteo2 = Convert.ToInt32(conteo) + 1;
            txtIDCobro.Text = conteo2.ToString();


            comando.CommandText = "Select * from Cliente";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                cboCliente.Items.Add(lector[1]);
            }
            lector.Close();
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            comando.CommandText = "Select * from Cliente where Nombre = '" + cboCliente.Text + "'";
            lector = comando.ExecuteReader();
            lector.Read();
            txtIDCliente.Text = lector[0].ToString();
            txtTelefono.Text = lector[2].ToString();
            txtDomicilio.Text = lector[3].ToString();
            txtSakdoTotal.Text = lector[6].ToString();
            lector.Close();
            dataGridView1.Rows.Clear();
            comando.CommandText = "SELECT IdVenta, Fecha, SubTotal, Iva, Total, Saldo FROM venta WHERE Saldo > 0 AND IdCliente = " + Convert.ToInt16(txtIDCliente.Text);
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                dataGridView1.Rows.Add(lector[0], lector[1], lector[2], lector[3], lector[4], lector[5]);
            }
            lector.Close();

            comando.CommandText = "Select IdVenta  FROM venta where Saldo > 0 AND IdCliente = " + Convert.ToInt16(txtIDCliente.Text);
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                cboIDVenta.Items.Add(lector[0]);
            }
            lector.Close();
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            string r, t, d;
            comando.CommandText = "Select saldo from venta where IdVenta = " + Convert.ToInt16(cboIDVenta.Text);
            lector = comando.ExecuteReader();
            lector.Read();
            double saldoV = Convert.ToDouble(lector[0]);
            lector.Close();
            if (Convert.ToDouble(txtImporte.Text) > saldoV)
            {
                MessageBox.Show("Por favor, inserte un importe menor al saldo de la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                r = "INSERT INTO cobro (IdCobro, IdVenta, Fecha, Importe) VALUES(" + Convert.ToInt16(txtIDCobro.Text) + "," + Convert.ToInt16(cboIDVenta.Text) + ",'" + txtFecha.Text + "'," + Convert.ToDouble(txtImporte.Text) + ")";
                comando.CommandText = r;
                comando.ExecuteNonQuery();

                t = "UPDATE cliente SET saldoTotal = saldoTotal - " + Convert.ToDouble(txtImporte.Text) + " WHERE IdCliente = " + Convert.ToUInt16(txtIDCliente.Text);
                comando.CommandText = t;
                comando.ExecuteNonQuery();

                d = "UPDATE venta SET saldo = saldo - " + Convert.ToDouble(txtImporte.Text) + " WHERE IdVenta = " + Convert.ToInt16(cboIDVenta.Text);
                comando.CommandText = d;
                comando.ExecuteNonQuery();
            }

            cboCliente.Text = "";
            cboIDVenta.Text = "";
            txtDomicilio.Text = "";
            txtFecha.Text = "";
            txtIDCliente.Text = "";
            txtIDCobro.Text = "";
            txtImporte.Text = "";
            txtSakdoTotal.Text = "";
            txtTelefono.Text = "";

            dataGridView1.Rows.Clear();
            cboCliente.Enabled = false;
            txtImporte.Enabled = false;
            cboIDVenta.Enabled = false;
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
