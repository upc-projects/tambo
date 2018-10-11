namespace CapaPresentacion
{
    partial class FormListarProducto
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
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.buttonProductoEditar = new System.Windows.Forms.Button();
            this.buttonProductoEliminar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.Size = new System.Drawing.Size(682, 339);
            this.dataGridViewProductos.TabIndex = 0;
            this.dataGridViewProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductos_CellClick);
            // 
            // buttonProductoEditar
            // 
            this.buttonProductoEditar.Location = new System.Drawing.Point(93, 362);
            this.buttonProductoEditar.Name = "buttonProductoEditar";
            this.buttonProductoEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonProductoEditar.TabIndex = 1;
            this.buttonProductoEditar.Text = "Editar";
            this.buttonProductoEditar.UseVisualStyleBackColor = true;
            // 
            // buttonProductoEliminar
            // 
            this.buttonProductoEliminar.Location = new System.Drawing.Point(174, 362);
            this.buttonProductoEliminar.Name = "buttonProductoEliminar";
            this.buttonProductoEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonProductoEliminar.TabIndex = 2;
            this.buttonProductoEliminar.Text = "Eliminar";
            this.buttonProductoEliminar.UseVisualStyleBackColor = true;
            this.buttonProductoEliminar.Click += new System.EventHandler(this.buttonProductoEliminar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(12, 362);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 3;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            // 
            // FormListarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 397);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.buttonProductoEliminar);
            this.Controls.Add(this.buttonProductoEditar);
            this.Controls.Add(this.dataGridViewProductos);
            this.Name = "FormListarProducto";
            this.Text = "FormListarProducto";
            this.Load += new System.EventHandler(this.FormListarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.Button buttonProductoEditar;
        private System.Windows.Forms.Button buttonProductoEliminar;
        private System.Windows.Forms.Button buttonAgregar;
    }
}