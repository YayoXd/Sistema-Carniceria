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
    public partial class Proveedores : Form
    {
        //SqlConnection conn = new SqlConnection("server=Enrique; database=SistemaCarniceria; integrated security = true");
        //SqlConnection conn = new SqlConnection("server=ALEXA-13; database=SistemaCarniceria; integrated security = true");
        SqlConnection conn = new SqlConnection("server=DESKTOP-14CCMAH\\SQLEXPRESS; database=SistemaCarniceria; integrated security = true");
        SqlCommand comando = new SqlCommand(); //Creamos un objeto que venga con toda la informacion
        SqlDataReader lector; //Ejecuta la accion del comando
        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            conn.Open(); //Abre la conexión
            comando = conn.CreateCommand();
            comando.CommandText = "Select * from Proveedor";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                dataGridView1.Rows.Add(lector[0], lector[1], lector[2], lector[3], lector[4], lector[5], lector[6], lector[7], lector[8], lector[9], lector[10]);
            }
            lector.Close();
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            string conteo;
            int conteo2;
            comando.CommandText = "SELECT COUNT(*) as num FROM Proveedor";
            conteo = comando.ExecuteScalar().ToString();
            conteo2 = (int)Convert.ToInt32(conteo) + 1;
            txtIdProveedor.Text = conteo2.ToString();
            txtCiudad.Enabled = true;
            txtCodigoP.Enabled = true;
            txtColonia.Enabled = true;
            txtCorreo.Enabled = true;
            txtDomicilio.Enabled = true;
            txtEmpresa.Enabled = true;
            txtEstado.Enabled = true;
            txtRepresentante.Enabled = true;
            txtTelefono.Enabled = true;
            cmdNuevo.Enabled = false;
            cmdGrabar.Enabled = true;
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            comando.CommandText = "INSERT INTO Proveedor(Empresa, Representante, Domicilio, Colonia, CP, Telefono, Ciudad, Estado, Correo, SaldoTotal) VALUES('" + txtEmpresa.Text + "','" + txtRepresentante.Text + "','" + txtDomicilio.Text + "','" + txtColonia.Text + "','" + txtCodigoP.Text + "','" + txtTelefono.Text + "','" + txtCiudad.Text + "','" + txtEstado.Text + "','" + txtCorreo.Text + "', 0)";
            comando.ExecuteNonQuery();
            comando.CommandText = "Select * from Proveedor";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                dataGridView1.Rows.Add(lector[0], lector[1], lector[2], lector[3], lector[4], lector[5], lector[6], lector[7], lector[8], lector[9], lector[10]);
            }
            lector.Close();
            txtCiudad.Clear();
            txtCodigoP.Clear();
            txtTelefono.Clear();
            txtRepresentante.Clear();
            txtIdProveedor.Clear();
            txtDomicilio.Clear();
            txtCorreo.Clear();
            txtEstado.Clear();
            txtColonia.Clear();
            txtEmpresa.Clear();
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
