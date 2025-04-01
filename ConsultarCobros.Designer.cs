namespace Sistema_Carniceria
{
    partial class ConsultarCobros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarCobros));
            this.dgvPeriodo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.IdCobro1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdVenta1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGeneral = new System.Windows.Forms.DataGridView();
            this.IdCobro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.gBoxFechas = new System.Windows.Forms.GroupBox();
            this.cmdBuscar2 = new System.Windows.Forms.Button();
            this.dataTimeLimite = new System.Windows.Forms.DateTimePicker();
            this.dataTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.cmdBuscarCliente = new System.Windows.Forms.Button();
            this.txtDomicilio = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtIDCliente = new System.Windows.Forms.MaskedTextBox();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdCliente = new System.Windows.Forms.Button();
            this.cmdProducto = new System.Windows.Forms.Button();
            this.cmdPeriodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneral)).BeginInit();
            this.gBoxFechas.SuspendLayout();
            this.gbCliente.SuspendLayout();
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
            this.dgvPeriodo.Location = new System.Drawing.Point(104, 140);
            this.dgvPeriodo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPeriodo.Name = "dgvPeriodo";
            this.dgvPeriodo.RowHeadersWidth = 51;
            this.dgvPeriodo.RowTemplate.Height = 24;
            this.dgvPeriodo.Size = new System.Drawing.Size(665, 239);
            this.dgvPeriodo.TabIndex = 27;
            this.dgvPeriodo.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Cobro";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "ID Venta";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // Nombre1
            // 
            this.Nombre1.HeaderText = "Nombre";
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
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCobro1,
            this.IdVenta1,
            this.Fecha1,
            this.Importe1});
            this.dgvCliente.Location = new System.Drawing.Point(104, 157);
            this.dgvCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowHeadersWidth = 51;
            this.dgvCliente.RowTemplate.Height = 24;
            this.dgvCliente.Size = new System.Drawing.Size(665, 239);
            this.dgvCliente.TabIndex = 25;
            this.dgvCliente.Visible = false;
            // 
            // IdCobro1
            // 
            this.IdCobro1.HeaderText = "ID Cobro";
            this.IdCobro1.MinimumWidth = 6;
            this.IdCobro1.Name = "IdCobro1";
            this.IdCobro1.Width = 125;
            // 
            // IdVenta1
            // 
            this.IdVenta1.HeaderText = "ID Venta";
            this.IdVenta1.MinimumWidth = 6;
            this.IdVenta1.Name = "IdVenta1";
            this.IdVenta1.Width = 125;
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
            this.IdCobro,
            this.IdVenta,
            this.Nombre,
            this.Fecha,
            this.Importe});
            this.dgvGeneral.Location = new System.Drawing.Point(48, 140);
            this.dgvGeneral.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvGeneral.Name = "dgvGeneral";
            this.dgvGeneral.RowHeadersWidth = 51;
            this.dgvGeneral.RowTemplate.Height = 24;
            this.dgvGeneral.Size = new System.Drawing.Size(781, 278);
            this.dgvGeneral.TabIndex = 22;
            this.dgvGeneral.Visible = false;
            // 
            // IdCobro
            // 
            this.IdCobro.HeaderText = "ID Cobro";
            this.IdCobro.MinimumWidth = 6;
            this.IdCobro.Name = "IdCobro";
            this.IdCobro.Width = 125;
            // 
            // IdVenta
            // 
            this.IdVenta.HeaderText = "ID Venta";
            this.IdVenta.MinimumWidth = 6;
            this.IdVenta.Name = "IdVenta";
            this.IdVenta.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
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
            this.label2.Location = new System.Drawing.Point(21, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 42);
            this.label2.TabIndex = 18;
            this.label2.Text = "CONSULTAS DE COBRO";
            // 
            // cmdSalir
            // 
            this.cmdSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.cmdSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Image = ((System.Drawing.Image)(resources.GetObject("cmdSalir.Image")));
            this.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSalir.Location = new System.Drawing.Point(760, 432);
            this.cmdSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(131, 37);
            this.cmdSalir.TabIndex = 69;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // gBoxFechas
            // 
            this.gBoxFechas.Controls.Add(this.cmdBuscar2);
            this.gBoxFechas.Controls.Add(this.dataTimeLimite);
            this.gBoxFechas.Controls.Add(this.dataTimeInicio);
            this.gBoxFechas.Controls.Add(this.label7);
            this.gBoxFechas.Controls.Add(this.label8);
            this.gBoxFechas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxFechas.Location = new System.Drawing.Point(426, 7);
            this.gBoxFechas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBoxFechas.Name = "gBoxFechas";
            this.gBoxFechas.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBoxFechas.Size = new System.Drawing.Size(416, 104);
            this.gBoxFechas.TabIndex = 80;
            this.gBoxFechas.TabStop = false;
            this.gBoxFechas.Visible = false;
            // 
            // cmdBuscar2
            // 
            this.cmdBuscar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.cmdBuscar2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar2.Image = ((System.Drawing.Image)(resources.GetObject("cmdBuscar2.Image")));
            this.cmdBuscar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdBuscar2.Location = new System.Drawing.Point(296, 37);
            this.cmdBuscar2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.dataTimeLimite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataTimeLimite.Name = "dataTimeLimite";
            this.dataTimeLimite.Size = new System.Drawing.Size(180, 26);
            this.dataTimeLimite.TabIndex = 3;
            // 
            // dataTimeInicio
            // 
            this.dataTimeInicio.Location = new System.Drawing.Point(107, 16);
            this.dataTimeInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataTimeInicio.Name = "dataTimeInicio";
            this.dataTimeInicio.Size = new System.Drawing.Size(180, 26);
            this.dataTimeInicio.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 56);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Fecha Limite:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Fecha Inicio:";
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.cmdBuscarCliente);
            this.gbCliente.Controls.Add(this.txtDomicilio);
            this.gbCliente.Controls.Add(this.txtTelefono);
            this.gbCliente.Controls.Add(this.txtIDCliente);
            this.gbCliente.Controls.Add(this.cboCliente);
            this.gbCliente.Controls.Add(this.label5);
            this.gbCliente.Controls.Add(this.label4);
            this.gbCliente.Controls.Add(this.label3);
            this.gbCliente.Controls.Add(this.label1);
            this.gbCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(426, 8);
            this.gbCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbCliente.Size = new System.Drawing.Size(420, 133);
            this.gbCliente.TabIndex = 79;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            this.gbCliente.Visible = false;
            // 
            // cmdBuscarCliente
            // 
            this.cmdBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.cmdBuscarCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("cmdBuscarCliente.Image")));
            this.cmdBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdBuscarCliente.Location = new System.Drawing.Point(272, 92);
            this.cmdBuscarCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdBuscarCliente.Name = "cmdBuscarCliente";
            this.cmdBuscarCliente.Size = new System.Drawing.Size(131, 37);
            this.cmdBuscarCliente.TabIndex = 72;
            this.cmdBuscarCliente.Text = "Buscar";
            this.cmdBuscarCliente.UseVisualStyleBackColor = false;
            this.cmdBuscarCliente.Click += new System.EventHandler(this.cmdBuscarCliente_Click);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Enabled = false;
            this.txtDomicilio.Location = new System.Drawing.Point(283, 31);
            this.txtDomicilio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(134, 26);
            this.txtDomicilio.TabIndex = 7;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(283, 61);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefono.Mask = "000-000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(122, 26);
            this.txtTelefono.TabIndex = 6;
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Enabled = false;
            this.txtIDCliente.Location = new System.Drawing.Point(95, 64);
            this.txtIDCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIDCliente.Mask = "99999";
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(101, 26);
            this.txtIDCliente.TabIndex = 5;
            this.txtIDCliente.ValidatingType = typeof(int);
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(76, 30);
            this.cboCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(118, 26);
            this.cboCliente.TabIndex = 4;
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Domicilio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // cmdCliente
            // 
            this.cmdCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.cmdCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCliente.Image = ((System.Drawing.Image)(resources.GetObject("cmdCliente.Image")));
            this.cmdCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCliente.Location = new System.Drawing.Point(157, 75);
            this.cmdCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdCliente.Name = "cmdCliente";
            this.cmdCliente.Size = new System.Drawing.Size(131, 37);
            this.cmdCliente.TabIndex = 78;
            this.cmdCliente.Text = "Cliente";
            this.cmdCliente.UseVisualStyleBackColor = false;
            this.cmdCliente.Click += new System.EventHandler(this.cmdCliente_Click);
            // 
            // cmdProducto
            // 
            this.cmdProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.cmdProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProducto.Image = ((System.Drawing.Image)(resources.GetObject("cmdProducto.Image")));
            this.cmdProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdProducto.Location = new System.Drawing.Point(21, 75);
            this.cmdProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdProducto.Name = "cmdProducto";
            this.cmdProducto.Size = new System.Drawing.Size(131, 37);
            this.cmdProducto.TabIndex = 77;
            this.cmdProducto.Text = "General";
            this.cmdProducto.UseVisualStyleBackColor = false;
            this.cmdProducto.Click += new System.EventHandler(this.cmdProducto_Click);
            // 
            // cmdPeriodo
            // 
            this.cmdPeriodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.cmdPeriodo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPeriodo.Image = ((System.Drawing.Image)(resources.GetObject("cmdPeriodo.Image")));
            this.cmdPeriodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdPeriodo.Location = new System.Drawing.Point(292, 75);
            this.cmdPeriodo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdPeriodo.Name = "cmdPeriodo";
            this.cmdPeriodo.Size = new System.Drawing.Size(131, 37);
            this.cmdPeriodo.TabIndex = 76;
            this.cmdPeriodo.Text = "Periodo";
            this.cmdPeriodo.UseVisualStyleBackColor = false;
            this.cmdPeriodo.Click += new System.EventHandler(this.cmdPeriodo_Click);
            // 
            // ConsultarCobros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(908, 479);
            this.Controls.Add(this.gBoxFechas);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.cmdCliente);
            this.Controls.Add(this.cmdProducto);
            this.Controls.Add(this.cmdPeriodo);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.dgvPeriodo);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.dgvGeneral);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConsultarCobros";
            this.Text = "ConsultarCobros";
            this.Load += new System.EventHandler(this.ConsultarCobros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneral)).EndInit();
            this.gBoxFechas.ResumeLayout(false);
            this.gBoxFechas.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCobro1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVenta1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe1;
        private System.Windows.Forms.DataGridView dgvGeneral;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCobro;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.GroupBox gBoxFechas;
        private System.Windows.Forms.Button cmdBuscar2;
        private System.Windows.Forms.DateTimePicker dataTimeLimite;
        private System.Windows.Forms.DateTimePicker dataTimeInicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Button cmdBuscarCliente;
        private System.Windows.Forms.MaskedTextBox txtDomicilio;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.MaskedTextBox txtIDCliente;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdCliente;
        private System.Windows.Forms.Button cmdProducto;
        private System.Windows.Forms.Button cmdPeriodo;
    }
}