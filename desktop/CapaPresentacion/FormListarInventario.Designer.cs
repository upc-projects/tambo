namespace CapaPresentacion
{
    partial class FormListarInventario
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
            this.DGInventario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // DGInventario
            // 
            this.DGInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGInventario.Location = new System.Drawing.Point(13, 13);
            this.DGInventario.Name = "DGInventario";
            this.DGInventario.RowTemplate.Height = 24;
            this.DGInventario.Size = new System.Drawing.Size(775, 425);
            this.DGInventario.TabIndex = 1;
            // 
            // FormListarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGInventario);
            this.Name = "FormListarInventario";
            this.Text = "Listado de Inventarios";
            this.Load += new System.EventHandler(this.FormListarInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGInventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGInventario;
    }
}