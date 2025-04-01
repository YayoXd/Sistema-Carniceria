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
    public partial class Compras : Form
    {
        //SqlConnection conn = new SqlConnection("server=Enrique; database=SistemaCarniceria; integrated security = true");
        //SqlConnection conn = new SqlConnection("server=ALEXA-13; database=SistemaCarniceria; integrated security = true");
        SqlConnection conn = new SqlConnection("server=Enrique; database=SistemaCarniceria; integrated security = true");
        SqlCommand comando = new SqlCommand(); //Creamos un objeto que venga con toda la informacion
        SqlDataReader lector; //Ejecuta la accion del comando
        double subtotal, iva, total, saldo;
        string fechaLimite;

        public Compras()
        {
            InitializeComponent();
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            conn.Open();
            comando = conn.CreateCommand(); //Se enlaza el comando con la conexion
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            cmdAceptar.Enabled = true;
            txtIDCompra.Text = " ";
            txtIDProveedor.Text = " ";
            txtSaldoT.Text = " ";
            txtDomicilio.Text = " ";
            txtTelefono.Text = " ";
            txtSubTotal.Text = " ";
            txtIva.Text = " ";
            txtotal.Text = " ";
            txtIDProducto.Text = " ";
            txtIDCategoria.Text = " ";
            txtCosto.Text = " ";
            txtCantidad.Text = " ";
            txtUnidad.Text = " ";
            txtFactura.Text = " ";
            cboCategoria.Text = " ";
            cboProducto.Text = " ";

            cboProducto.Items.Clear();
            cboCategoria.Items.Clear();
            cboProveedor.Items.Clear();
            dataGridView1.Rows.Clear();

            txtFechaCompra.Enabled = true;
            label21.Visible = false;
            txtFechaLimite.Visible = false;
            cboCondicion.Enabled = true;
            cboProveedor.Enabled = true;
            cboCategoria.Enabled = true;
            cboProducto.Enabled = true;
            txtCantidad.Enabled = true;
            txtFactura.Enabled = true;

            string conteo;
            int conteo2;
            comando.CommandText = "SELECT COUNT(*) as num FROM Compra";
            conteo = comando.ExecuteScalar().ToString();
            conteo2 = (int)Convert.ToInt32(conteo) + 1;
            txtIDCompra.Text = conteo2.ToString();
            comando.CommandText = "Select * from Proveedor";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                cboProveedor.Items.Add(lector[1]);
            }
            lector.Close();
            comando.CommandText = "Select * from categorias";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                cboCategoria.Items.Add(lector[1]);
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
            txtSaldoT.Text = lector[10].ToString();
            lector.Close();
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboProducto.Items.Clear();
            comando.CommandText = "Select * from Categorias where Nombre = '" + cboCategoria.Text + "'";
            lector = comando.ExecuteReader();
            lector.Read();
            txtIDCategoria.Text = lector[0].ToString();
            lector.Close();

            comando.CommandText = "Select * from Producto where IdCategoria = '" + txtIDCategoria.Text + "'";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                cboProducto.Items.Add(lector[2].ToString());
            }
            lector.Close();
        }
        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            comando.CommandText = "Select * from Producto where Descripcion =  '" + cboProducto.Text + "'";
            lector = comando.ExecuteReader();
            lector.Read();
            txtIDProducto.Text = lector[0].ToString();
            txtCosto.Text = lector[3].ToString();
            txtUnidad.Text = lector[4].ToString();
            lector.Close();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            subtotal = 0;
            bool existe = false;
            if (ValidarCamposProducto())
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    string idproducto = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    if (idproducto == txtIDProducto.Text)
                    {
                        int cantidadExistente = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                        cantidadExistente += Convert.ToInt32(txtCantidad.Text);
                        dataGridView1.Rows[i].Cells[2].Value = cantidadExistente.ToString();
                        dataGridView1.Rows[i].Cells[4].Value = cantidadExistente * Convert.ToDouble(txtCosto.Text);
                        existe = true;
                        break;
                    }
                }
                if (!existe)
                {
                    dataGridView1.Rows.Add(txtIDProducto.Text, cboProducto.Text, txtCantidad.Text, txtCosto.Text, (Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(txtCosto.Text)));
                }
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    subtotal += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                }
                iva = subtotal * 0.16;
                total = subtotal + iva;

                txtSubTotal.Text = subtotal.ToString();
                txtIva.Text = iva.ToString();
                txtotal.Text = total.ToString();

                txtIDProducto.Text = " ";
                txtIDCategoria.Text = " ";
                txtCosto.Text = " ";
                txtCantidad.Text = " ";
                txtUnidad.Text = " ";
                cboProducto.Items.Clear();
                cmdGrabar.Enabled = true;
                cboCategoria.Text = " ";
                cboProducto.Text = " ";
            }
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            string idproducto, cantidad, costo;
            int t;
            if (ValidarCampos())
            {
                string condicion = cboCondicion.SelectedItem.ToString();
                int condicion2 = cboCondicion.SelectedIndex;
                string fechaCompra = txtFechaCompra.Value.ToString("dd/MM/yyyy");
                if (condicion2 == 1)
                {
                    saldo = Convert.ToDouble(txtotal.Text);
                    fechaLimite = txtFechaLimite.Value.Day + "/" + txtFechaLimite.Value.Month + "/" + txtFechaLimite.Value.Year;
                    comando.CommandText = "UPDATE Proveedor SET saldoTotal = saldoTotal + " + Convert.ToDouble(txtotal.Text) + " WHERE IdProveedor = " + Convert.ToInt16(txtIDProveedor.Text);
                    comando.ExecuteNonQuery();
                }
                if (condicion2 == 0)
                {
                    saldo = 0;
                    fechaLimite = " ";
                }
                comando.CommandText = "INSERT INTO Compra (IdCompra, IdProveedor, Fecha, Factura, Condicion, SubTotal, Iva, Total, Saldo) " +
                      "VALUES (@IdCompra, @IdProveedor, @Fecha, @Factura, @Condicion, @SubTotal, @Iva, @Total, @Saldo)";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@IdCompra", Convert.ToInt16(txtIDCompra.Text));
                comando.Parameters.AddWithValue("@IdProveedor", Convert.ToInt16(txtIDProveedor.Text));
                comando.Parameters.AddWithValue("@Fecha", fechaCompra); // Asegúrate de que fechaCompra esté en el formato correcto
                comando.Parameters.AddWithValue("@Factura", txtFactura.Text);
                comando.Parameters.AddWithValue("@Condicion", condicion);
                comando.Parameters.AddWithValue("@SubTotal", Convert.ToDouble(txtSubTotal.Text));
                comando.Parameters.AddWithValue("@Iva", Convert.ToDouble(txtIva.Text));
                comando.Parameters.AddWithValue("@Total", Convert.ToDouble(txtotal.Text));
                comando.Parameters.AddWithValue("@Saldo", saldo);

                comando.ExecuteNonQuery();
                t = dataGridView1.Rows.Count - 2;
                for (int i = 0; i <= t; i++)
                {
                    idproducto = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    cantidad = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    costo = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    string r = "INSERT INTO DetalleCompra(IdCompra, IdProducto, Cantidad, Costo) VALUES (" + Convert.ToInt16(txtIDCompra.Text) + ", '" + idproducto + "', " + Convert.ToInt16(cantidad) + ", " + Convert.ToDouble(costo) + ")";
                    comando.CommandText = r;
                    comando.ExecuteNonQuery();
                }
                cmdAceptar.Enabled = false;
                txtIDCompra.Text = " ";
                txtIDProveedor.Text = " ";
                txtSaldoT.Text = " ";
                txtDomicilio.Text = " ";
                txtTelefono.Text = " ";
                txtSubTotal.Text = " ";
                txtIva.Text = " ";
                txtotal.Text = " ";
                txtIDProducto.Text = " ";
                txtIDCategoria.Text = " ";
                txtCosto.Text = " ";
                txtCantidad.Text = " ";
                txtUnidad.Text = " ";
                txtFactura.Text = " ";
                cboCategoria.Text = " ";
                cboProducto.Text = " ";
                cboProducto.Items.Clear();
                cboCategoria.Items.Clear();
                cboProveedor.Items.Clear();
                dataGridView1.Rows.Clear();
                cboCondicion.Text = " ";
                cboProducto.Text = " ";
                cboProveedor.Text = " ";
                label21.Visible = false;
                txtFechaLimite.Visible = false;
                cboCondicion.Enabled = false;
                cboProveedor.Enabled = false;
                cboCategoria.Enabled = false;
                cboProducto.Enabled = false;
                txtCantidad.Enabled = false;
                cmdGrabar.Enabled = false;
                txtFactura.Enabled = false;
                txtFechaCompra.Enabled = false;
                



            }
        }

        private void cboCondicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string condicion = cboCondicion.SelectedItem.ToString();
            int condicion2 = cboCondicion.SelectedIndex;
            if (condicion2 == 1)
            {
                txtFechaLimite.Visible = true;
                label21.Visible = true;
            }
        }

        private bool ValidarCamposProducto()
        {
            if (cboCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione una categoría", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cboProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Por favor, ingrese la cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private bool ValidarCampos()
        {
            if (cboProveedor.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cboCondicion.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione una condición.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
