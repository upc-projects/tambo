namespace CapaPresentacion
{
    partial class FormListarTienda
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
            this.DGTiendas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGTiendas)).BeginInit();
            this.SuspendLayout();
            // 
            // DGTiendas
            // 
            this.DGTiendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGTiendas.Location = new System.Drawing.Point(10, 11);
            this.DGTiendas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGTiendas.Name = "DGTiendas";
            this.DGTiendas.RowTemplate.Height = 24;
            this.DGTiendas.Size = new System.Drawing.Size(581, 345);
            this.DGTiendas.TabIndex = 0;
            this.DGTiendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGTiendas_CellContentClick);
            // 
            // FormListarTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.DGTiendas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormListarTienda";
            this.Text = "Listado de Tiendas";
            this.Load += new System.EventHandler(this.FormListarTienda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGTiendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGTiendas;
    }
}