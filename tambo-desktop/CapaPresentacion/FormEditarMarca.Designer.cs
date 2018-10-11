namespace CapaPresentacion
{
    partial class FormEditarMarca
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
            this.buttonActualizarMarca = new System.Windows.Forms.Button();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombreMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonActualizarMarca
            // 
            this.buttonActualizarMarca.Location = new System.Drawing.Point(227, 131);
            this.buttonActualizarMarca.Name = "buttonActualizarMarca";
            this.buttonActualizarMarca.Size = new System.Drawing.Size(75, 23);
            this.buttonActualizarMarca.TabIndex = 9;
            this.buttonActualizarMarca.Text = "Actualizar";
            this.buttonActualizarMarca.UseVisualStyleBackColor = true;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(134, 57);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(168, 57);
            this.textBoxDescripcion.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descipcion";
            // 
            // textBoxNombreMarca
            // 
            this.textBoxNombreMarca.Location = new System.Drawing.Point(134, 16);
            this.textBoxNombreMarca.Name = "textBoxNombreMarca";
            this.textBoxNombreMarca.Size = new System.Drawing.Size(168, 20);
            this.textBoxNombreMarca.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // FormEditarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 163);
            this.Controls.Add(this.buttonActualizarMarca);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNombreMarca);
            this.Controls.Add(this.label1);
            this.Name = "FormEditarMarca";
            this.Text = "FormEditarMarca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonActualizarMarca;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombreMarca;
        private System.Windows.Forms.Label label1;
    }
}