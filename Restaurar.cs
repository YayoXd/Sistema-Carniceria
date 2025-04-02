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
    public partial class Restaurar : Form
    {

        SqlConnection conn = new SqlConnection("server=Enrique; database=master; integrated security = true");
        SqlCommand comando = new SqlCommand(); //Creamos un objeto que venga con toda la informacion
        SqlDataReader lector; //Ejecuta la accion del comando

        public Restaurar()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void cmdRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Backup Files (*.bak)|*.bak|All Files (*.*)|*.*";
                openFileDialog.Title = "Select a Backup File";
                openFileDialog.InitialDirectory = @"C:\SistemaCarniceriaRespaldos";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string backupPath = openFileDialog.FileName;

                    conn.Open();
                    comando = conn.CreateCommand();
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "RestoreSistemaCarniceria";

                    comando.Parameters.AddWithValue("@BackupPath", backupPath);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Base de datos restaurada con éxito!", "Restauración", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se seleccionó ningún archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
