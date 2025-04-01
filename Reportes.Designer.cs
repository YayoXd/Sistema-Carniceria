namespace Sistema_Carniceria
{
    partial class Reportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.gbSeleccionarParametro = new System.Windows.Forms.GroupBox();
            this.cboParametro = new System.Windows.Forms.ComboBox();
            this.lblParametro = new System.Windows.Forms.Label();
            this.gbSelectorFecha = new System.Windows.Forms.GroupBox();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdPagos = new System.Windows.Forms.Button();
            this.cmdCobros = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdComprasGeneral = new System.Windows.Forms.Button();
            this.cmdComprasPorProveedor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdVentasPorCliente = new System.Windows.Forms.Button();
            this.cmdVentasGeneral = new System.Windows.Forms.Button();
            this.gbProveedor = new System.Windows.Forms.GroupBox();
            this.cmdProveedores = new System.Windows.Forms.Button();
            this.cmdClientes = new System.Windows.Forms.Button();
            this.cmdProdCat = new System.Windows.Forms.Button();
            this.cmdProdGrl = new System.Windows.Forms.Button();
            this.cmdCategorias = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSeleccionarParametro.SuspendLayout();
            this.gbSelectorFecha.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbProveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.cmdConsultar.Enabled = false;
            this.cmdConsultar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsultar.Image = ((System.Drawing.Image)(resources.GetObject("cmdConsultar.Image")));
            this.cmdConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdConsultar.Location = new System.Drawing.Point(559, 379);
            this.cmdConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(128, 47);
            this.cmdConsultar.TabIndex = 93;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = false;
            this.cmdConsultar.Visible = false;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // gbSeleccionarParametro
            // 
            this.gbSeleccionarParametro.Controls.Add(this.cboParametro);
            this.gbSeleccionarParametro.Controls.Add(this.lblParametro);
            this.gbSeleccionarParametro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSeleccionarParametro.Location = new System.Drawing.Point(317, 349);
            this.gbSeleccionarParametro.Margin = new System.Windows.Forms.Padding(2);
            this.gbSeleccionarParametro.Name = "gbSeleccionarParametro";
            this.gbSeleccionarParametro.Padding = new System.Windows.Forms.Padding(2);
            this.gbSeleccionarParametro.Size = new System.Drawing.Size(209, 113);
            this.gbSeleccionarParametro.TabIndex = 100;
            this.gbSeleccionarParametro.TabStop = false;
            this.gbSeleccionarParametro.Text = "Seleccionar parámetro:";
            this.gbSeleccionarParametro.Visible = false;
            // 
            // cboParametro
            // 
            this.cboParametro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParametro.FormattingEnabled = true;
            this.cboParametro.Location = new System.Drawing.Point(20, 61);
            this.cboParametro.Name = "cboParametro";
            this.cboParametro.Size = new System.Drawing.Size(172, 26);
            this.cboParametro.TabIndex = 91;
            this.cboParametro.SelectedIndexChanged += new System.EventHandler(this.cboParametro_SelectedIndexChanged);
            // 
            // lblParametro
            // 
            this.lblParametro.AutoSize = true;
            this.lblParametro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParametro.Location = new System.Drawing.Point(16, 33);
            this.lblParametro.Name = "lblParametro";
            this.lblParametro.Size = new System.Drawing.Size(74, 20);
            this.lblParametro.TabIndex = 90;
            this.lblParametro.Text = "Parámetro:";
            // 
            // gbSelectorFecha
            // 
            this.gbSelectorFecha.Controls.Add(this.dtpFechaFin);
            this.gbSelectorFecha.Controls.Add(this.label3);
            this.gbSelectorFecha.Controls.Add(this.dtpFechaInicio);
            this.gbSelectorFecha.Controls.Add(this.label2);
            this.gbSelectorFecha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSelectorFecha.Location = new System.Drawing.Point(20, 305);
            this.gbSelectorFecha.Margin = new System.Windows.Forms.Padding(2);
            this.gbSelectorFecha.Name = "gbSelectorFecha";
            this.gbSelectorFecha.Padding = new System.Windows.Forms.Padding(2);
            this.gbSelectorFecha.Size = new System.Drawing.Size(268, 188);
            this.gbSelectorFecha.TabIndex = 96;
            this.gbSelectorFecha.TabStop = false;
            this.gbSelectorFecha.Text = "Seleccionar periodo:";
            this.gbSelectorFecha.Visible = false;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Location = new System.Drawing.Point(33, 131);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 26);
            this.dtpFechaFin.TabIndex = 89;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 90;
            this.label3.Text = "Hasta:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Location = new System.Drawing.Point(33, 62);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 26);
            this.dtpFechaInicio.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 88;
            this.label2.Text = "Desde:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmdPagos);
            this.groupBox3.Controls.Add(this.cmdCobros);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(623, 56);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(197, 169);
            this.groupBox3.TabIndex = 99;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Movimientos";
            // 
            // cmdPagos
            // 
            this.cmdPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.cmdPagos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPagos.Image = ((System.Drawing.Image)(resources.GetObject("cmdPagos.Image")));
            this.cmdPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdPagos.Location = new System.Drawing.Point(17, 93);
            this.cmdPagos.Margin = new System.Windows.Forms.Padding(2);
            this.cmdPagos.Name = "cmdPagos";
            this.cmdPagos.Size = new System.Drawing.Size(165, 61);
            this.cmdPagos.TabIndex = 73;
            this.cmdPagos.Text = "Pagos";
            this.cmdPagos.UseVisualStyleBackColor = false;
            this.cmdPagos.Click += new System.EventHandler(this.cmdPagos_Click);
            // 
            // cmdCobros
            // 
            this.cmdCobros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.cmdCobros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCobros.Image = ((System.Drawing.Image)(resources.GetObject("cmdCobros.Image")));
            this.cmdCobros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCobros.Location = new System.Drawing.Point(17, 23);
            this.cmdCobros.Margin = new System.Windows.Forms.Padding(2);
            this.cmdCobros.Name = "cmdCobros";
            this.cmdCobros.Size = new System.Drawing.Size(165, 61);
            this.cmdCobros.TabIndex = 72;
            this.cmdCobros.Text = "Cobros";
            this.cmdCobros.UseVisualStyleBackColor = false;
            this.cmdCobros.Click += new System.EventHandler(this.cmdCobros_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdComprasGeneral);
            this.groupBox2.Controls.Add(this.cmdComprasPorProveedor);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(422, 56);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(197, 169);
            this.groupBox2.TabIndex = 98;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Compras";
            // 
            // cmdComprasGeneral
            // 
            this.cmdComprasGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.cmdComprasGeneral.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdComprasGeneral.Image = ((System.Drawing.Image)(resources.GetObject("cmdComprasGeneral.Image")));
            this.cmdComprasGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdComprasGeneral.Location = new System.Drawing.Point(16, 23);
            this.cmdComprasGeneral.Margin = new System.Windows.Forms.Padding(2);
            this.cmdComprasGeneral.Name = "cmdComprasGeneral";
            this.cmdComprasGeneral.Size = new System.Drawing.Size(165, 61);
            this.cmdComprasGeneral.TabIndex = 72;
            this.cmdComprasGeneral.Text = "Compras        General";
            this.cmdComprasGeneral.UseVisualStyleBackColor = false;
            this.cmdComprasGeneral.Click += new System.EventHandler(this.cmdComprasGeneral_Click);
            // 
            // cmdComprasPorProveedor
            // 
            this.cmdComprasPorProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.cmdComprasPorProveedor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdComprasPorProveedor.Image = ((System.Drawing.Image)(resources.GetObject("cmdComprasPorProveedor.Image")));
            this.cmdComprasPorProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdComprasPorProveedor.Location = new System.Drawing.Point(16, 93);
            this.cmdComprasPorProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.cmdComprasPorProveedor.Name = "cmdComprasPorProveedor";
            this.cmdComprasPorProveedor.Size = new System.Drawing.Size(165, 61);
            this.cmdComprasPorProveedor.TabIndex = 73;
            this.cmdComprasPorProveedor.Text = "Compras por proveedor";
            this.cmdComprasPorProveedor.UseVisualStyleBackColor = false;
            this.cmdComprasPorProveedor.Click += new System.EventHandler(this.cmdComprasPorProveedor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdVentasPorCliente);
            this.groupBox1.Controls.Add(this.cmdVentasGeneral);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(221, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(197, 169);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ventas";
            // 
            // cmdVentasPorCliente
            // 
            this.cmdVentasPorCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.cmdVentasPorCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVentasPorCliente.Image = ((System.Drawing.Image)(resources.GetObject("cmdVentasPorCliente.Image")));
            this.cmdVentasPorCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdVentasPorCliente.Location = new System.Drawing.Point(19, 93);
            this.cmdVentasPorCliente.Margin = new System.Windows.Forms.Padding(2);
            this.cmdVentasPorCliente.Name = "cmdVentasPorCliente";
            this.cmdVentasPorCliente.Size = new System.Drawing.Size(165, 61);
            this.cmdVentasPorCliente.TabIndex = 73;
            this.cmdVentasPorCliente.Text = "Ventas por        cliente";
            this.cmdVentasPorCliente.UseVisualStyleBackColor = false;
            this.cmdVentasPorCliente.Click += new System.EventHandler(this.cmdVentasPorCliente_Click);
            // 
            // cmdVentasGeneral
            // 
            this.cmdVentasGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.cmdVentasGeneral.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVentasGeneral.Image = ((System.Drawing.Image)(resources.GetObject("cmdVentasGeneral.Image")));
            this.cmdVentasGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdVentasGeneral.Location = new System.Drawing.Point(19, 23);
            this.cmdVentasGeneral.Margin = new System.Windows.Forms.Padding(2);
            this.cmdVentasGeneral.Name = "cmdVentasGeneral";
            this.cmdVentasGeneral.Size = new System.Drawing.Size(165, 61);
            this.cmdVentasGeneral.TabIndex = 72;
            this.cmdVentasGeneral.Text = "Ventas            General";
            this.cmdVentasGeneral.UseVisualStyleBackColor = false;
            this.cmdVentasGeneral.Click += new System.EventHandler(this.cmdVentasGeneral_Click);
            // 
            // gbProveedor
            // 
            this.gbProveedor.Controls.Add(this.cmdProveedores);
            this.gbProveedor.Controls.Add(this.cmdClientes);
            this.gbProveedor.Controls.Add(this.cmdProdCat);
            this.gbProveedor.Controls.Add(this.cmdProdGrl);
            this.gbProveedor.Controls.Add(this.cmdCategorias);
            this.gbProveedor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProveedor.Location = new System.Drawing.Point(20, 56);
            this.gbProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.gbProveedor.Name = "gbProveedor";
            this.gbProveedor.Padding = new System.Windows.Forms.Padding(2);
            this.gbProveedor.Size = new System.Drawing.Size(197, 235);
            this.gbProveedor.TabIndex = 95;
            this.gbProveedor.TabStop = false;
            this.gbProveedor.Text = "Catálogos";
            // 
            // cmdProveedores
            // 
            this.cmdProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.cmdProveedores.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProveedores.Image = ((System.Drawing.Image)(resources.GetObject("cmdProveedores.Image")));
            this.cmdProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdProveedores.Location = new System.Drawing.Point(16, 187);
            this.cmdProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.cmdProveedores.Name = "cmdProveedores";
            this.cmdProveedores.Size = new System.Drawing.Size(165, 37);
            this.cmdProveedores.TabIndex = 76;
            this.cmdProveedores.Text = "Proveedores";
            this.cmdProveedores.UseVisualStyleBackColor = false;
            this.cmdProveedores.Click += new System.EventHandler(this.cmdProveedores_Click);
            // 
            // cmdClientes
            // 
            this.cmdClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.cmdClientes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClientes.Image = ((System.Drawing.Image)(resources.GetObject("cmdClientes.Image")));
            this.cmdClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdClientes.Location = new System.Drawing.Point(16, 146);
            this.cmdClientes.Margin = new System.Windows.Forms.Padding(2);
            this.cmdClientes.Name = "cmdClientes";
            this.cmdClientes.Size = new System.Drawing.Size(165, 37);
            this.cmdClientes.TabIndex = 75;
            this.cmdClientes.Text = "Clientes";
            this.cmdClientes.UseVisualStyleBackColor = false;
            this.cmdClientes.Click += new System.EventHandler(this.cmdClientes_Click);
            // 
            // cmdProdCat
            // 
            this.cmdProdCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.cmdProdCat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProdCat.Image = ((System.Drawing.Image)(resources.GetObject("cmdProdCat.Image")));
            this.cmdProdCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdProdCat.Location = new System.Drawing.Point(16, 105);
            this.cmdProdCat.Margin = new System.Windows.Forms.Padding(2);
            this.cmdProdCat.Name = "cmdProdCat";
            this.cmdProdCat.Size = new System.Drawing.Size(165, 37);
            this.cmdProdCat.TabIndex = 74;
            this.cmdProdCat.Text = "Productos x Cat";
            this.cmdProdCat.UseVisualStyleBackColor = false;
            this.cmdProdCat.Click += new System.EventHandler(this.cmdProdCat_Click);
            // 
            // cmdProdGrl
            // 
            this.cmdProdGrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.cmdProdGrl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProdGrl.Image = ((System.Drawing.Image)(resources.GetObject("cmdProdGrl.Image")));
            this.cmdProdGrl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdProdGrl.Location = new System.Drawing.Point(16, 64);
            this.cmdProdGrl.Margin = new System.Windows.Forms.Padding(2);
            this.cmdProdGrl.Name = "cmdProdGrl";
            this.cmdProdGrl.Size = new System.Drawing.Size(165, 37);
            this.cmdProdGrl.TabIndex = 73;
            this.cmdProdGrl.Text = "Productos";
            this.cmdProdGrl.UseVisualStyleBackColor = false;
            this.cmdProdGrl.Click += new System.EventHandler(this.cmdProdGrl_Click);
            // 
            // cmdCategorias
            // 
            this.cmdCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.cmdCategorias.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCategorias.Image = ((System.Drawing.Image)(resources.GetObject("cmdCategorias.Image")));
            this.cmdCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCategorias.Location = new System.Drawing.Point(16, 23);
            this.cmdCategorias.Margin = new System.Windows.Forms.Padding(2);
            this.cmdCategorias.Name = "cmdCategorias";
            this.cmdCategorias.Size = new System.Drawing.Size(165, 37);
            this.cmdCategorias.TabIndex = 72;
            this.cmdCategorias.Text = "Categorías";
            this.cmdCategorias.UseVisualStyleBackColor = false;
            this.cmdCategorias.Click += new System.EventHandler(this.cmdCategorias_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.cmdSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Image = ((System.Drawing.Image)(resources.GetObject("cmdSalir.Image")));
            this.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSalir.Location = new System.Drawing.Point(707, 456);
            this.cmdSalir.Margin = new System.Windows.Forms.Padding(2);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(131, 37);
            this.cmdSalir.TabIndex = 94;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 42);
            this.label1.TabIndex = 92;
            this.label1.Text = "REPORTES";
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(859, 505);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.gbSeleccionarParametro);
            this.Controls.Add(this.gbSelectorFecha);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbProveedor);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.gbSeleccionarParametro.ResumeLayout(false);
            this.gbSeleccionarParametro.PerformLayout();
            this.gbSelectorFecha.ResumeLayout(false);
            this.gbSelectorFecha.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gbProveedor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.GroupBox gbSeleccionarParametro;
        private System.Windows.Forms.ComboBox cboParametro;
        private System.Windows.Forms.Label lblParametro;
        private System.Windows.Forms.GroupBox gbSelectorFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmdPagos;
        private System.Windows.Forms.Button cmdCobros;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdComprasGeneral;
        private System.Windows.Forms.Button cmdComprasPorProveedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdVentasPorCliente;
        private System.Windows.Forms.Button cmdVentasGeneral;
        private System.Windows.Forms.GroupBox gbProveedor;
        private System.Windows.Forms.Button cmdProveedores;
        private System.Windows.Forms.Button cmdClientes;
        private System.Windows.Forms.Button cmdProdCat;
        private System.Windows.Forms.Button cmdProdGrl;
        private System.Windows.Forms.Button cmdCategorias;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Label label1;
    }
}