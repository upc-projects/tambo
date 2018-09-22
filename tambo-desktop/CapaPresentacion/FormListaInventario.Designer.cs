namespace Principal
{
    partial class FormListaInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaInventario));
            this.dataGridViewTiendas = new System.Windows.Forms.DataGridView();
            this.toolStripInventario = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewInventarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTiendas)).BeginInit();
            this.toolStripInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTiendas
            // 
            this.dataGridViewTiendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTiendas.Location = new System.Drawing.Point(12, 28);
            this.dataGridViewTiendas.Name = "dataGridViewTiendas";
            this.dataGridViewTiendas.Size = new System.Drawing.Size(395, 329);
            this.dataGridViewTiendas.TabIndex = 5;
            // 
            // toolStripInventario
            // 
            this.toolStripInventario.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripInventario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton2});
            this.toolStripInventario.Location = new System.Drawing.Point(0, 0);
            this.toolStripInventario.Name = "toolStripInventario";
            this.toolStripInventario.Size = new System.Drawing.Size(777, 27);
            this.toolStripInventario.TabIndex = 4;
            this.toolStripInventario.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButtonNuevo";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Text = "toolStripButtonEditar";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton4.Text = "toolStripButtonBuscar";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // dataGridViewInventarios
            // 
            this.dataGridViewInventarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventarios.Location = new System.Drawing.Point(428, 28);
            this.dataGridViewInventarios.Name = "dataGridViewInventarios";
            this.dataGridViewInventarios.Size = new System.Drawing.Size(337, 329);
            this.dataGridViewInventarios.TabIndex = 6;
            // 
            // FormListaInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 369);
            this.Controls.Add(this.dataGridViewInventarios);
            this.Controls.Add(this.dataGridViewTiendas);
            this.Controls.Add(this.toolStripInventario);
            this.Name = "FormListaInventario";
            this.Text = "FormListaInventario";
            this.Load += new System.EventHandler(this.FormListaInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTiendas)).EndInit();
            this.toolStripInventario.ResumeLayout(false);
            this.toolStripInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTiendas;
        private System.Windows.Forms.ToolStrip toolStripInventario;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridView dataGridViewInventarios;
    }
}