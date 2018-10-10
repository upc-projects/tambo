namespace CapaPresentacion
{
    partial class ListarInventarioTienda
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
            this.btnCargar = new System.Windows.Forms.Button();
            this.cboTienda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGInventario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(707, 13);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(185, 29);
            this.btnCargar.TabIndex = 0;
            this.btnCargar.Text = "Obtener Inventario";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // cboTienda
            // 
            this.cboTienda.FormattingEnabled = true;
            this.cboTienda.Location = new System.Drawing.Point(132, 16);
            this.cboTienda.Name = "cboTienda";
            this.cboTienda.Size = new System.Drawing.Size(527, 24);
            this.cboTienda.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tienda: ";
            // 
            // DGInventario
            // 
            this.DGInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGInventario.Location = new System.Drawing.Point(13, 55);
            this.DGInventario.Name = "DGInventario";
            this.DGInventario.RowTemplate.Height = 24;
            this.DGInventario.Size = new System.Drawing.Size(928, 497);
            this.DGInventario.TabIndex = 3;
            // 
            // ListarInventarioTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 564);
            this.Controls.Add(this.DGInventario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTienda);
            this.Controls.Add(this.btnCargar);
            this.Name = "ListarInventarioTienda";
            this.Text = "ListarInventarioTienda";
            this.Load += new System.EventHandler(this.ListarInventarioTienda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ComboBox cboTienda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGInventario;
    }
}