using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Expect.Open.Types;

namespace Sistema_Carniceria
{
    public partial class Ventas : Form
    {
        //SqlConnection conn = new SqlConnection("server=Enrique; database=SistemaCarniceria; integrated security = true");
        //SqlConnection conn = new SqlConnection("server=ALEXA-13; database=SistemaCarniceria; integrated security = true");
        SqlConnection conn = new SqlConnection("server=Enrique; database=SistemaCarniceria; integrated security = true");
        SqlCommand comando = new SqlCommand(); //Creamos un objeto que venga con toda la informacion
        SqlDataReader lector; //Ejecuta la accion del comando
        double subtotal, iva, total, saldo;
        string fechaLimite;

        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            conn.Open();
            comando = conn.CreateCommand(); //Se enlaza el comando con la conexion
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            cmdAceptar.Enabled = true;
            txtIDVenta.Text = " ";
            txtFechaVenta.Text = " ";
            txtHora.Text = " ";
            txtIDCliente.Text = " ";
            txtSaldoT.Text = " ";
            txtDomicilio.Text = " ";
            txtTelefono.Text = " ";
            txtSubTotal.Text = " ";
            txtIva.Text = " ";
            txtotal.Text = " ";
            txtIDProducto.Text = " ";
            txtIDCategoria.Text = " ";
            txtPrecio.Text = " ";
            txtCantidad.Text = " ";
            txtUnidad.Text = " ";

            cboProducto.Items.Clear();
            cboCategoria.Items.Clear();
            cboCliente.Items.Clear();
            dataGridView1.Rows.Clear();

            txtFechaLimite.Visible = false;
            label21.Visible = false;
            cboCondicion.Enabled = true;
            cboCliente.Enabled = true;
            cboCategoria.Enabled = true;
            cboProducto.Enabled = true;
            txtCantidad.Enabled = true;

            string a, fecha, b, hora;
            string conteo;
            int conteo2;

            // Obtener la fecha en formato 'dd/MM/yyyy'
            a = "SELECT FORMAT(GETDATE(), 'dd/MM/yyyy')";
            comando.CommandText = a;
            fecha = (string)comando.ExecuteScalar();
            txtFechaVenta.Text = fecha;

            // Obtener la hora en formato 'HH:mm:ss'
            b = "SELECT FORMAT(GETDATE(), 'HH:mm:ss')";
            comando.CommandText = b;
            hora = (string)comando.ExecuteScalar();
            txtHora.Text = hora;

            // Obtener el conteo de registros en la tabla 'venta'
            comando.CommandText = "SELECT COUNT(*) as num FROM Venta";
            conteo = comando.ExecuteScalar().ToString();
            conteo2 = (int)Convert.ToInt32(conteo) + 1;
            txtIDVenta.Text = conteo2.ToString();

