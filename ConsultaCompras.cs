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
    public partial class ConsultaCompras : Form
    {
        //SqlConnection conn = new SqlConnection("server=Enrique; database=SistemaCarniceria; integrated security = true");
        //SqlConnection conn = new SqlConnection("server=ALEXA-13; database=SistemaCarniceria; integrated security = true");
        SqlConnection conn = new SqlConnection("server=Enrique; database=SistemaCarniceria; integrated security = true");
        SqlCommand comando = new SqlCommand(); //Creamos un objeto que venga con toda la informacion
        SqlDataReader lector; //Ejecuta la accion del comando
        public ConsultaCompras()
        {
            InitializeComponent();
        }

        private void ConsultaCompras_Load(object sender, EventArgs e)
        {
            conn.Open();
            comando = conn.CreateCommand(); //Se enlaza el comando con la conexion
        }

        private void cmdCliente_Click(object sender, EventArgs e)
        {
            dgvProveedor1.Visible = true;
            dgvProveedor2.Visible = true;
            gbProveedor.Visible = true;
            gBoxFechas.Visible = false;
            gBoxFechas.Visible = false;
            dgvPeriodo1.Visible = false;
            dgvPeriodo2.Visible = false;
            gbProveedor.Visible = true;
            dgvProductos.Visible = false;

            txtIDProveedor.Text = "";
            txtDomicilio.Text = "";
            txtSaldoT.Text = "";
            txtTelefono.Text = "";
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
            txtDomicilio.Text = lector[3].ToString();
            txtTelefono.Text = lector[6].ToString();
            txtSaldoT.Text = lector[10].ToString();
            lector.Close();
        }

        private void cmdBuscarProveedor_Click(object sender, EventArgs e)
        {
            dgvProveedor1.Rows.Clear();
            dgvProveedor2.Rows.Clear();
            comando.CommandText = "Select IdCompra, Fecha, Factura, Condicion, SubTotal, Iva, Total, Saldo FROM Compra where IdProveedor = " + Convert.ToInt16(txtIDProveedor.Text);
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                dgvProveedor1.Rows.Add(lector[0], lector[1], lector[2], lector[3], lector[4], lector[5], lector[6], lector[7]);
            }
            lector.Close();
        }

        private void dgvProveedor1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProveedor2.Rows.Clear();
            int posicion = dgvProveedor1.CurrentRow.Index;
            if (posicion != -1)
            {
                int idCompra = Convert.ToInt32(dgvProveedor1.Rows[posicion].Cells[0].Value);
                comando.CommandText = "SELECT dc.IdProducto, p.Descripcion, dc.Cantidad, dc.Costo, (dc.Cantidad * dc.Costo) AS Importe FROM DetalleCompra AS dc INNER JOIN Producto AS p ON dc.IdProducto = p.Codigo WHERE dc.IdCompra = " + idCompra;
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    dgvProveedor2.Rows.Add(lector[0], lector[1], lector[2], lector[3], lector[4]);
                }
                lector.Close();
            }
        }

        private void cmdProducto_Click(object sender, EventArgs e)
        {
            dgvProductos.Rows.Clear();
            dgvProveedor1.Visible = false;
            dgvProveedor2.Visible = false;
            gbProveedor.Visible = false;
            dgvProductos.Visible = true;
            gBoxFechas.Visible = false;
            dgvPeriodo1.Visible = false;
            dgvPeriodo2.Visible = false;

            comando.CommandText = "SELECT p.Codigo, p.Descripcion, SUM(dc.Cantidad) AS TotalCompras FROM DetalleCompra dc INNER JOIN Producto p ON dc.IdProducto = p.Codigo GROUP BY p.Codigo, p.Descripcion";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                dgvProductos.Rows.Add(lector[0], lector[1], lector[2]);
            }
            lector.Close();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void cmdPeriodo_Click(object sender, EventArgs e)
        {
            dgvPeriodo1.Rows.Clear();
            dgvPeriodo2.Rows.Clear();
            dgvProveedor1.Visible = false;
            dgvProveedor2.Visible = false;
            gbProveedor.Visible = false;
            dgvProductos.Visible = false;
            gBoxFechas.Visible = true;
            dgvPeriodo1.Visible = true;
            dgvPeriodo2.Visible = true;
            gBoxFechas.Visible = true;
            gBoxFechas.Visible = true;
        }

        private void cmdBuscar2_Click(object sender, EventArgs e)
        {
            string fechaInicio, fechaLimite;
            dgvPeriodo1.Rows.Clear();
            dgvPeriodo2.Rows.Clear();
            fechaInicio = dataTimeInicio.Value.ToString("dd/MM/yyyy");
            fechaLimite = dataTimeLimite.Value.ToString("dd/MM/yyyy");
            comando.CommandText = "Select c.IdCompra, p.Empresa, c.Factura, c.Condicion, c.SubTotal, c.Iva, c.Total, c.Saldo " +
                       "FROM Compra AS c INNER JOIN Proveedor AS p ON c.IdProveedor = p.IdProveedor WHERE c.Fecha BETWEEN '" + fechaInicio + "' AND '" + fechaLimite + "'";

            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                dgvPeriodo1.Rows.Add(lector[0], lector[1], lector[2], lector[3], lector[4], lector[5], lector[6], lector[7]);
            }
            lector.Close();
        }

        private void dgvPeriodo2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvPeriodo2.Rows.Clear();
            int posicion = dgvPeriodo1.CurrentRow.Index;
            if (posicion != -1)
            {
                int idcompra = Convert.ToInt32(dgvPeriodo1.Rows[posicion].Cells[0].Value);
                comando.CommandText = "SELECT dc.IdProducto, p.Descripcion, dc.Cantidad, dc.Costo, (dc.Cantidad * dc.Costo) AS Importe FROM DetalleCompra AS dc INNER JOIN Producto AS p ON dc.IdProducto = p.Codigo WHERE dc.IdCompra = " + idcompra;
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    dgvPeriodo2.Rows.Add(lector[0], lector[1], lector[2], lector[3], lector[4]);
                }
                lector.Close();
            }
        }

        private void dgvPeriodo1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvPeriodo2.Rows.Clear();
            int posicion = dgvPeriodo1.CurrentRow.Index;
            if (posicion != -1)
            {
                int idcompra = Convert.ToInt32(dgvPeriodo1.Rows[posicion].Cells[0].Value);
                comando.CommandText = "SELECT dc.IdProducto, p.Descripcion, dc.Cantidad, dc.Costo, (dc.Cantidad * dc.Costo) AS Importe FROM DetalleCompra AS dc INNER JOIN Producto AS p ON dc.IdProducto = p.Codigo WHERE dc.IdCompra = " + idcompra;
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
