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
    public partial class Reportes : Form
    {

        int opc = 0;
        SqlConnection conn = new SqlConnection("server=Enrique; database=SistemaCarniceria; integrated security = true");
        SqlCommand comando = new SqlCommand(); //Creamos un objeto que venga con toda la informacion
        SqlDataReader lector; //Ejecuta la accion del comando

        public Reportes()
        {
            InitializeComponent();
        }

        private void clearVisible()
        {
            gbSelectorFecha.Visible = false;
            gbSeleccionarParametro.Visible = false;
            lblParametro.Text = "Parámetro:";
            cmdConsultar.Visible = false;
            cmdConsultar.Enabled = false;
            cboParametro.Items.Clear();
        }

        private void cmdCategorias_Click(object sender, EventArgs e)
        {
            clearVisible();
            ReportWindow reportWindow = new ReportWindow();
            reportWindow.hasParams = false;
            reportWindow.report = "ReporteCategorias";
            reportWindow.Show();
        }

        private void cmdProdGrl_Click(object sender, EventArgs e)
        {
            clearVisible();
            ReportWindow reportWindow = new ReportWindow();
            reportWindow.hasParams = false;
            reportWindow.report = "ReporteProductos";
            reportWindow.Show();
        }

        private void cmdProdCat_Click(object sender, EventArgs e)
        {
            clearVisible();
            cboParametro.Items.Clear();
            lblParametro.Text = "Categoría:";

            conn.Open(); //Abre la conexión
            comando = conn.CreateCommand();
            comando.CommandText = "Select * from Categorias";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                cboParametro.Items.Add(lector[1].ToString());
            }
            lector.Close();
            conn.Close();

            gbSeleccionarParametro.Visible = true;
            cmdConsultar.Visible = true;
            opc = 2;
        }

        private void cmdClientes_Click(object sender, EventArgs e)
        {
            clearVisible();
            ReportWindow reportWindow = new ReportWindow();
            reportWindow.hasParams = false;
            reportWindow.report = "ReporteClientes";
            reportWindow.Show();
        }

        private void cmdProveedores_Click(object sender, EventArgs e)
        {
            clearVisible();
            ReportWindow reportWindow = new ReportWindow();
            reportWindow.hasParams = false;
            reportWindow.report = "ReporteClientes";
            reportWindow.Show();
        }

        private void cmdVentasGeneral_Click(object sender, EventArgs e)
        {
            clearVisible();
            gbSelectorFecha.Visible = true;
            cmdConsultar.Visible = true;
            cmdConsultar.Enabled = true;
            opc = 1;
        }

        private void cmdVentasPorCliente_Click(object sender, EventArgs e)
        {
            clearVisible();
            opc = 4;
            lblParametro.Text = "Cliente:";

            conn.Open(); //Abre la conexión
            comando = conn.CreateCommand();
            comando.CommandText = "Select * from Cliente";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                cboParametro.Items.Add(lector[1].ToString());
            }
            lector.Close();
            conn.Close();

            gbSelectorFecha.Visible = true;
            gbSeleccionarParametro.Visible = true;
            cmdConsultar.Visible = true;
        }

        private void cmdComprasGeneral_Click(object sender, EventArgs e)
        {
            clearVisible();
            gbSelectorFecha.Visible = true;
            cmdConsultar.Visible = true;
            cmdConsultar.Enabled = true;
            opc = 3;
        }

        private void cmdComprasPorProveedor_Click(object sender, EventArgs e)
        {
            clearVisible();
            lblParametro.Text = "Proveedor:";
            opc = 5;

            conn.Open(); //Abre la conexión
            comando = conn.CreateCommand();
            comando.CommandText = "Select * from Proveedor";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                cboParametro.Items.Add(lector[1].ToString());
            }
            lector.Close();
            conn.Close();

            gbSelectorFecha.Visible = true;
            gbSeleccionarParametro.Visible = true;
            cmdConsultar.Visible = true;
        }

        private void cmdCobros_Click(object sender, EventArgs e)
        {
            clearVisible();
            ReportWindow reportWindow = new ReportWindow();
            reportWindow.hasParams = false;
            reportWindow.report = "ReporteCobros";
            reportWindow.Show();
        }

        private void cmdPagos_Click(object sender, EventArgs e)
        {
            clearVisible();
            ReportWindow reportWindow = new ReportWindow();
            reportWindow.hasParams = false;
            reportWindow.report = "ReportePagos";
            reportWindow.Show();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            ReportWindow reportWindow = new ReportWindow();
            DateTime fechaI = dtpFechaInicio.Value;
            DateTime fechaF = dtpFechaFin.Value;

            if (fechaF < fechaI)
            {
                MessageBox.Show("La segunda fecha(fin) no puede ser menor a la primera(inicio).");
                return;
            }

            String fechaInicio = fechaI.ToString("dd/MM/yyyy");
            String fechaFin = fechaF.ToString("dd/MM/yyyy");

            switch (opc)
            {
                case 1:
                    reportWindow.report = "ReporteVentasPorFecha";
                    reportWindow.fechaInicio = fechaInicio;
                    reportWindow.fechaFin = fechaFin;
                    reportWindow.fecha = true;
                    break;
                case 2:
                    reportWindow.report = "ReporteProductosxCat";
                    reportWindow.idCboValue = cboParametro.Text;
                    reportWindow.fecha = false;
                    break;
                case 3:
                    reportWindow.report = "ReporteCompras";
                    reportWindow.fechaInicio = fechaInicio;
                    reportWindow.fechaFin = fechaFin;
                    reportWindow.fecha = true;
                    break;
                case 4:
                    reportWindow.report = "VentasPorFechaYCliente";
                    reportWindow.fechaInicio = fechaInicio;
                    reportWindow.fechaFin = fechaFin;
                    reportWindow.idCboValue = cboParametro.Text;
                    reportWindow.fecha = true;
                    break;
                case 5:
                    reportWindow.report = "ReporteComprasPorProveedor";
                    reportWindow.fechaInicio = fechaInicio;
                    reportWindow.fechaFin = fechaFin;
                    reportWindow.idCboValue = cboParametro.Text;
                    reportWindow.fecha = true;
                    break;
                default:
                    break;
            }

            reportWindow.hasParams = true;
            reportWindow.opc = opc;
            //MessageBox.Show(fechaInicio + "   " + fechaFin + "    Reporte: " + opc);

            reportWindow.Show();
        }

        private void cboParametro_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdConsultar.Enabled = true;
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
