namespace WindowsCompaniaAerea
{
    partial class Form1
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
            this.btnJet = new System.Windows.Forms.Button();
            this.gridListaJets = new System.Windows.Forms.DataGridView();
            this.btnHelicoptero = new System.Windows.Forms.Button();
            this.btnQuitarAzafata = new System.Windows.Forms.Button();
            this.btnAgregarAzafata = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.gridAzafatas = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCrearAzafata = new System.Windows.Forms.Button();
            this.btnMantenimiento = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridListaJets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAzafatas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJet
            // 
            this.btnJet.Location = new System.Drawing.Point(41, 12);
            this.btnJet.Name = "btnJet";
            this.btnJet.Size = new System.Drawing.Size(98, 23);
            this.btnJet.TabIndex = 1;
            this.btnJet.Text = "Jet";
            this.btnJet.UseVisualStyleBackColor = true;
            this.btnJet.Click += new System.EventHandler(this.btnJet_Click);
            // 
            // gridListaJets
            // 
            this.gridListaJets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListaJets.Location = new System.Drawing.Point(12, 101);
            this.gridListaJets.Name = "gridListaJets";
            this.gridListaJets.Size = new System.Drawing.Size(325, 150);
            this.gridListaJets.TabIndex = 2;
            // 
            // btnHelicoptero
            // 
            this.btnHelicoptero.Location = new System.Drawing.Point(203, 12);
            this.btnHelicoptero.Name = "btnHelicoptero";
            this.btnHelicoptero.Size = new System.Drawing.Size(118, 23);
            this.btnHelicoptero.TabIndex = 3;
            this.btnHelicoptero.Text = "Helicoptero";
            this.btnHelicoptero.UseVisualStyleBackColor = true;
            this.btnHelicoptero.Click += new System.EventHandler(this.btnHelicoptero_Click);
            // 
            // btnQuitarAzafata
            // 
            this.btnQuitarAzafata.Location = new System.Drawing.Point(501, 12);
            this.btnQuitarAzafata.Name = "btnQuitarAzafata";
            this.btnQuitarAzafata.Size = new System.Drawing.Size(121, 23);
            this.btnQuitarAzafata.TabIndex = 4;
            this.btnQuitarAzafata.Text = "Quitar Azafata";
            this.btnQuitarAzafata.UseVisualStyleBackColor = true;
            this.btnQuitarAzafata.Click += new System.EventHandler(this.btnQuitarAzafata_Click);
            // 
            // btnAgregarAzafata
            // 
            this.btnAgregarAzafata.Location = new System.Drawing.Point(374, 12);
            this.btnAgregarAzafata.Name = "btnAgregarAzafata";
            this.btnAgregarAzafata.Size = new System.Drawing.Size(121, 23);
            this.btnAgregarAzafata.TabIndex = 5;
            this.btnAgregarAzafata.Text = "Agregar Azafata";
            this.btnAgregarAzafata.UseVisualStyleBackColor = true;
            this.btnAgregarAzafata.Click += new System.EventHandler(this.btnAgregarAzafata_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(434, 59);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(121, 23);
            this.btnMostrar.TabIndex = 6;
            this.btnMostrar.Text = "Mostrar Azafata";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // gridAzafatas
            // 
            this.gridAzafatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAzafatas.Location = new System.Drawing.Point(374, 101);
            this.gridAzafatas.Name = "gridAzafatas";
            this.gridAzafatas.Size = new System.Drawing.Size(240, 150);
            this.gridAzafatas.TabIndex = 7;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(463, 257);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCrearAzafata
            // 
            this.btnCrearAzafata.Location = new System.Drawing.Point(678, 12);
            this.btnCrearAzafata.Name = "btnCrearAzafata";
            this.btnCrearAzafata.Size = new System.Drawing.Size(140, 23);
            this.btnCrearAzafata.TabIndex = 9;
            this.btnCrearAzafata.Text = "Crear Azafata";
            this.btnCrearAzafata.UseVisualStyleBackColor = true;
            this.btnCrearAzafata.Click += new System.EventHandler(this.btnCrearAzafata_Click);
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.Location = new System.Drawing.Point(678, 101);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(140, 23);
            this.btnMantenimiento.TabIndex = 10;
            this.btnMantenimiento.Text = "Mantenimiento";
            this.btnMantenimiento.UseVisualStyleBackColor = true;
            this.btnMantenimiento.Click += new System.EventHandler(this.btnMantenimiento_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(678, 59);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(140, 23);
            this.btnQuitar.TabIndex = 11;
            this.btnQuitar.Text = "Quitar Azafata";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 292);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnMantenimiento);
            this.Controls.Add(this.btnCrearAzafata);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gridAzafatas);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnAgregarAzafata);
            this.Controls.Add(this.btnQuitarAzafata);
            this.Controls.Add(this.btnHelicoptero);
            this.Controls.Add(this.gridListaJets);
            this.Controls.Add(this.btnJet);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridListaJets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAzafatas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnJet;
        private System.Windows.Forms.DataGridView gridListaJets;
        private System.Windows.Forms.Button btnHelicoptero;
        private System.Windows.Forms.Button btnQuitarAzafata;
        private System.Windows.Forms.Button btnAgregarAzafata;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView gridAzafatas;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCrearAzafata;
        private System.Windows.Forms.Button btnMantenimiento;
        private System.Windows.Forms.Button btnQuitar;
    }
}