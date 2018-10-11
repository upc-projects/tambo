namespace CapaPresentacion
{
    partial class FormListarCategoria
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
            this.DGCategoria = new System.Windows.Forms.DataGridView();
            this.buttonCategoriaAgregar = new System.Windows.Forms.Button();
            this.buttonCategoriaEditar = new System.Windows.Forms.Button();
            this.buttonCategoriaEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // DGCategoria
            // 
            this.DGCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCategoria.Location = new System.Drawing.Point(12, 12);
            this.DGCategoria.Name = "DGCategoria";
            this.DGCategoria.Size = new System.Drawing.Size(531, 288);
            this.DGCategoria.TabIndex = 0;
            this.DGCategoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGCategoria_CellClick);
            this.DGCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGCategoria_CellContentClick);
            // 
            // buttonCategoriaAgregar
            // 
            this.buttonCategoriaAgregar.Location = new System.Drawing.Point(12, 308);
            this.buttonCategoriaAgregar.Name = "buttonCategoriaAgregar";
            this.buttonCategoriaAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonCategoriaAgregar.TabIndex = 1;
            this.buttonCategoriaAgregar.Text = "Agregar";
            this.buttonCategoriaAgregar.UseVisualStyleBackColor = true;
            this.buttonCategoriaAgregar.Click += new System.EventHandler(this.buttonCategoriaAgregar_Click);
            // 
            // buttonCategoriaEditar
            // 
            this.buttonCategoriaEditar.Location = new System.Drawing.Point(93, 310);
            this.buttonCategoriaEditar.Name = "buttonCategoriaEditar";
            this.buttonCategoriaEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonCategoriaEditar.TabIndex = 2;
            this.buttonCategoriaEditar.Text = "Editar";
            this.buttonCategoriaEditar.UseVisualStyleBackColor = true;
            this.buttonCategoriaEditar.Click += new System.EventHandler(this.buttonCategoriaEditar_Click);
            // 
            // buttonCategoriaEliminar
            // 
            this.buttonCategoriaEliminar.Location = new System.Drawing.Point(174, 310);
            this.buttonCategoriaEliminar.Name = "buttonCategoriaEliminar";
            this.buttonCategoriaEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonCategoriaEliminar.TabIndex = 3;
            this.buttonCategoriaEliminar.Text = "Eliminar";
            this.buttonCategoriaEliminar.UseVisualStyleBackColor = true;
            this.buttonCategoriaEliminar.Click += new System.EventHandler(this.buttonCategoriaEliminar_Click);
            // 
            // FormListarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 343);
            this.Controls.Add(this.buttonCategoriaEliminar);
            this.Controls.Add(this.buttonCategoriaEditar);
            this.Controls.Add(this.buttonCategoriaAgregar);
            this.Controls.Add(this.DGCategoria);
            this.Name = "FormListarCategoria";
            this.Text = "FormListarCategoria";
            this.Load += new System.EventHandler(this.FormListarCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGCategoria;
        private System.Windows.Forms.Button buttonCategoriaAgregar;
        private System.Windows.Forms.Button buttonCategoriaEditar;
        private System.Windows.Forms.Button buttonCategoriaEliminar;
    }
}