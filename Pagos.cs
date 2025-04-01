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
    public partial class Pagos : Form
    {
        //SqlConnection conn = new SqlConnection("server=Enrique; database=SistemaCarniceria; integrated security = true");
        //SqlConnection conn = new SqlConnection("server=ALEXA-13; database=SistemaCarniceria; integrated security = true");
        SqlConnection conn = new SqlConnection("server=Enrique; database=SistemaCarniceria; integrated security = true");
        SqlCommand comando = new SqlCommand(); //Creamos un objeto que venga con toda la informacion
        SqlDataReader lector; //Ejecuta la accion del comando
        public Pagos()
        {
            InitializeComponent();
        }

        private void Pagos_Load(object sender, EventArgs e)
        {
            conn.Open();
            comando = conn.CreateCommand(); //Se enlaza el comando con la conexion

            cboProveedor.Text = "";
            cboIDCompra.Text = "";
            txtDomicilio.Text = "";
            txtFecha.Text = "";
            txtIDProveedor.Text = "";
            txtIDCobro.Text = "";
            txtImporte.Text = "";
            txtSakdoTotal.Text = "";
            txtTelefono.Text = "";

            dataGridView1.Rows.Clear();
            cboProveedor.Enabled = false;
            txtImporte.Enabled = false;
            cboIDCompra.Enabled = false;
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            txtDomicilio.Text = "";
            txtFecha.Text = "";
            txtIDProveedor.Text = "";
            txtIDCobro.Text = "";
            txtImporte.Text = "";
            txtSakdoTotal.Text = "";
            txtTelefono.Text = "";
            cboProveedor.Items.Clear();
            cboIDCompra.Items.Clear();
            string a, fecha;
            string conteo;
            int conteo2;
            cboProveedor.Enabled = true;
            txtImporte.Enabled = true;
            cboIDCompra.Enabled = true;


            // Obtener la fecha actual en formato 'dd/MM/yyyy'
            a = "SELECT FORMAT(GETDATE(), 'dd/MM/yyyy')";
            comando.CommandText = a;
            fecha = (string)comando.ExecuteScalar();
            txtFecha.Text = fecha;

            // Obtener el conteo de registros en la tabla 'pagoproveedor'
            comando.CommandText = "SELECT COUNT(*) as num FROM Pago";
            conteo = comando.ExecuteScalar().ToString();
            conteo2 = Convert.ToInt32(conteo) + 1;
            txtIDCobro.Text = conteo2.ToString();


            comando.CommandText = "Select * from Proveedor";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                cboProveedor.Items.Add(lector[1]);
            }
            lector.Close();
        }

        private void cboProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            comando.CommandText = "Select * from Proveedor where Empresa = '" + cboProveedor.Text + "'";
            lector = comando.ExecuteReader();
            lector.Read();
            txtIDProveedor.Text = lector[0].ToString();
            txtTelefono.Text = lector[6].ToString();
            txtDomicilio.Text = lector[3].ToString();
            txtCorreo.Text = lector[9].ToString();
            txtSakdoTotal.Text = lector[10].ToString();
            lector.Close();
            dataGridView1.Rows.Clear();
            comando.CommandText = "SELECT IdCompra, Fecha, SubTotal, Iva, Total, Saldo FROM Compra WHERE Saldo > 0 AND IdProveedor = " + Convert.ToInt16(txtIDProveedor.Text);
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                dataGridView1.Rows.Add(lector[0], lector[1], lector[2], lector[3], lector[4], lector[5]);
            }
            lector.Close();

            comando.CommandText = "Select IdCompra  FROM Compra where Saldo > 0 AND IdProveedor = " + Convert.ToInt16(txtIDProveedor.Text);
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                cboIDCompra.Items.Add(lector[0]);
            }
            lector.Close();
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            string r, t, d;
            comando.CommandText = "Select Saldo from Compra where IdCompra = " + Convert.ToInt16(cboIDCompra.Text);
            lector = comando.ExecuteReader();
            lector.Read();
            double saldoC = Convert.ToDouble(lector[0]);
            lector.Close();
            if (Convert.ToDouble(txtImporte.Text) > saldoC)
            {
                MessageBox.Show("Inserte importe menor al saldo");
            }
            else
            {
                r = "INSERT INTO Pago (IdPago, IdCompra, Fecha, Importe) VALUES(" + Convert.ToInt16(txtIDCobro.Text) + "," + Convert.ToInt16(cboIDCompra.Text) + ",'" + txtFecha.Text + "'," + Convert.ToDouble(txtImporte.Text) + ")";
                comando.CommandText = r;
                comando.ExecuteNonQuery();

                t = "UPDATE Proveedor SET saldoTotal = saldoTotal - " + Convert.ToDouble(txtImporte.Text) + " WHERE IdProveedor = " + Convert.ToUInt16(txtIDProveedor.Text);
                comando.CommandText = t;
                comando.ExecuteNonQuery();

                d = "UPDATE Compra SET saldo = saldo - " + Convert.ToDouble(txtImporte.Text) + " WHERE IdCompra = " + Convert.ToInt16(cboIDCompra.Text);
                comando.CommandText = d;
                comando.ExecuteNonQuery();
            }

            cboProveedor.Text = "";
            cboIDCompra.Text = "";
            txtDomicilio.Text = "";
            txtFecha.Text = "";
            txtIDProveedor.Text = "";
            txtIDCobro.Text = "";
            txtImporte.Text = "";
            txtSakdoTotal.Text = "";
            txtTelefono.Text = "";

            dataGridView1.Rows.Clear();
            cboProveedor.Enabled = false;
            txtImporte.Enabled = false;
            cboIDCompra.Enabled = false;
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
