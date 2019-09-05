namespace Benefits.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelacionamentoClienteEmpresa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmpresaClientes",
                c => new
                    {
                        Empresa_EmpresaId = c.Int(nullable: false),
                        Cliente_ClienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Empresa_EmpresaId, t.Cliente_ClienteId })
                .ForeignKey("dbo.Empresas", t => t.Empresa_EmpresaId, cascadeDelete: true)
                .ForeignKey("dbo.Clientes", t => t.Cliente_ClienteId, cascadeDelete: true)
                .Index(t => t.Empresa_EmpresaId)
                .Index(t => t.Cliente_ClienteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmpresaClientes", "Cliente_ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.EmpresaClientes", "Empresa_EmpresaId", "dbo.Empresas");
            DropIndex("dbo.EmpresaClientes", new[] { "Cliente_ClienteId" });
            DropIndex("dbo.EmpresaClientes", new[] { "Empresa_EmpresaId" });
            DropTable("dbo.EmpresaClientes");
        }
    }
}
