namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Productos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        id_marca = c.Int(nullable: false),
                        nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        descripcion = c.String(nullable: false, maxLength: 50, unicode: false),
                        precio = c.Double(nullable: false),
                        fecha_vencimiento = c.DateTime(nullable: false, storeType: "date"),
                        codigo = c.String(nullable: false, maxLength: 50, unicode: false),
                        id_categoria = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Marcas", t => t.id_marca)
                .ForeignKey("dbo.Categorias", t => t.id_categoria)
                .Index(t => t.id_marca)
                .Index(t => t.id_categoria);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        descripcion = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Producto_Inventario",
                c => new
                    {
                        id_inventario = c.Int(nullable: false),
                        id_producto = c.Int(nullable: false),
                        stock = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.id_inventario, t.id_producto, t.stock })
                .ForeignKey("dbo.Inventarios", t => t.id_inventario)
                .ForeignKey("dbo.Productos", t => t.id_producto)
                .Index(t => t.id_inventario)
                .Index(t => t.id_producto);
            
            CreateTable(
                "dbo.Inventarios",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        descripcion = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Tiendas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        telefono = c.String(nullable: false, maxLength: 50, unicode: false),
                        direccion = c.String(nullable: false, maxLength: 50, unicode: false),
                        id_inventario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Inventarios", t => t.id_inventario)
                .Index(t => t.id_inventario);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Productos", "id_categoria", "dbo.Categorias");
            DropForeignKey("dbo.Producto_Inventario", "id_producto", "dbo.Productos");
            DropForeignKey("dbo.Tiendas", "id_inventario", "dbo.Inventarios");
            DropForeignKey("dbo.Producto_Inventario", "id_inventario", "dbo.Inventarios");
            DropForeignKey("dbo.Productos", "id_marca", "dbo.Marcas");
            DropIndex("dbo.Tiendas", new[] { "id_inventario" });
            DropIndex("dbo.Producto_Inventario", new[] { "id_producto" });
            DropIndex("dbo.Producto_Inventario", new[] { "id_inventario" });
            DropIndex("dbo.Productos", new[] { "id_categoria" });
            DropIndex("dbo.Productos", new[] { "id_marca" });
            DropTable("dbo.Tiendas");
            DropTable("dbo.Inventarios");
            DropTable("dbo.Producto_Inventario");
            DropTable("dbo.Marcas");
            DropTable("dbo.Productos");
            DropTable("dbo.Categorias");
        }
    }
}
