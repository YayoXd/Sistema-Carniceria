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
    public partial class ConsultarCobros : Form
    {
        //SqlConnection conn = new SqlConnection("server=Enrique; database=SistemaCarniceria; integrated security = true");
        //SqlConnection conn = new SqlConnection("server=ALEXA-13; database=SistemaCarniceria; integrated security = true");
        SqlConnection conn = new SqlConnection("server=Enrique; database=SistemaCarniceria; integrated security = true");
        SqlCommand comando = new SqlCommand(); //Creamos un objeto que venga con toda la informacion
        SqlDataReader lector; //Ejecuta la accion del comando

        public ConsultarCobros()
        {
            InitializeComponent();
        }

        private void ConsultarCobros_Load(object sender, EventArgs e)
        {
            conn.Open();
            comando = conn.CreateCommand(); //Se enlaza el comando con la conexion
        }

        private void cmdProducto_Click(object sender, EventArgs e)
        {
            dgvGeneral.Visible = true;
            dgvCliente.Visible = false;
            gbCliente.Visible = false;
            gBoxFechas.Visible = false;
            dgvPeriodo.Visible = false;
            gBoxFechas.Visible = false;
            dgvPeriodo.Visible = false;
            dgvGeneral.Rows.Clear();
            comando.CommandText = "SELECT co.IdCobro, v.IdVenta, cli.Nombre, co.Fecha, co.Importe FROM cobro As co INNER JOIN venta As v ON co.IdVenta = v.IdVenta JOIN cliente cli ON v.IdCliente = cli.IdCliente";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                dgvGeneral.Rows.Add(lector[0], lector[1], lector[2], lector[3], lector[4]);
            }
            lector.Close();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void cmdCliente_Click(object sender, EventArgs e)
        {
            cboCliente.Items.Clear();
            dgvGeneral.Visible = false;
            gbCliente.Visible = true;
            dgvCliente.Visible = true;
            gBoxFechas.Visible = false;
            dgvPeriodo.Visible = false;
            dgvCliente.Rows.Clear();
            comando.CommandText = "Select * from cliente";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                cboCliente.Items.Add(lector[1]);
            }
            lector.Close();
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            comando.CommandText = "Select * from cliente where Nombre = '" + cboCliente.Text + "'";
            lector = comando.ExecuteReader();
            lector.Read();
            txtIDCliente.Text = lector[0].ToString();
            txtTelefono.Text = lector[2].ToString();
            txtDomicilio.Text = lector[3].ToString();
            lector.Close();
        }

        private void cmdBuscarCliente_Click(object sender, EventArgs e)
        {
            dgvCliente.Rows.Clear();
            comando.CommandText = "SELECT co.IdCobro, v.IdVenta, co.Fecha, co.Importe FROM cobro AS co INNER JOIN venta AS v ON co.IdVenta = v.IdVenta JOIN cliente AS cli ON v.IdCliente = cli.IdCliente where v.IdCliente = " + Convert.ToInt32(txtIDCliente.Text);
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                dgvCliente.Rows.Add(lector[0], lector[1], lector[2], lector[3]);
            }
            lector.Close();
        }

        private void cmdPeriodo_Click(object sender, EventArgs e)
        {
            gBoxFechas.Visible = true;
            dgvPeriodo.Visible = true;
            dgvCliente.Visible = false;
            dgvGeneral.Visible = false;
            gbCliente.Visible = false;
            dgvPeriodo.Rows.Clear();
        }

        private void cmdBuscar2_Click(object sender, EventArgs e)
        {
            dgvPeriodo.Rows.Clear();
            string fechaInicio, fechaLimite;
            fechaInicio = dataTimeInicio.Value.ToString("dd/MM/yyyy");
            fechaLimite = dataTimeLimite.Value.ToString("dd/MM/yyyy");
            comando.CommandText = "SELECT co.IdCobro, v.IdVenta, cli.Nombre, co.Fecha, co.Importe FROM cobro AS co INNER JOIN venta AS v ON co.IdVenta = v.IdVenta JOIN cliente AS cli ON v.IdCliente = cli.IdCliente WHERE co.Fecha BETWEEN '" + fechaInicio + "' AND '" + fechaLimite + "'";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                dgvPeriodo.Rows.Add(lector[0], lector[1], lector[2], lector[3], lector[4]);
            }
            lector.Close();
        }
    }
}