            comando.CommandText = "Select * from Cliente";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                cboCliente.Items.Add(lector[1]);
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

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            comando.CommandText = "Select * from Cliente where Nombre = '" + cboCliente.Text + "'";
            lector = comando.ExecuteReader();
            lector.Read();
            txtIDCliente.Text = lector[0].ToString();
            txtTelefono.Text = lector[2].ToString();
            txtDomicilio.Text = lector[3].ToString();
            txtSaldoT.Text = lector[6].ToString();
            lector.Close();
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboProducto.Items.Clear();
            comando.CommandText = "Select * from categorias where Nombre = '" + cboCategoria.Text + "'";
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
            txtPrecio.Text = lector[3].ToString();
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
                        dataGridView1.Rows[i].Cells[4].Value = cantidadExistente * Convert.ToDouble(txtPrecio.Text);
                        existe = true;
                        break;
                    }
                }
                if (!existe)
                {
                    dataGridView1.Rows.Add(txtIDProducto.Text, cboProducto.Text, txtCantidad.Text, txtPrecio.Text, (Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text)));
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
                txtPrecio.Text = " ";
                txtCantidad.Text = " ";
                txtUnidad.Text = " ";
                cboCategoria.Text = "";
                cboProducto.Text = "";
                cboProducto.Items.Clear();
                cmdGrabar.Enabled = true;
            }
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            string idproducto, cantidad, precio;
            int t;
            if (ValidarCampos())
            {
                string condicion = cboCondicion.SelectedItem.ToString();
                int condicion2 = cboCondicion.SelectedIndex;
                if (condicion2 == 1)
                {
                    saldo = Convert.ToDouble(txtotal.Text);
                    fechaLimite = txtFechaLimite.Value.Day + "/" + txtFechaLimite.Value.Month + "/" + txtFechaLimite.Value.Year;
                    comando.CommandText = "UPDATE Cliente SET saldoTotal = saldoTotal + " + Convert.ToDouble(txtotal.Text) + " WHERE IdCliente = " + Convert.ToInt16(txtIDCliente.Text);
                    comando.ExecuteNonQuery();
                }
                if (condicion2 == 0)
                {
                    saldo = 0;
                    fechaLimite = " ";
                }
                comando.CommandText = "INSERT INTO Venta (IdVenta, IdCliente, Fecha, Hora, Tipo, SubTotal, Iva, Total, Saldo) " +
                      "VALUES (@IdVenta, @IdCliente, @Fecha, @Hora, @Tipo, @SubTotal, @Iva, @Total, @Saldo)";

                // Agrega los parámetros con valores adecuados
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@IdVenta", Convert.ToInt16(txtIDVenta.Text));
                comando.Parameters.AddWithValue("@IdCliente", Convert.ToInt16(txtIDCliente.Text));
                comando.Parameters.AddWithValue("@Fecha", txtFechaVenta.Text);
                comando.Parameters.AddWithValue("@Hora", txtHora.Text);
                comando.Parameters.AddWithValue("@Tipo", condicion); // Suponiendo que 'condicion' ya está definida
                comando.Parameters.AddWithValue("@SubTotal", Convert.ToDouble(txtSubTotal.Text)); // Asegúrate de definir 'subTotal' previamente
                comando.Parameters.AddWithValue("@Iva", Convert.ToDouble(txtIva.Text));          // Asegúrate de definir 'iva' previamente
                comando.Parameters.AddWithValue("@Total", Convert.ToDouble(txtotal.Text));      // Asegúrate de definir 'total' previamente
                comando.Parameters.AddWithValue("@Saldo", saldo);      // Asegúrate de definir 'saldo' previamente

                comando.ExecuteNonQuery();
                t = dataGridView1.Rows.Count - 2;
                for (int i = 0; i <= t; i++)
                {
                    idproducto = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    cantidad = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    precio = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    comando.CommandText = "INSERT INTO DetalleVenta(IdVenta, IdProducto, Cantidad, Precio) VALUES (" + Convert.ToInt16(txtIDVenta.Text) + ", '" + idproducto + "', " + Convert.ToInt16(cantidad) + ", " + Convert.ToDouble(precio) + ")";
                    comando.ExecuteNonQuery();
                }
                cmdAceptar.Enabled = false;
                txtIDVenta.Text = " ";
                txtFechaVenta.Text = " ";
                txtHora.Text = " ";
                txtIDCliente.Text = " ";
                txtSaldoT.Text = " ";
                txtDomicilio.Text = " ";
                txtTelefono.Text = " ";
                txtSubTotal.Text = " ";
                txtIva.Text = " ";
                txtotal.Text = " ";
                txtIDProducto.Text = " ";
                txtIDCategoria.Text = " ";
                txtPrecio.Text = " ";
                txtCantidad.Text = " ";
                txtUnidad.Text = " ";

                cboProducto.Text = " ";
                cboCategoria.Text = " ";
                cboCliente.Text = " ";
                cboCondicion.Text = " ";
                dataGridView1.Rows.Clear();
                cboCondicion.Enabled = false;
                cboCliente.Enabled = false;
                cboCategoria.Enabled = false;
                cboProducto.Enabled = false;
                txtCantidad.Enabled = false;
                cmdGrabar.Enabled = false;
                txtFechaLimite.Visible = false;
                label21.Visible = false;
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
            if (cboCondicion.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione una condición.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cboCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Por favor, agregue datos a rejilla antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
