namespace Sistema_Carniceria
{
    partial class Restaurar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Restaurar));
            this.label1 = new System.Windows.Forms.Label();
            this.cmdRestaurar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 42);
            this.label1.TabIndex = 79;
            this.label1.Text = "RESTAURAR BASE DE DATOS";
            // 
            // cmdRestaurar
            // 
            this.cmdRestaurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.cmdRestaurar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("cmdRestaurar.Image")));
            this.cmdRestaurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdRestaurar.Location = new System.Drawing.Point(232, 147);
            this.cmdRestaurar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdRestaurar.Name = "cmdRestaurar";
            this.cmdRestaurar.Size = new System.Drawing.Size(278, 47);
            this.cmdRestaurar.TabIndex = 78;
            this.cmdRestaurar.Text = "Restaurar BD";
            this.cmdRestaurar.UseVisualStyleBackColor = false;
            this.cmdRestaurar.Click += new System.EventHandler(this.cmdRestaurar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.cmdSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Image = ((System.Drawing.Image)(resources.GetObject("cmdSalir.Image")));
            this.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSalir.Location = new System.Drawing.Point(640, 388);
            this.cmdSalir.Margin = new System.Windows.Forms.Padding(2);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(131, 37);
            this.cmdSalir.TabIndex = 77;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // Restaurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdRestaurar);
            this.Controls.Add(this.cmdSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Restaurar";
            this.Text = "Restaurar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdRestaurar;
        private System.Windows.Forms.Button cmdSalir;
    }
}