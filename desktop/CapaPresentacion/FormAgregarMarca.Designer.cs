namespace CapaPresentacion
{
    partial class FormAgregarMarca
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
            this.textBoxNombreMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.buttonGuardarMarca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // textBoxNombreMarca
            // 
            this.textBoxNombreMarca.Location = new System.Drawing.Point(115, 20);
            this.textBoxNombreMarca.Name = "textBoxNombreMarca";
            this.textBoxNombreMarca.Size = new System.Drawing.Size(168, 20);
            this.textBoxNombreMarca.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descipcion";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(115, 61);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(168, 57);
            this.textBoxDescripcion.TabIndex = 3;
            // 
            // buttonGuardarMarca
            // 
            this.buttonGuardarMarca.Location = new System.Drawing.Point(208, 135);
            this.buttonGuardarMarca.Name = "buttonGuardarMarca";
            this.buttonGuardarMarca.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardarMarca.TabIndex = 4;
            this.buttonGuardarMarca.Text = "Guardar";
            this.buttonGuardarMarca.UseVisualStyleBackColor = true;
            this.buttonGuardarMarca.Click += new System.EventHandler(this.buttonGuardarMarca_Click);
            // 
            // FormAgregarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 176);
            this.Controls.Add(this.buttonGuardarMarca);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNombreMarca);
            this.Controls.Add(this.label1);
            this.Name = "FormAgregarMarca";
            this.Text = "FormAgregarMarca";
            this.Load += new System.EventHandler(this.FormAgregarMarca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombreMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Button buttonGuardarMarca;
    }
}