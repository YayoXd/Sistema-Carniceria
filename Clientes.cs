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
    public partial class Clientes : Form
    {
        //SqlConnection conn = new SqlConnection("server=Enrique; database=SistemaCarniceria; integrated security = true");
        //SqlConnection conn = new SqlConnection("server=ALEXA-13; database=SistemaCarniceria; integrated security = true");
        SqlConnection conn = new SqlConnection("server=Enrique; database=SistemaCarniceria; integrated security = true");
        SqlCommand comando = new SqlCommand(); //Creamos un objeto que venga con toda la informacion
        SqlDataReader lector; //Ejecuta la accion del comando
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            conn.Open(); //Abre la conexión
            comando = conn.CreateCommand();
            comando.CommandText = "Select * from Cliente";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                dataGridView1.Rows.Add(lector[0], lector[1], lector[2], lector[3], lector[4], lector[5], lector[6]);
            }
            lector.Close();
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            txtColonia.Enabled = true;
            txtCp.Enabled = true;
            txtDomicilio.Enabled = true;
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
            string conteo;
            int conteo2;
            comando.CommandText = "SELECT COUNT(*) as num FROM Cliente";
            conteo = comando.ExecuteScalar().ToString();
            conteo2 = (int)Convert.ToInt32(conteo) + 1;
            txtIDCliente.Text = conteo2.ToString();
            cmdNuevo.Enabled = false;
            cmdGrabar.Enabled = true;
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            comando.CommandText = "INSERT INTO Cliente (Nombre, Telefono, Domicilio, Colonia, CP, SaldoTotal) VALUES('" + txtNombre.Text + "','" + txtTelefono.Text + "','" + txtDomicilio.Text + "','" + txtColonia.Text + "','" + txtCp.Text + "', 0)";
            comando.ExecuteNonQuery();
            comando.CommandText = "Select * from Cliente";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                dataGridView1.Rows.Add(lector[0], lector[1], lector[2], lector[3], lector[4], lector[5], lector[6]);
            }
            lector.Close();
            txtColonia.Clear();
            txtDomicilio.Clear();
            txtCp.Clear();
            txtIDCliente.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            cmdNuevo.Enabled = true;
            cmdGrabar.Enabled = false;
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
