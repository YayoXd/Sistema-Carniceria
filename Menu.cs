using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Carniceria
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Ingresar ingresar = new Ingresar();
            ingresar.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Ingresar ingresar = new Ingresar();
            ingresar.Show();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            cmdMaximizar.Visible = false;
            cmdRestaurar.Visible = true;
        }

        private void cmdRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Normal;
            cmdRestaurar.Visible= false;
            cmdMaximizar.Visible= true;
        }

        private void cmdMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AbrirFormHija(object formhija)
        {
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(fh);
            this.Contenedor.Tag = fh;
            fh.Show();
        }

        private void cmdCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Categorias());
        }

        private void cmdCliente_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Clientes());
        }

        private void cmdProductos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Productos());
        }

        private void cmdProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Proveedores());
        }

        private void cmdVentas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Ventas());
        }

        private void cmdCompras_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Compras());
        }

        private void cmdCobros_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Cobros());
        }

        private void cmdPagos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Pagos());
        }

        private void cmdConsulVentas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new ConsultaVentas());
        }

        private void cmdConsulCompras_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new ConsultaCompras());
        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdReportes_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Reportes());
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new ConsultarPagos());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new ConsultarCobros());
        }

        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string rutaR = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Ayuda2.chm");
                //MessageBox.Show(rutaR);
                System.Diagnostics.Process.Start(rutaR);
            }
        }
    }
}
