using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Carniceria
{
    public partial class Respaldar : Form
    {

        SqlConnection conn = new SqlConnection("server=Enrique; database=SistemaCarniceria; integrated security = true");
        SqlCommand comando = new SqlCommand(); //Creamos un objeto que venga con toda la informacion
        SqlDataReader lector; //Ejecuta la accion del comando

        public Respaldar()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void cmdCarpeta_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\SistemaCarniceriaRespaldos";
            Process.Start("explorer.exe", folderPath);
        }

        private void cmdCrearRespaldo_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                comando = conn.CreateCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "BackupSistemaCarniceria";

                comando.ExecuteNonQuery();

                MessageBox.Show("Base de datos respaldada con exito!", "Respaldación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
