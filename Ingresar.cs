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

namespace Sistema_Carniceria
{
    public partial class Ingresar : Form
    {
        SqlConnection conn = new SqlConnection("server=MAZARI_BALTAZAR; database=SistemaCarniceria; integrated security = true");

        public Ingresar()
        {
            InitializeComponent();
        }

        private void cmdIngresar_Click(object sender, EventArgs e)
        {
            string usuario = comboBox1.Text.Trim(); // Asegurar que no haya espacios extras
            string contrasenaIngresada = txtContrasena.Text;
            string hashMD5 = GenerarMD5(contrasenaIngresada); // Encriptar la contraseña ingresada

            try
            {
                conn.Open();
                // Cambiar el nombre de la columna 'Usuario' a 'nombre_usuario' y 'Contrasena' a 'contrasena'
                SqlCommand comando = new SqlCommand("SELECT contrasena FROM usuarios WHERE nombre_usuario = @usuario", conn);
                comando.Parameters.AddWithValue("@usuario", usuario);
                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    string contrasenaGuardada = lector["contrasena"].ToString().Trim(); // Limpiar posibles espacios
                    lector.Close();
                    conn.Close();

                    // DEBUG: Mostrar valores en un MessageBox
                    MessageBox.Show($"Hash ingresado: {hashMD5}\nHash guardado: {contrasenaGuardada}", "DEBUG");

                    if (string.Equals(contrasenaGuardada, hashMD5, StringComparison.OrdinalIgnoreCase)) // Comparación sin importar mayúsculas/minúsculas
                    {
                        MessageBox.Show("Contraseña correcta", "Acceso permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); // Cerrar formulario
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                lector.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Ingresar_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        // Método para generar el hash MD5
        private string GenerarMD5(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "La cadena de entrada no puede ser nula.");
            }

            // Normalización de la cadena para evitar inconsistencias en la codificación
            string normalizedInput = input.Normalize(NormalizationForm.FormC);

            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(normalizedInput); // Asegurar que se use UTF-8
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }

        private void CargarUsuarios()
        {
            try
            {
                conn.Open();
                SqlCommand comando = new SqlCommand("SELECT nombre_usuario FROM usuarios", conn);
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    comboBox1.Items.Add(lector["nombre_usuario"].ToString());
                }
                lector.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}