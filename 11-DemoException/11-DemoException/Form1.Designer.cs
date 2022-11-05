namespace _11_DemoException
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
            this.btnPruebaException = new System.Windows.Forms.Button();
            this.btnConectarServidor = new System.Windows.Forms.Button();
            this.btnEvento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPruebaException
            // 
            this.btnPruebaException.Location = new System.Drawing.Point(229, 52);
            this.btnPruebaException.Name = "btnPruebaException";
            this.btnPruebaException.Size = new System.Drawing.Size(139, 23);
            this.btnPruebaException.TabIndex = 0;
            this.btnPruebaException.Text = "Prueba Exception";
            this.btnPruebaException.UseVisualStyleBackColor = true;
            this.btnPruebaException.Click += new System.EventHandler(this.btnPruebaException_Click);
            // 
            // btnConectarServidor
            // 
            this.btnConectarServidor.Location = new System.Drawing.Point(238, 91);
            this.btnConectarServidor.Name = "btnConectarServidor";
            this.btnConectarServidor.Size = new System.Drawing.Size(120, 23);
            this.btnConectarServidor.TabIndex = 1;
            this.btnConectarServidor.Text = "Conectar Servidor";
            this.btnConectarServidor.UseVisualStyleBackColor = true;
            this.btnConectarServidor.Click += new System.EventHandler(this.btnConectarServidor_Click);
            // 
            // btnEvento
            // 
            this.btnEvento.Location = new System.Drawing.Point(255, 171);
            this.btnEvento.Name = "btnEvento";
            this.btnEvento.Size = new System.Drawing.Size(75, 23);
            this.btnEvento.TabIndex = 2;
            this.btnEvento.Text = "Evento";
            this.btnEvento.UseVisualStyleBackColor = true;
            this.btnEvento.Click += new System.EventHandler(this.btnEvento_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 278);
            this.Controls.Add(this.btnEvento);
            this.Controls.Add(this.btnConectarServidor);
            this.Controls.Add(this.btnPruebaException);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPruebaException;
        private System.Windows.Forms.Button btnConectarServidor;
        private System.Windows.Forms.Button btnEvento;
    }
}

