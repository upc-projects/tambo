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
            this.DGTiendas.Location = new System.Drawing.Point(13, 13);
            this.DGTiendas.Name = "DGTiendas";
            this.DGTiendas.RowTemplate.Height = 24;
            this.DGTiendas.Size = new System.Drawing.Size(775, 425);
            this.DGTiendas.TabIndex = 0;
            // 
            // FormListarTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGTiendas);
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