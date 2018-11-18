namespace Entities_Layer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
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
                "dbo.Inventario",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        id_tienda = c.Int(nullable: false),
                        id_producto = c.Int(nullable: false),
                        stock = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Tiendas", t => t.id_tienda)
                .ForeignKey("dbo.Productos", t => t.id_producto)
                .Index(t => t.id_tienda)
                .Index(t => t.id_producto);
            
            CreateTable(
                "dbo.Tiendas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        telefono = c.String(nullable: false, maxLength: 50, unicode: false),
                        direccion = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        descripcion = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Productos", "id_categoria", "dbo.Categorias");
            DropForeignKey("dbo.Productos", "id_marca", "dbo.Marcas");
            DropForeignKey("dbo.Inventario", "id_producto", "dbo.Productos");
            DropForeignKey("dbo.Inventario", "id_tienda", "dbo.Tiendas");
            DropIndex("dbo.Inventario", new[] { "id_producto" });
            DropIndex("dbo.Inventario", new[] { "id_tienda" });
            DropIndex("dbo.Productos", new[] { "id_categoria" });
            DropIndex("dbo.Productos", new[] { "id_marca" });
            DropTable("dbo.Marcas");
            DropTable("dbo.Tiendas");
            DropTable("dbo.Inventario");
            DropTable("dbo.Productos");
            DropTable("dbo.Categorias");
        }
    }
}
