using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Data.SqlClient;

namespace Sistema_Carniceria
{
    public partial class Productos : Form
    {
        //SqlConnection conn = new SqlConnection("server=Enrique; database=SistemaCarniceria; integrated security = true");
        //SqlConnection conn = new SqlConnection("server=ALEXA-13; database=SistemaCarniceria; integrated security = true");
        SqlConnection conn = new SqlConnection("server=DESKTOP-14CCMAH\\SQLEXPRESS; database=SistemaCarniceria; integrated security = true");
        SqlCommand comando = new SqlCommand(); //Creamos un objeto que venga con toda la informacion
        SqlDataReader lector; //Ejecuta la accion del comando
        //string rutaImagen;
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            conn.Open(); //Abre la conexión
            comando = conn.CreateCommand();
            comando.CommandText = "Select p.Codigo, c.Nombre, p.Descripcion, p.Unidad, p.Precio, p.Costo FROM Categorias As c Inner Join Producto As p on c.IdCategoria = p.IdCategoria";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                //string urlImagen = lector["Imagen"].ToString(); // Suponiendo que la columna "Imagen" contiene la URL de la imagen
                //Bitmap imagen = new Bitmap(urlImagen);

                dataGridView1.Rows.Add(lector["Codigo"].ToString(), lector["Nombre"].ToString(), lector["Descripcion"].ToString(), lector["Unidad"].ToString(), lector["Precio"].ToString(), lector["Costo"].ToString());
            }

            lector.Close();
            /*dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewImageColumn imagenColumna = (DataGridViewImageColumn)dataGridView1.Columns["Imagen"];
            imagenColumna.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imagenColumna.DefaultCellStyle.NullValue = null;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;*/
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            comando.CommandText = "SELECT * FROM Categorias";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                comboBox1.Items.Add(lector[1].ToString());
            }
            lector.Close();
            txtCosto.Enabled = true;
            txtDescripcion.Enabled = true;
            txtPrecio.Enabled = true;
            txtUnidad.Enabled = true;
            comboBox1.Enabled = true;
            txtIDProducto.Enabled = true;
            cmdNuevo.Enabled = false;
            cmdGrabar.Enabled = true;
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            comando.Parameters.Clear();
            comando.CommandText = "INSERT INTO producto (Codigo, IdCategoria, Descripcion, Precio, Unidad, Costo) VALUES (@Codigo, @IdCategoria, @Descripcion, @Precio, @Unidad, @Costo)";
            comando.Parameters.AddWithValue("@Codigo", txtIDProducto.Text);
            comando.Parameters.AddWithValue("@IdCategoria", Convert.ToInt16(txtIdCategoria.Text));
            comando.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
            comando.Parameters.AddWithValue("@Precio", Convert.ToDouble(txtPrecio.Text));
            comando.Parameters.AddWithValue("@Unidad", txtUnidad.Text); // Asegúrate de agregar el parámetro correcto si faltaba
            comando.Parameters.AddWithValue("@Costo", Convert.ToDouble(txtCosto.Text));
           // comando.Parameters.AddWithValue("@Imagen", rutaImagen); // Corregido el nombre del parámetro
            comando.ExecuteNonQuery();

            comando.CommandText = "Select p.Codigo, c.Nombre, p.Descripcion, p.Unidad, p.Precio, p.Costo FROM Categorias As c Inner Join Producto As p on c.IdCategoria = p.IdCategoria";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                //string urlImagen = lector["Imagen"].ToString(); // Suponiendo que la columna "Imagen" contiene la URL de la imagen
               // Bitmap imagen = new Bitmap(urlImagen);

                dataGridView1.Rows.Add(lector["Codigo"].ToString(), lector["Nombre"].ToString(), lector["Descripcion"].ToString(), lector["Unidad"].ToString(), lector["Precio"].ToString(), lector["Costo"].ToString());
            }

            lector.Close();
           /* dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewImageColumn imagenColumna = (DataGridViewImageColumn)dataGridView1.Columns["Imagen"];
            imagenColumna.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imagenColumna.DefaultCellStyle.NullValue = null;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;*/

            txtCosto.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtIdCategoria.Clear();
            txtIDProducto.Clear();
            txtUnidad.Items.Clear();
            comboBox1.Text = " ";
            cmdGrabar.Enabled = false;
            cmdNuevo.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comando.CommandText = "SELECT * FROM Categorias WHERE Nombre = '" + comboBox1.Text + "'";
            lector = comando.ExecuteReader();
            lector.Read();
            txtIdCategoria.Text = lector[0].ToString();
            lector.Close();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void cmdSubirImagen_Click(object sender, EventArgs e)
        {
           /* rutaImagen = " ";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Archivos de imagen|*jpg;*jpeg;*.pgn;*.gif";  
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rutaImagen = openFileDialog1.FileName;
                pictureBox1.ImageLocation = rutaImagen;
            }*/
        }
    }
}
