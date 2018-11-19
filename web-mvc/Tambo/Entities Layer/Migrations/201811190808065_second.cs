namespace Entities_Layer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {

            AddColumn(
                "dbo.Tiendas", "url", c => c.String()
            );
            AddColumn(
                "dbo.Productos", "url", c => c.String()
            );
        }

        public override void Down()
        {
            DropColumn(
                "dbo.Tiendas", "url"
            );
            DropColumn(
                "dbo.Productos", "url"
            );
        }
    }
}
