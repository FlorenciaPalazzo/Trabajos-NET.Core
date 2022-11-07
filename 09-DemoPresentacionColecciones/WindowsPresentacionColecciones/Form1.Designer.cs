namespace WindowsPresentacionColecciones
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.lstPrecioProducto = new System.Windows.Forms.ListBox();
            this.btnCrearCliente = new System.Windows.Forms.Button();
            this.btnComision = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(52, 12);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(136, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar Productos";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(274, 12);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(145, 23);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar Productos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // gridProductos
            // 
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Location = new System.Drawing.Point(12, 47);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.Size = new System.Drawing.Size(240, 150);
            this.gridProductos.TabIndex = 2;
            // 
            // lstPrecioProducto
            // 
            this.lstPrecioProducto.FormattingEnabled = true;
            this.lstPrecioProducto.Location = new System.Drawing.Point(274, 47);
            this.lstPrecioProducto.Name = "lstPrecioProducto";
            this.lstPrecioProducto.Size = new System.Drawing.Size(158, 147);
            this.lstPrecioProducto.TabIndex = 3;
            // 
            // btnCrearCliente
            // 
            this.btnCrearCliente.Location = new System.Drawing.Point(523, 12);
            this.btnCrearCliente.Name = "btnCrearCliente";
            this.btnCrearCliente.Size = new System.Drawing.Size(120, 23);
            this.btnCrearCliente.TabIndex = 4;
            this.btnCrearCliente.Text = "Crear Clientes";
            this.btnCrearCliente.UseVisualStyleBackColor = true;
            this.btnCrearCliente.Click += new System.EventHandler(this.btnCrearCliente_Click);
            // 
            // btnComision
            // 
            this.btnComision.Location = new System.Drawing.Point(497, 89);
            this.btnComision.Name = "btnComision";
            this.btnComision.Size = new System.Drawing.Size(171, 92);
            this.btnComision.TabIndex = 5;
            this.btnComision.Text = "Comision Clientes";
            this.btnComision.UseVisualStyleBackColor = true;
            this.btnComision.Click += new System.EventHandler(this.btnComision_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 204);
            this.Controls.Add(this.btnComision);
            this.Controls.Add(this.btnCrearCliente);
            this.Controls.Add(this.lstPrecioProducto);
            this.Controls.Add(this.gridProductos);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView gridProductos;
        private System.Windows.Forms.ListBox lstPrecioProducto;
        private System.Windows.Forms.Button btnCrearCliente;
        private System.Windows.Forms.Button btnComision;
    }
}

