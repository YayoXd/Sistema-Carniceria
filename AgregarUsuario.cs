using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_Carniceria
{
    public partial class AgregarUsuario : Form
    {
        SqlConnection conn = new SqlConnection("server=DESKTOP-14CCMAH\\SQLEXPRESS; database=SistemaCarniceria; integrated security = true");
        SqlCommand comando = new SqlCommand(); //Creamos un objeto que venga con toda la informacion
        SqlDataReader lector; //Ejecuta la accion del comando

        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            dataGridView1.Rows.Clear();
            conn.Open();
            SqlCommand comando = new SqlCommand("SELECT id_usuario,  nombre_usuario, rol, contrasena, fecha_creacion FROM usuarios", conn);
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                dataGridView1.Rows.Add(lector["id_usuario"], lector["nombre_usuario"], lector["rol"], lector["contrasena"], lector["fecha_creacion"]);
            }
            lector.Close();
            conn.Close();
        }

        private int ObtenerSiguienteID()
        {
            int siguienteID = 1; // Si no hay usuarios, empezamos en 1
            conn.Open();
            SqlCommand comando = new SqlCommand("SELECT ISNULL(MAX(id_usuario), 0) + 1 FROM usuarios", conn);
            siguienteID = (int)comando.ExecuteScalar();
            conn.Close();
            return siguienteID;
        }

        // Método para generar el hash MD5
        private string GenerarMD5(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "La cadena de entrada no puede ser nula.");
            }

            // Normalización de la cadena para evitar inconsistencias en la codificación, para trabajar con caracteres especiales
            string normalizedInput = input.Normalize(NormalizationForm.FormC);

            using (MD5 md5 = MD5.Create())
            {
                // Se convierte la cadena normalizedInput en un arreglo de bytes usando codificación UTF-8. 
                byte[] inputBytes = Encoding.UTF8.GetBytes(normalizedInput);
                //Se calcula el hash MD5 de los bytes de entrada y se obtiene un arreglo de bytes(hashBytes) de 16 elementos(128 bits).
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                //Conversión del hash a una cadena hexadecimal
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    //Cada byte del arreglo hashBytes se convierte en una representación hexadecimal de dos caracteres ("x2" asegura que siempre tenga dos dígitos, por ejemplo, 0a en lugar de a).
                    sb.Append(b.ToString("x2"));
                }
                //Retorno del hash en formato hexadecimal
                return sb.ToString();
            }
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDUsuario.Text);
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;
            string hashMD5 = GenerarMD5(contrasena); // Encriptar contraseña
            string rol = comboBox1.Text; // Asignamos un rol por defecto, puedes modificarlo según lo que elijas.

            // Abre la conexión a la base de datos
            conn.Open();

            // Comando SQL para insertar el usuario
            SqlCommand comando = new SqlCommand("INSERT INTO usuarios (id_usuario, nombre_usuario, contrasena, rol) VALUES (@id_usuario, @usuario, @contrasena, @rol)", conn);

            // Agregar parámetros para prevenir inyecciones SQL
            comando.Parameters.AddWithValue("@id_usuario", id);
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@contrasena", hashMD5);
            comando.Parameters.AddWithValue("@rol", rol);

            // Ejecutar el comando
            comando.ExecuteNonQuery();

            // Cerrar la conexión
            conn.Close();

            // Mensaje de éxito
            MessageBox.Show("Usuario registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Cargar la lista de usuarios (asumiendo que hay un método para esto)
            CargarUsuarios();

            txtIDUsuario.Text = " ";
            txtUsuario.Enabled = false;
            txtContrasena.Enabled = false;
            comboBox1.Enabled = false;
            txtUsuario.Clear();
            txtContrasena.Clear();
            comboBox1.Text = " ";

        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            int nuevoID = ObtenerSiguienteID();
            txtIDUsuario.Text = nuevoID.ToString();
            txtUsuario.Enabled = true;
            txtContrasena.Enabled = true;
            comboBox1.Enabled = true;
            txtUsuario.Clear();
            txtContrasena.Clear();
            comboBox1.Text = " ";
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
