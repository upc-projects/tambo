namespace Principal
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarTiendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeTiendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiendaToolStripMenuItem,
            this.inventarioToolStripMenuItem1,
            this.marcaToolStripMenuItem,
            this.productoToolStripMenuItem,
            this.categoriaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiendaToolStripMenuItem
            // 
            this.tiendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarTiendaToolStripMenuItem,
            this.listadoDeTiendasToolStripMenuItem});
            this.tiendaToolStripMenuItem.Name = "tiendaToolStripMenuItem";
            this.tiendaToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.tiendaToolStripMenuItem.Text = "Tienda";
            // 
            // agregarTiendaToolStripMenuItem
            // 
            this.agregarTiendaToolStripMenuItem.Name = "agregarTiendaToolStripMenuItem";
            this.agregarTiendaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.agregarTiendaToolStripMenuItem.Text = "Agregar Tienda";
            this.agregarTiendaToolStripMenuItem.Click += new System.EventHandler(this.agregarTiendaToolStripMenuItem_Click);
            // 
            // listadoDeTiendasToolStripMenuItem
            // 
            this.listadoDeTiendasToolStripMenuItem.Name = "listadoDeTiendasToolStripMenuItem";
            this.listadoDeTiendasToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.listadoDeTiendasToolStripMenuItem.Text = "Listado de Tiendas";
            this.listadoDeTiendasToolStripMenuItem.Click += new System.EventHandler(this.listadoDeTiendasToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem1
            // 
            this.inventarioToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarInventarioToolStripMenuItem,
            this.editarInventarioToolStripMenuItem});
            this.inventarioToolStripMenuItem1.Name = "inventarioToolStripMenuItem1";
            this.inventarioToolStripMenuItem1.Size = new System.Drawing.Size(87, 24);
            this.inventarioToolStripMenuItem1.Text = "Inventario";
            // 
            // listarInventarioToolStripMenuItem
            // 
            this.listarInventarioToolStripMenuItem.Name = "listarInventarioToolStripMenuItem";
            this.listarInventarioToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.listarInventarioToolStripMenuItem.Text = "Listar Inventario ";
            this.listarInventarioToolStripMenuItem.Click += new System.EventHandler(this.listarInventarioToolStripMenuItem_Click);
            // 
            // editarInventarioToolStripMenuItem
            // 
            this.editarInventarioToolStripMenuItem.Name = "editarInventarioToolStripMenuItem";
            this.editarInventarioToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.editarInventarioToolStripMenuItem.Text = "Listar Inventario por Tienda";
            this.editarInventarioToolStripMenuItem.Click += new System.EventHandler(this.editarInventarioToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarMarcaToolStripMenuItem,
            this.eliminarMarcaToolStripMenuItem,
            this.listarMarcasToolStripMenuItem});
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.marcaToolStripMenuItem.Text = "Marca";
            // 
            // agregarMarcaToolStripMenuItem
            // 
            this.agregarMarcaToolStripMenuItem.Name = "agregarMarcaToolStripMenuItem";
            this.agregarMarcaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.agregarMarcaToolStripMenuItem.Text = "Agregar Marca";
            this.agregarMarcaToolStripMenuItem.Click += new System.EventHandler(this.agregarMarcaToolStripMenuItem_Click);
            // 
            // listarMarcasToolStripMenuItem
            // 
            this.listarMarcasToolStripMenuItem.Name = "listarMarcasToolStripMenuItem";
            this.listarMarcasToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.listarMarcasToolStripMenuItem.Text = "Listar Marcas";
            this.listarMarcasToolStripMenuItem.Click += new System.EventHandler(this.listarMarcasToolStripMenuItem_Click);
            // 
            // eliminarMarcaToolStripMenuItem
            // 
            this.eliminarMarcaToolStripMenuItem.Name = "eliminarMarcaToolStripMenuItem";
            this.eliminarMarcaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.eliminarMarcaToolStripMenuItem.Text = "Eliminar Marca";
            this.eliminarMarcaToolStripMenuItem.Click += new System.EventHandler(this.eliminarMarcaToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProductoToolStripMenuItem,
            this.eliminarProductoToolStripMenuItem,
            this.listarProductosToolStripMenuItem});
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.productoToolStripMenuItem.Text = "Producto";
            // 
            // agregarProductoToolStripMenuItem
            // 
            this.agregarProductoToolStripMenuItem.Name = "agregarProductoToolStripMenuItem";
            this.agregarProductoToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.agregarProductoToolStripMenuItem.Text = "Agregar Producto";
            this.agregarProductoToolStripMenuItem.Click += new System.EventHandler(this.agregarProductoToolStripMenuItem_Click);
            // 
            // eliminarProductoToolStripMenuItem
            // 
            this.eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            this.eliminarProductoToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.eliminarProductoToolStripMenuItem.Text = "Eliminar Producto";
            this.eliminarProductoToolStripMenuItem.Click += new System.EventHandler(this.eliminarProductoToolStripMenuItem_Click);
            // 
            // listarProductosToolStripMenuItem
            // 
            this.listarProductosToolStripMenuItem.Name = "listarProductosToolStripMenuItem";
            this.listarProductosToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.listarProductosToolStripMenuItem.Text = "Listar Productos";
            this.listarProductosToolStripMenuItem.Click += new System.EventHandler(this.listarProductosToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCategoriaToolStripMenuItem,
            this.eliminarCategoriaToolStripMenuItem,
            this.listarCategoriasToolStripMenuItem});
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            // 
            // agregarCategoriaToolStripMenuItem
            // 
            this.agregarCategoriaToolStripMenuItem.Name = "agregarCategoriaToolStripMenuItem";
            this.agregarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.agregarCategoriaToolStripMenuItem.Text = "Agregar Categoria";
            this.agregarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.agregarCategoriaToolStripMenuItem_Click);
            // 
            // eliminarCategoriaToolStripMenuItem
            // 
            this.eliminarCategoriaToolStripMenuItem.Name = "eliminarCategoriaToolStripMenuItem";
            this.eliminarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.eliminarCategoriaToolStripMenuItem.Text = "Eliminar Categoria";
            this.eliminarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.eliminarCategoriaToolStripMenuItem_Click);
            // 
            // listarCategoriasToolStripMenuItem
            // 
            this.listarCategoriasToolStripMenuItem.Name = "listarCategoriasToolStripMenuItem";
            this.listarCategoriasToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.listarCategoriasToolStripMenuItem.Text = "Listar Categorias";
            this.listarCategoriasToolStripMenuItem.Click += new System.EventHandler(this.listarCategoriasToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrincipal";
            this.Text = "Tambo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarTiendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeTiendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listarInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarMarcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarCategoriasToolStripMenuItem;
    }
}

