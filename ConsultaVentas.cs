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
    public partial class ConsultaVentas : Form
    {
        //SqlConnection conn = new SqlConnection("server=Enrique; database=SistemaCarniceria; integrated security = true");
        //SqlConnection conn = new SqlConnection("server=ALEXA-13; database=SistemaCarniceria; integrated security = true");
        SqlConnection conn = new SqlConnection("server=Enrique; database=SistemaCarniceria; integrated security = true");
        SqlCommand comando = new SqlCommand(); //Creamos un objeto que venga con toda la informacion
        SqlDataReader lector; //Ejecuta la accion del comando
        public ConsultaVentas()
        {
            InitializeComponent();
        }

        private void ConsultaVentas_Load(object sender, EventArgs e)
        {
            conn.Open();
            comando = conn.CreateCommand(); //Se enlaza el comando con la conexion
        }

        private void cmdCliente_Click(object sender, EventArgs e)
        {
            dgvCliente1.Visible = true;
            dgvCliente2.Visible = true;
            gbCliente.Visible = true;
            dgvProductos.Visible = false;
            dgvPeriodo1.Visible = false;
            dgvPeriodo2.Visible = false;
            gBoxFechas.Visible = false;
            txtIDCliente.Text = "";
            txtDomicilio.Text = "";
            txtSaldoT.Text = "";
            txtTelefono.Text = "";
            cboCliente.Items.Clear();
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
            txtDomicilio.Text = lector[3].ToString();
            txtTelefono.Text = lector[2].ToString();
            txtSaldoT.Text = lector[6].ToString();
            lector.Close();
        }

        private void cmdBuscarCliente_Click(object sender, EventArgs e)
        {
            dgvCliente1.Rows.Clear();
            dgvCliente2.Rows.Clear();
            comando.CommandText = "Select IdVenta, Fecha, Tipo, SubTotal, Iva, Total, Saldo FROM Venta where IdCliente = " + Convert.ToInt16(txtIDCliente.Text);
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                dgvCliente1.Rows.Add(lector[0], lector[1], lector[2], lector[3], lector[4], lector[5], lector[6]);
            }
            lector.Close();
        }

        private void dgvCliente1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvCliente2.Rows.Clear();
            int posicion = dgvCliente1.CurrentRow.Index;
            if (posicion != -1)
            {
                int idVenta = Convert.ToInt32(dgvCliente1.Rows[posicion].Cells[0].Value);
                comando.CommandText = "SELECT dv.IdProducto, p.Descripcion, dv.Cantidad, dv.Precio, (dv.Cantidad * dv.Precio) AS Importe FROM DetalleVenta AS dv INNER JOIN Producto AS p ON dv.IdProducto = p.Codigo WHERE dv.IdVenta = " + idVenta;
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    dgvCliente2.Rows.Add(lector[0], lector[1], lector[2], lector[3], lector[4]);
                }
                lector.Close();
            }
        }

        private void cmdProducto_Click(object sender, EventArgs e)
        {
            dgvProductos.Rows.Clear();
            dgvCliente1.Visible = false;
            dgvCliente2.Visible = false;
            gbCliente.Visible = false;
            dgvPeriodo1.Visible = false;
            dgvPeriodo2.Visible = false;
            gBoxFechas.Visible = false;
            dgvProductos.Visible = true;
            comando.CommandText = "SELECT p.Codigo, p.Descripcion, SUM(dv.Cantidad) AS TotalVentas FROM DetalleVenta dv INNER JOIN Producto p ON dv.IdProducto = p.Codigo GROUP BY p.Codigo, p.Descripcion";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                dgvProductos.Rows.Add(lector[0], lector[1], lector[2]);
            }
            lector.Close();
        }

        private void cmdPeriodo_Click(object sender, EventArgs e)
        {
            dgvPeriodo1.Rows.Clear();
            dgvPeriodo2.Rows.Clear();
            dgvCliente1.Visible = false;
            dgvCliente2.Visible = false;
            gbCliente.Visible = false;
            dgvProductos.Visible = false;
            dgvPeriodo1.Visible = true;
            dgvPeriodo2.Visible = true;
            gBoxFechas.Visible = true;
        }

        private void cmdBuscar2_Click(object sender, EventArgs e)
        {
            string fechaInicio, fechaLimite;
            dgvPeriodo1.Rows.Clear();
            dgvPeriodo2.Rows.Clear();
            fechaInicio = dataTimeInicio.Value.ToString("dd/MM/yyyy");
            fechaLimite = dataTimeLimite.Value.ToString("dd/MM/yyyy");
            comando.CommandText = "SELECT v.IdVenta, c.Nombre, v.Fecha, v.Tipo, v.SubTotal, v.Iva, v.Total, v.Saldo " +
                       "FROM Venta AS v " +
                       "INNER JOIN Cliente AS c ON v.IdCliente = c.IdCliente " +
                       "WHERE v.Fecha BETWEEN '" + fechaInicio + "' AND '" + fechaLimite + "'";

            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                dgvPeriodo1.Rows.Add(lector[0], lector[1], lector[2], lector[3], lector[4], lector[5], lector[6], lector[7]);
            }
            lector.Close();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void dgvPeriodo2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvPeriodo1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvPeriodo2.Rows.Clear();
            int posicion = dgvPeriodo1.CurrentRow.Index;
            if (posicion != -1)
            {
                int idVenta = Convert.ToInt32(dgvPeriodo1.Rows[posicion].Cells[0].Value);
                comando.CommandText = "SELECT dv.IdProducto, p.Descripcion, dv.Cantidad, dv.Precio, (dv.Cantidad * dv.Precio) AS Importe FROM DetalleVenta AS dv INNER JOIN Producto AS p ON dv.IdProducto = p.Codigo WHERE dv.IdVenta = " + idVenta;
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    dgvPeriodo2.Rows.Add(lector[0], lector[1], lector[2], lector[3], lector[4]);
                }
                lector.Close();
            }
        }
    }
}
