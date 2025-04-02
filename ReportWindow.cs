using Microsoft.Reporting.WinForms;
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
using System.IO;

namespace Sistema_Carniceria
{
    public partial class ReportWindow : Form
    {

        public bool hasParams { get; set; }
        public int opc { get; set; }
        public bool fecha { get; set; }
        public string report { get; set; }

        public string fechaInicio { get; set; }
        public string fechaFin { get; set; }
        public int idCbo { get; set; }
        public string idCboValue { get; set; }
        public int tolerancia { get; set; }

        SqlConnection conexion = new SqlConnection("server=DESKTOP-14CCMAH\\SQLEXPRESS; database=SistemaCarniceria; integrated security = true");//cambio cuando sea necesario
        SqlDataReader lector; //Ejecuta la accion del comando

        public ReportWindow()
        {
            InitializeComponent();
        }

        private void ReportWindow_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Opc: "+ opc + "\nFecha inicio: " + fechaInicio + "\nFecha fin: " + fechaFin + "\nReporte: " + report + "\nHasParams: " + hasParams + "\nFecha: " + fecha);
            try
            {
                if (hasParams)
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(report, conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    string FechaInicio = fechaInicio;
                    string FechaFin = fechaFin;

                    if (fecha)
                    {
                        SqlParameter param1 = new SqlParameter("@FechaInicio", SqlDbType.Date);
                        SqlParameter param2 = new SqlParameter("@FechaFin", SqlDbType.Date);
                        param1.Direction = ParameterDirection.Input;
                        param2.Direction = ParameterDirection.Input;
                        try {
                            param1.Value = DateTime.Parse(FechaInicio);
                            param2.Value = DateTime.Parse(FechaFin);
                            //MessageBox.Show("Fecha Inicio: " + FechaInicio);

                            //param1.Value = FechaInicio;
                            //param2.Value = FechaFin;
                        }
                        catch (Exception ed){
                            //MessageBox.Show("Error DateTimeParser: " + ed.Message);
                        }
                        cmd.Parameters.Add(param1);
                        cmd.Parameters.Add(param2);
                    }

                    switch (opc)
                    {
                        case 2:
                            SqlParameter param3 = new SqlParameter("@NombreCategoria", SqlDbType.NVarChar);
                            param3.Direction = ParameterDirection.Input;
                            param3.Value = idCboValue;
                            cmd.Parameters.Add(param3);
                            break;
                        case 4:
                            SqlParameter param4 = new SqlParameter("@NombreCliente", SqlDbType.NVarChar);
                            param4.Direction = ParameterDirection.Input;
                            param4.Value = idCboValue;
                            cmd.Parameters.Add(param4);
                            break;
                        case 5:
                            SqlParameter param5 = new SqlParameter("@NombreProveedor", SqlDbType.NVarChar);
                            param5.Direction = ParameterDirection.Input;
                            param5.Value = idCboValue;
                            cmd.Parameters.Add(param5);
                            break;
                        default:
                            break;
                    }

                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataSet Data = new DataSet();
                    adaptador.Fill(Data);
                    Data.DataSetName = "DataSet1";

                    ReportDataSource Reportes = new ReportDataSource("DataSet1", Data.Tables[0]);
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(Reportes);
                    reportViewer1.LocalReport.ReportPath = "Reportes\\" + report + ".rdlc";

                    switch (opc)
                    {
                        case 1:
                            ReportParameter p1 = new ReportParameter("FechaInicio", FechaInicio);
                            ReportParameter p2 = new ReportParameter("FechaFin", FechaFin);
                            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p1, p2 });
                            break;
                        case 2:
                            ReportParameter p3 = new ReportParameter("NombreCategoria", idCboValue);
                            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p3 });
                            break;
                        case 3:
                            ReportParameter p4 = new ReportParameter("FechaInicio", FechaInicio);
                            ReportParameter p5 = new ReportParameter("FechaFin", FechaFin);
                            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p4, p5 });
                            break;
                        case 4:
                            ReportParameter p6 = new ReportParameter("FechaInicio", FechaInicio);
                            ReportParameter p7 = new ReportParameter("FechaFin", FechaFin);
                            ReportParameter p8 = new ReportParameter("NombreCliente", idCboValue);
                            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p6, p7, p8 });
                            break;
                        case 5:
                            ReportParameter p9 = new ReportParameter("FechaInicio", FechaInicio);
                            ReportParameter p10 = new ReportParameter("FechaFin", FechaFin);
                            ReportParameter p11 = new ReportParameter("NombreProveedor", idCboValue);
                            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p9, p10, p11 });
                            break;
                        default:
                            MessageBox.Show("Error en la opción elegida.");
                            break;
                    }

                    this.reportViewer1.RefreshReport();
                    conexion.Close();
                }
                else
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(report, conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataSet Data = new DataSet();
                    adaptador.Fill(Data);
                    Data.DataSetName = "DataSet1";

                    ReportDataSource Reportes = new ReportDataSource("DataSet1", Data.Tables[0]);
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(Reportes);
                  
                    reportViewer1.LocalReport.ReportPath = "C:\\Users\\LENOVO\\Desktop\\Sistema Carniceria\\Reportes\\" + report + ".rdlc";

                    this.reportViewer1.RefreshReport();
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("No existe la base de datos.");
                MessageBox.Show(ex.Message);
            }
        }
    }
}
