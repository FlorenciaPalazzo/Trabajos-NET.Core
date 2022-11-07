namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAfinar = new System.Windows.Forms.Button();
            this.btnMover = new System.Windows.Forms.Button();
            this.btnPersona = new System.Windows.Forms.Button();
            this.btnAnimales = new System.Windows.Forms.Button();
            this.btnTransporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAfinar
            // 
            this.btnAfinar.Location = new System.Drawing.Point(178, 12);
            this.btnAfinar.Name = "btnAfinar";
            this.btnAfinar.Size = new System.Drawing.Size(75, 23);
            this.btnAfinar.TabIndex = 0;
            this.btnAfinar.Text = "Afinar";
            this.btnAfinar.UseVisualStyleBackColor = true;
            this.btnAfinar.Click += new System.EventHandler(this.btnAfinar_Click);
            // 
            // btnMover
            // 
            this.btnMover.Location = new System.Drawing.Point(178, 61);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(75, 23);
            this.btnMover.TabIndex = 1;
            this.btnMover.Text = "Mover";
            this.btnMover.UseVisualStyleBackColor = true;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // btnPersona
            // 
            this.btnPersona.Location = new System.Drawing.Point(178, 107);
            this.btnPersona.Name = "btnPersona";
            this.btnPersona.Size = new System.Drawing.Size(75, 23);
            this.btnPersona.TabIndex = 2;
            this.btnPersona.Text = "Personas";
            this.btnPersona.UseVisualStyleBackColor = true;
            this.btnPersona.Click += new System.EventHandler(this.btnPersona_Click);
            // 
            // btnAnimales
            // 
            this.btnAnimales.Location = new System.Drawing.Point(178, 151);
            this.btnAnimales.Name = "btnAnimales";
            this.btnAnimales.Size = new System.Drawing.Size(75, 23);
            this.btnAnimales.TabIndex = 3;
            this.btnAnimales.Text = "Animales";
            this.btnAnimales.UseVisualStyleBackColor = true;
            this.btnAnimales.Click += new System.EventHandler(this.btnAnimales_Click);
            // 
            // btnTransporte
            // 
            this.btnTransporte.Location = new System.Drawing.Point(178, 199);
            this.btnTransporte.Name = "btnTransporte";
            this.btnTransporte.Size = new System.Drawing.Size(75, 23);
            this.btnTransporte.TabIndex = 4;
            this.btnTransporte.Text = "Transporte";
            this.btnTransporte.UseVisualStyleBackColor = true;
            this.btnTransporte.Click += new System.EventHandler(this.btnTransporte_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 248);
            this.Controls.Add(this.btnTransporte);
            this.Controls.Add(this.btnAnimales);
            this.Controls.Add(this.btnPersona);
            this.Controls.Add(this.btnMover);
            this.Controls.Add(this.btnAfinar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAfinar;
        private System.Windows.Forms.Button btnMover;
        private System.Windows.Forms.Button btnPersona;
        private System.Windows.Forms.Button btnAnimales;
        private System.Windows.Forms.Button btnTransporte;
    }
}

