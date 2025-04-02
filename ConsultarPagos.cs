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
    public partial class ConsultarPagos : Form
    {
        //SqlConnection conn = new SqlConnection("server=Enrique; database=SistemaCarniceria; integrated security = true");
        //SqlConnection conn = new SqlConnection("server=ALEXA-13; database=SistemaCarniceria; integrated security = true");
        SqlConnection conn = new SqlConnection("server=DESKTOP-14CCMAH\\SQLEXPRESS; database=SistemaCarniceria; integrated security = true");
        SqlCommand comando = new SqlCommand(); //Creamos un objeto que venga con toda la informacion
        SqlDataReader lector; //Ejecuta la accion del comando

        public ConsultarPagos()
        {
            InitializeComponent();
        }

        private void ConsultarPagos_Load(object sender, EventArgs e)
        {
            conn.Open();
            comando = conn.CreateCommand(); //Se enlaza el comando con la conexion
        }

        private void cmdProducto_Click(object sender, EventArgs e)
        {
            dgvGeneral.Visible = true;
            groupBox1.Visible = false;
            dgvProveedor.Visible = false;
            gBoxFechas.Visible = false;
            dgvPeriodo.Visible = false;
            dgvGeneral.Rows.Clear();
            comando.CommandText = "SELECT pa.IdPago, c.IdCompra, p.Empresa, pa.Fecha, pa.Importe FROM Pago As pa INNER JOIN compra As c ON pa.IdCompra = c.IdCompra JOIN proveedor p ON c.IdProveedor = p.IdProveedor";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                dgvGeneral.Rows.Add(lector[0], lector[1], lector[2], lector[3], lector[4]);
            }
            lector.Close();
        }

        private void cmdCliente_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            dgvGeneral.Visible = false;
            groupBox1.Visible = true;
            dgvProveedor.Visible = true;
            gBoxFechas.Visible = false;
            dgvPeriodo.Visible = false;
            dgvProveedor.Rows.Clear();
            comando.CommandText = "Select * from proveedor";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                comboBox1.Items.Add(lector[1]);
            }
            lector.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comando.CommandText = "Select * from proveedor where Empresa = '" + comboBox1.Text + "'";
            lector = comando.ExecuteReader();
            lector.Read();
            txtIDProveedor.Text = lector[0].ToString();
            txtTelefono.Text = lector[6].ToString();
            txtDomicilio.Text = lector[3].ToString();
            lector.Close();
        }

        private void cmdBuscarProveedor_Click(object sender, EventArgs e)
        {
            dgvProveedor.Rows.Clear();
            comando.CommandText = "SELECT pa.IdPago, c.IdCompra, pa.Fecha, pa.Importe FROM Pago AS pa INNER JOIN compra AS c ON pa.IdCompra = c.IdCompra JOIN proveedor AS p ON c.IdProveedor = p.IdProveedor where c.IdProveedor = " + Convert.ToInt32(txtIDProveedor.Text);
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                dgvProveedor.Rows.Add(lector[0], lector[1], lector[2], lector[3]);
            }
            lector.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gBoxFechas.Visible = true;
            gBoxFechas.Enabled = true;
            dgvPeriodo.Visible = true;
            dgvProveedor.Visible = false;
            dgvGeneral.Visible = false;
            groupBox1.Visible = false;
            dgvPeriodo.Rows.Clear();
        }

        private void cmdBuscar2_Click(object sender, EventArgs e)
        {
            dgvPeriodo.Rows.Clear();
            string fechaInicio, fechaLimite;
            fechaInicio = dateTimeInicio.Value.ToString("dd/MM/yyyy");
            fechaLimite = dataTimeLimite.Value.ToString("dd/MM/yyyy");
            comando.CommandText = "SELECT pa.IdPago, c.IdCompra, p.Empresa, pa.Fecha, pa.Importe FROM pago AS pa INNER JOIN compra AS c ON pa.IdCompra = c.IdCompra JOIN proveedor AS p ON c.IdProveedor = p.IdProveedor WHERE pa.Fecha BETWEEN '" + fechaInicio + "' AND '" + fechaLimite + "'";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                dgvPeriodo.Rows.Add(lector[0], lector[1], lector[2], lector[3]);
            }
            lector.Close();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
