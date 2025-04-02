using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Carniceria
{
    public partial class Categorias : Form
    {
        //SqlConnection conn = new SqlConnection("server=Enrique; database=SistemaCarniceria; integrated security = true");
        //SqlConnection conn = new SqlConnection("server=ALEXA-13; database=SistemaCarniceria; integrated security = true");
        SqlConnection conn = new SqlConnection("server=DESKTOP-14CCMAH\\SQLEXPRESS; database=SistemaCarniceria; integrated security = true");
        SqlCommand comando = new SqlCommand(); //Creamos un objeto que venga con toda la informacion
        SqlDataReader lector; //Ejecuta la accion del comando
        public Categorias()
        {
            InitializeComponent();
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            conn.Open(); //Abre la conexión
            comando = conn.CreateCommand();
            comando.CommandText = "Select * from Categorias";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                dataGridView1.Rows.Add(lector[0], lector[1]);
            }
            lector.Close();
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            txtConcepto.Text = " ";
            txtIDCategoria.Text = " ";
            txtConcepto.Enabled = true;
            string conteo;
            int conteo2;
            comando.CommandText = "SELECT COUNT(*) as num FROM Categorias";
            conteo = comando.ExecuteScalar().ToString();
            conteo2 = (int)Convert.ToInt32(conteo) + 1;
            txtIDCategoria.Text = conteo2.ToString();
            txtConcepto.Enabled = true;
            cmdGrabar.Enabled = true;
            cmdNuevo.Enabled = false;
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            comando.CommandText = "INSERT INTO Categorias (Nombre) VALUES ('" + txtConcepto.Text + "')";
            comando.ExecuteNonQuery();
            txtIDCategoria.Clear();
            txtConcepto.Clear();
            comando.CommandText = "Select * from Categorias";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                dataGridView1.Rows.Add(lector[0], lector[1]);
            }
            lector.Close();
            cmdGrabar.Enabled = false;
            cmdNuevo.Enabled = true;
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
