namespace CapaPresentacion
{
    partial class FormEditarInventario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBTienda = new System.Windows.Forms.ComboBox();
            this.CBProducto = new System.Windows.Forms.ComboBox();
            this.NUDCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAgregat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tienda: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad:";
            // 
            // CBTienda
            // 
            this.CBTienda.FormattingEnabled = true;
            this.CBTienda.Location = new System.Drawing.Point(111, 32);
            this.CBTienda.Name = "CBTienda";
            this.CBTienda.Size = new System.Drawing.Size(300, 24);
            this.CBTienda.TabIndex = 3;
            // 
            // CBProducto
            // 
            this.CBProducto.FormattingEnabled = true;
            this.CBProducto.Location = new System.Drawing.Point(111, 83);
            this.CBProducto.Name = "CBProducto";
            this.CBProducto.Size = new System.Drawing.Size(300, 24);
            this.CBProducto.TabIndex = 4;
            // 
            // NUDCantidad
            // 
            this.NUDCantidad.Location = new System.Drawing.Point(111, 141);
            this.NUDCantidad.Name = "NUDCantidad";
            this.NUDCantidad.Size = new System.Drawing.Size(120, 22);
            this.NUDCantidad.TabIndex = 5;
            // 
            // btnAgregat
            // 
            this.btnAgregat.Location = new System.Drawing.Point(139, 198);
            this.btnAgregat.Name = "btnAgregat";
            this.btnAgregat.Size = new System.Drawing.Size(170, 32);
            this.btnAgregat.TabIndex = 6;
            this.btnAgregat.Text = "Agregar elementos";
            this.btnAgregat.UseVisualStyleBackColor = true;
            this.btnAgregat.Click += new System.EventHandler(this.btnAgregat_Click);
            // 
            // FormEditarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 251);
            this.Controls.Add(this.btnAgregat);
            this.Controls.Add(this.NUDCantidad);
            this.Controls.Add(this.CBProducto);
            this.Controls.Add(this.CBTienda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEditarInventario";
            this.Text = "Editar inventario";
            this.Load += new System.EventHandler(this.FormEditarInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBTienda;
        private System.Windows.Forms.ComboBox CBProducto;
        private System.Windows.Forms.NumericUpDown NUDCantidad;
        private System.Windows.Forms.Button btnAgregat;
    }
}