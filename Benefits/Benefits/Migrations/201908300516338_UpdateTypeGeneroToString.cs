namespace Benefits.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTypeGeneroToString : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Genero", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "Genero");
        }
    }
}
