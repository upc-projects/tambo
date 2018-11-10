namespace CapaPresentacion
{
    partial class FormEditarCategoria
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
            this.buttonActualizarCategoria = new System.Windows.Forms.Button();
            this.textBoxNombreCategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonActualizarCategoria
            // 
            this.buttonActualizarCategoria.Location = new System.Drawing.Point(125, 59);
            this.buttonActualizarCategoria.Name = "buttonActualizarCategoria";
            this.buttonActualizarCategoria.Size = new System.Drawing.Size(75, 23);
            this.buttonActualizarCategoria.TabIndex = 5;
            this.buttonActualizarCategoria.Text = "Actualizar";
            this.buttonActualizarCategoria.UseVisualStyleBackColor = true;
            // 
            // textBoxNombreCategoria
            // 
            this.textBoxNombreCategoria.Location = new System.Drawing.Point(102, 24);
            this.textBoxNombreCategoria.Name = "textBoxNombreCategoria";
            this.textBoxNombreCategoria.Size = new System.Drawing.Size(179, 20);
            this.textBoxNombreCategoria.TabIndex = 4;
            this.textBoxNombreCategoria.TextChanged += new System.EventHandler(this.textBoxNombreCategoria_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // FormEditarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 102);
            this.Controls.Add(this.buttonActualizarCategoria);
            this.Controls.Add(this.textBoxNombreCategoria);
            this.Controls.Add(this.label1);
            this.Name = "FormEditarCategoria";
            this.Text = "FormEliminarCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonActualizarCategoria;
        private System.Windows.Forms.TextBox textBoxNombreCategoria;
        private System.Windows.Forms.Label label1;
    }
}