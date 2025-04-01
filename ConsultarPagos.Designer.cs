namespace Sistema_Carniceria
{
    partial class ConsultarPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarPagos));
            this.dgvPeriodo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.IdPago1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCompra1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGeneral = new System.Windows.Forms.DataGridView();
            this.IdPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.gBoxFechas = new System.Windows.Forms.GroupBox();
            this.cmdBuscar2 = new System.Windows.Forms.Button();
            this.dataTimeLimite = new System.Windows.Forms.DateTimePicker();
            this.dateTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdBuscarProveedor = new System.Windows.Forms.Button();
            this.txtDomicilio = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtIDProveedor = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmdCliente = new System.Windows.Forms.Button();
            this.cmdProducto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneral)).BeginInit();
            this.gBoxFechas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPeriodo
            // 
            this.dgvPeriodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeriodo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Nombre1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvPeriodo.Location = new System.Drawing.Point(114, 158);
            this.dgvPeriodo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPeriodo.Name = "dgvPeriodo";
            this.dgvPeriodo.RowHeadersWidth = 51;
            this.dgvPeriodo.RowTemplate.Height = 24;
            this.dgvPeriodo.Size = new System.Drawing.Size(665, 239);
            this.dgvPeriodo.TabIndex = 28;
            this.dgvPeriodo.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Pago";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "ID Compra";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // Nombre1
            // 
            this.Nombre1.HeaderText = "Empresa";
            this.Nombre1.MinimumWidth = 6;
            this.Nombre1.Name = "Nombre1";
            this.Nombre1.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Importe";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPago1,
            this.IdCompra1,
            this.Fecha1,
            this.Importe1});
            this.dgvProveedor.Location = new System.Drawing.Point(88, 173);
            this.dgvProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.RowHeadersWidth = 51;
            this.dgvProveedor.RowTemplate.Height = 24;
            this.dgvProveedor.Size = new System.Drawing.Size(712, 213);
            this.dgvProveedor.TabIndex = 27;
            this.dgvProveedor.Visible = false;
            // 
            // IdPago1
            // 
            this.IdPago1.HeaderText = "ID Pago";
            this.IdPago1.MinimumWidth = 6;
            this.IdPago1.Name = "IdPago1";
            this.IdPago1.Width = 125;
            // 
            // IdCompra1
            // 
            this.IdCompra1.HeaderText = "ID Compra";
            this.IdCompra1.MinimumWidth = 6;
            this.IdCompra1.Name = "IdCompra1";
            this.IdCompra1.Width = 125;
            // 
            // Fecha1
            // 
            this.Fecha1.HeaderText = "Fecha";
            this.Fecha1.MinimumWidth = 6;
            this.Fecha1.Name = "Fecha1";
            this.Fecha1.Width = 125;
            // 
            // Importe1
            // 
            this.Importe1.HeaderText = "Importe";
            this.Importe1.MinimumWidth = 6;
            this.Importe1.Name = "Importe1";
            this.Importe1.Width = 125;
            // 
            // dgvGeneral
            // 
            this.dgvGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeneral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPago,
            this.IdCompra,
            this.Empresa,
            this.Fecha,
            this.Importe});
            this.dgvGeneral.Location = new System.Drawing.Point(77, 158);
            this.dgvGeneral.Margin = new System.Windows.Forms.Padding(2);
            this.dgvGeneral.Name = "dgvGeneral";
            this.dgvGeneral.RowHeadersWidth = 51;
            this.dgvGeneral.RowTemplate.Height = 24;
            this.dgvGeneral.Size = new System.Drawing.Size(738, 246);
            this.dgvGeneral.TabIndex = 24;
            this.dgvGeneral.Visible = false;
            // 
            // IdPago
            // 
            this.IdPago.HeaderText = "ID Pago";
            this.IdPago.MinimumWidth = 6;
            this.IdPago.Name = "IdPago";
            this.IdPago.Width = 125;
            // 
            // IdCompra
            // 
            this.IdCompra.HeaderText = "ID Compra";
            this.IdCompra.MinimumWidth = 6;
            this.IdCompra.Name = "IdCompra";
            this.IdCompra.Width = 125;
            // 
            // Empresa
            // 
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.MinimumWidth = 6;
            this.Empresa.Name = "Empresa";
            this.Empresa.Width = 125;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 125;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.MinimumWidth = 6;
            this.Importe.Name = "Importe";
            this.Importe.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 42);
            this.label2.TabIndex = 20;
            this.label2.Text = "CONSULTAS DE PAGOS";
            // 
            // gBoxFechas
            // 
            this.gBoxFechas.Controls.Add(this.cmdBuscar2);
            this.gBoxFechas.Controls.Add(this.dataTimeLimite);
            this.gBoxFechas.Controls.Add(this.dateTimeInicio);
            this.gBoxFechas.Controls.Add(this.label8);
            this.gBoxFechas.Controls.Add(this.label9);
            this.gBoxFechas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxFechas.Location = new System.Drawing.Point(424, 23);
            this.gBoxFechas.Margin = new System.Windows.Forms.Padding(2);
            this.gBoxFechas.Name = "gBoxFechas";
            this.gBoxFechas.Padding = new System.Windows.Forms.Padding(2);
            this.gBoxFechas.Size = new System.Drawing.Size(434, 131);
            this.gBoxFechas.TabIndex = 87;
            this.gBoxFechas.TabStop = false;
            this.gBoxFechas.Text = "Fechas";
            this.gBoxFechas.Visible = false;
            // 
            // cmdBuscar2
            // 
            this.cmdBuscar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.cmdBuscar2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar2.Image = ((System.Drawing.Image)(resources.GetObject("cmdBuscar2.Image")));
            this.cmdBuscar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdBuscar2.Location = new System.Drawing.Point(296, 37);
            this.cmdBuscar2.Margin = new System.Windows.Forms.Padding(2);
            this.cmdBuscar2.Name = "cmdBuscar2";
            this.cmdBuscar2.Size = new System.Drawing.Size(115, 37);
            this.cmdBuscar2.TabIndex = 73;
            this.cmdBuscar2.Text = "Buscar";
            this.cmdBuscar2.UseVisualStyleBackColor = false;
            this.cmdBuscar2.Click += new System.EventHandler(this.cmdBuscar2_Click);
            // 
            // dataTimeLimite
            // 
            this.dataTimeLimite.Location = new System.Drawing.Point(107, 51);
            this.dataTimeLimite.Margin = new System.Windows.Forms.Padding(2);
            this.dataTimeLimite.Name = "dataTimeLimite";
            this.dataTimeLimite.Size = new System.Drawing.Size(180, 26);
            this.dataTimeLimite.TabIndex = 3;
            // 
            // dateTimeInicio
            // 
            this.dateTimeInicio.Location = new System.Drawing.Point(107, 16);
            this.dateTimeInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeInicio.Name = "dateTimeInicio";
            this.dateTimeInicio.Size = new System.Drawing.Size(180, 26);
            this.dateTimeInicio.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 56);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Fecha Limite:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 19);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Fecha Inicio:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdBuscarProveedor);
            this.groupBox1.Controls.Add(this.txtDomicilio);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtIDProveedor);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(428, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(420, 133);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proveedor";
            this.groupBox1.Visible = false;
            // 
            // cmdBuscarProveedor
            // 
            this.cmdBuscarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.cmdBuscarProveedor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("cmdBuscarProveedor.Image")));
            this.cmdBuscarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdBuscarProveedor.Location = new System.Drawing.Point(272, 92);
            this.cmdBuscarProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.cmdBuscarProveedor.Name = "cmdBuscarProveedor";
            this.cmdBuscarProveedor.Size = new System.Drawing.Size(131, 37);
            this.cmdBuscarProveedor.TabIndex = 72;
            this.cmdBuscarProveedor.Text = "Buscar";
            this.cmdBuscarProveedor.UseVisualStyleBackColor = false;
            this.cmdBuscarProveedor.Click += new System.EventHandler(this.cmdBuscarProveedor_Click);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Enabled = false;
            this.txtDomicilio.Location = new System.Drawing.Point(295, 30);
            this.txtDomicilio.Margin = new System.Windows.Forms.Padding(2);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(122, 26);
            this.txtDomicilio.TabIndex = 7;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(295, 59);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Mask = "000-000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(122, 26);
            this.txtTelefono.TabIndex = 6;
            // 
            // txtIDProveedor
            // 
            this.txtIDProveedor.Enabled = false;
            this.txtIDProveedor.Location = new System.Drawing.Point(116, 61);
            this.txtIDProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDProveedor.Mask = "99999";
            this.txtIDProveedor.Name = "txtIDProveedor";
            this.txtIDProveedor.Size = new System.Drawing.Size(101, 26);
            this.txtIDProveedor.TabIndex = 5;
            this.txtIDProveedor.ValidatingType = typeof(int);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(99, 31);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(118, 26);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(223, 67);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 18);
            this.label11.TabIndex = 3;
            this.label11.Text = "Telefono:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(220, 32);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 18);
            this.label12.TabIndex = 2;
            this.label12.Text = "Domicilio:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 67);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 18);
            this.label13.TabIndex = 1;
            this.label13.Text = "ID Proveedor:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 33);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 18);
            this.label14.TabIndex = 0;
            this.label14.Text = "Proveedor:";
            // 
            // cmdCliente
            // 
            this.cmdCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.cmdCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCliente.Image = ((System.Drawing.Image)(resources.GetObject("cmdCliente.Image")));
            this.cmdCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCliente.Location = new System.Drawing.Point(153, 82);
            this.cmdCliente.Margin = new System.Windows.Forms.Padding(2);
            this.cmdCliente.Name = "cmdCliente";
            this.cmdCliente.Size = new System.Drawing.Size(131, 37);
            this.cmdCliente.TabIndex = 85;
            this.cmdCliente.Text = "Proveedor";
            this.cmdCliente.UseVisualStyleBackColor = false;
            this.cmdCliente.Click += new System.EventHandler(this.cmdCliente_Click);
            // 
            // cmdProducto
            // 
            this.cmdProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.cmdProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProducto.Image = ((System.Drawing.Image)(resources.GetObject("cmdProducto.Image")));
            this.cmdProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdProducto.Location = new System.Drawing.Point(9, 82);
            this.cmdProducto.Margin = new System.Windows.Forms.Padding(2);
            this.cmdProducto.Name = "cmdProducto";
            this.cmdProducto.Size = new System.Drawing.Size(131, 37);
            this.cmdProducto.TabIndex = 84;
            this.cmdProducto.Text = "General";
            this.cmdProducto.UseVisualStyleBackColor = false;
            this.cmdProducto.Click += new System.EventHandler(this.cmdProducto_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(289, 80);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 37);
            this.button1.TabIndex = 83;
            this.button1.Text = "Periodo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.cmdSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Image = ((System.Drawing.Image)(resources.GetObject("cmdSalir.Image")));
            this.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSalir.Location = new System.Drawing.Point(692, 419);
            this.cmdSalir.Margin = new System.Windows.Forms.Padding(2);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(131, 37);
            this.cmdSalir.TabIndex = 87;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // ConsultarPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(873, 474);
            this.ControlBox = false;
            this.Controls.Add(this.gBoxFechas);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdCliente);
            this.Controls.Add(this.cmdProducto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvPeriodo);
            this.Controls.Add(this.dgvProveedor);
            this.Controls.Add(this.dgvGeneral);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConsultarPagos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ConsultarPagos";
            this.Load += new System.EventHandler(this.ConsultarPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneral)).EndInit();
            this.gBoxFechas.ResumeLayout(false);
            this.gBoxFechas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dgvProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPago1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCompra1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe1;
        private System.Windows.Forms.DataGridView dgvGeneral;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gBoxFechas;
        private System.Windows.Forms.Button cmdBuscar2;
        private System.Windows.Forms.DateTimePicker dataTimeLimite;
        private System.Windows.Forms.DateTimePicker dateTimeInicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdBuscarProveedor;
        private System.Windows.Forms.MaskedTextBox txtDomicilio;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.MaskedTextBox txtIDProveedor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button cmdCliente;
        private System.Windows.Forms.Button cmdProducto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdSalir;
    }
}