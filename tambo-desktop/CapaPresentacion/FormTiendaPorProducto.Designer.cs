namespace CapaPresentacion
{
    partial class FormTiendaPorProducto
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
            this.DGTienda = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.btnCargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGTienda)).BeginInit();
            this.SuspendLayout();
            // 
            // DGTienda
            // 
            this.DGTienda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGTienda.Location = new System.Drawing.Point(12, 57);
            this.DGTienda.Name = "DGTienda";
            this.DGTienda.RowTemplate.Height = 24;
            this.DGTienda.Size = new System.Drawing.Size(928, 497);
            this.DGTienda.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Producto";
            // 
            // cboProducto
            // 
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(131, 18);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(527, 24);
            this.cboProducto.TabIndex = 13;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(706, 15);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(185, 29);
            this.btnCargar.TabIndex = 12;
            this.btnCargar.Text = "Obtener tiendas";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // FormTiendaPorProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 569);
            this.Controls.Add(this.DGTienda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboProducto);
            this.Controls.Add(this.btnCargar);
            this.Name = "FormTiendaPorProducto";
            this.Text = "Tiendas según producto";
            this.Load += new System.EventHandler(this.FormTiendaPorProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGTienda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGTienda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Button btnCargar;
    }
}