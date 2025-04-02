namespace Sistema_Carniceria
{
    partial class Respaldar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Respaldar));
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdCrearRespaldo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdCarpeta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdSalir
            // 
            this.cmdSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.cmdSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Image = ((System.Drawing.Image)(resources.GetObject("cmdSalir.Image")));
            this.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSalir.Location = new System.Drawing.Point(642, 388);
            this.cmdSalir.Margin = new System.Windows.Forms.Padding(2);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(131, 37);
            this.cmdSalir.TabIndex = 74;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdCrearRespaldo
            // 
            this.cmdCrearRespaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.cmdCrearRespaldo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCrearRespaldo.Image = ((System.Drawing.Image)(resources.GetObject("cmdCrearRespaldo.Image")));
            this.cmdCrearRespaldo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCrearRespaldo.Location = new System.Drawing.Point(220, 141);
            this.cmdCrearRespaldo.Margin = new System.Windows.Forms.Padding(2);
            this.cmdCrearRespaldo.Name = "cmdCrearRespaldo";
            this.cmdCrearRespaldo.Size = new System.Drawing.Size(278, 47);
            this.cmdCrearRespaldo.TabIndex = 75;
            this.cmdCrearRespaldo.Text = "Crear Respaldo";
            this.cmdCrearRespaldo.UseVisualStyleBackColor = false;
            this.cmdCrearRespaldo.Click += new System.EventHandler(this.cmdCrearRespaldo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 42);
            this.label1.TabIndex = 76;
            this.label1.Text = "RESPALDAR SISTEMA";
            // 
            // cmdCarpeta
            // 
            this.cmdCarpeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.cmdCarpeta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCarpeta.Image = ((System.Drawing.Image)(resources.GetObject("cmdCarpeta.Image")));
            this.cmdCarpeta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCarpeta.Location = new System.Drawing.Point(220, 217);
            this.cmdCarpeta.Margin = new System.Windows.Forms.Padding(2);
            this.cmdCarpeta.Name = "cmdCarpeta";
            this.cmdCarpeta.Size = new System.Drawing.Size(278, 47);
            this.cmdCarpeta.TabIndex = 77;
            this.cmdCarpeta.Text = "Abrir Carpeta Respaldos";
            this.cmdCarpeta.UseVisualStyleBackColor = false;
            this.cmdCarpeta.Click += new System.EventHandler(this.cmdCarpeta_Click);
            // 
            // Respaldar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdCarpeta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdCrearRespaldo);
            this.Controls.Add(this.cmdSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Respaldar";
            this.Text = "Respaldar";
            this.Load += new System.EventHandler(this.Respaldar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdCrearRespaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdCarpeta;
    }
}