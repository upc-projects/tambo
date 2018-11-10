namespace CapaPresentacion
{
    partial class FormListarMarca
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
            this.dataGridViewMarca = new System.Windows.Forms.DataGridView();
            this.buttonAgregarMarca = new System.Windows.Forms.Button();
            this.buttonEditarMarca = new System.Windows.Forms.Button();
            this.buttonEliminarMarca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMarca
            // 
            this.dataGridViewMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMarca.Location = new System.Drawing.Point(12, 13);
            this.dataGridViewMarca.Name = "dataGridViewMarca";
            this.dataGridViewMarca.Size = new System.Drawing.Size(599, 328);
            this.dataGridViewMarca.TabIndex = 0;
            this.dataGridViewMarca.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMarca_CellClick);
            // 
            // buttonAgregarMarca
            // 
            this.buttonAgregarMarca.Location = new System.Drawing.Point(13, 348);
            this.buttonAgregarMarca.Name = "buttonAgregarMarca";
            this.buttonAgregarMarca.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregarMarca.TabIndex = 1;
            this.buttonAgregarMarca.Text = "Agregar";
            this.buttonAgregarMarca.UseVisualStyleBackColor = true;
            this.buttonAgregarMarca.Click += new System.EventHandler(this.buttonAgregarMarca_Click);
            // 
            // buttonEditarMarca
            // 
            this.buttonEditarMarca.Location = new System.Drawing.Point(94, 348);
            this.buttonEditarMarca.Name = "buttonEditarMarca";
            this.buttonEditarMarca.Size = new System.Drawing.Size(75, 23);
            this.buttonEditarMarca.TabIndex = 2;
            this.buttonEditarMarca.Text = "Editar";
            this.buttonEditarMarca.UseVisualStyleBackColor = true;
            this.buttonEditarMarca.Click += new System.EventHandler(this.buttonEditarMarca_Click);
            // 
            // buttonEliminarMarca
            // 
            this.buttonEliminarMarca.Location = new System.Drawing.Point(175, 348);
            this.buttonEliminarMarca.Name = "buttonEliminarMarca";
            this.buttonEliminarMarca.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminarMarca.TabIndex = 3;
            this.buttonEliminarMarca.Text = "Eliminar";
            this.buttonEliminarMarca.UseVisualStyleBackColor = true;
            this.buttonEliminarMarca.Click += new System.EventHandler(this.buttonEliminarMarca_Click);
            // 
            // FormListarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 400);
            this.Controls.Add(this.buttonEliminarMarca);
            this.Controls.Add(this.buttonEditarMarca);
            this.Controls.Add(this.buttonAgregarMarca);
            this.Controls.Add(this.dataGridViewMarca);
            this.Name = "FormListarMarca";
            this.Text = "FormListarMarca";
            this.Load += new System.EventHandler(this.FormListarMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMarca;
        private System.Windows.Forms.Button buttonAgregarMarca;
        private System.Windows.Forms.Button buttonEditarMarca;
        private System.Windows.Forms.Button buttonEliminarMarca;
    }
}