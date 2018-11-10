namespace CapaPresentacion
{
    partial class FormAgregarCategoria
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
            this.textBoxNombreCategoria = new System.Windows.Forms.TextBox();
            this.buttonGuardarCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // textBoxNombreCategoria
            // 
            this.textBoxNombreCategoria.Location = new System.Drawing.Point(98, 26);
            this.textBoxNombreCategoria.Name = "textBoxNombreCategoria";
            this.textBoxNombreCategoria.Size = new System.Drawing.Size(179, 20);
            this.textBoxNombreCategoria.TabIndex = 1;
            // 
            // buttonGuardarCategoria
            // 
            this.buttonGuardarCategoria.Location = new System.Drawing.Point(121, 61);
            this.buttonGuardarCategoria.Name = "buttonGuardarCategoria";
            this.buttonGuardarCategoria.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardarCategoria.TabIndex = 2;
            this.buttonGuardarCategoria.Text = "Guardar";
            this.buttonGuardarCategoria.UseVisualStyleBackColor = true;
            this.buttonGuardarCategoria.Click += new System.EventHandler(this.buttonGuardarCategoria_Click);
            // 
            // FormAgregarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 96);
            this.Controls.Add(this.buttonGuardarCategoria);
            this.Controls.Add(this.textBoxNombreCategoria);
            this.Controls.Add(this.label1);
            this.Name = "FormAgregarCategoria";
            this.Text = "FormAgregarCategoria";
            this.Load += new System.EventHandler(this.FormAgregarCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombreCategoria;
        private System.Windows.Forms.Button buttonGuardarCategoria;
    }
}