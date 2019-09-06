namespace Benefits.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelacionamentoEmpresaCliente : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EmpresaClientes", "Empresa_EmpresaId", "dbo.Empresas");
            DropForeignKey("dbo.EmpresaClientes", "Cliente_ClienteId", "dbo.Clientes");
            DropIndex("dbo.EmpresaClientes", new[] { "Empresa_EmpresaId" });
            DropIndex("dbo.EmpresaClientes", new[] { "Cliente_ClienteId" });
            CreateTable(
                "dbo.ClientesDaEmpresa",
                c => new
                    {
                        ClienteId = c.Int(nullable: false),
                        EmpresaId = c.Int(nullable: false),
                        ContratadaEm = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.ClienteId, t.EmpresaId })
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Empresas", t => t.EmpresaId, cascadeDelete: true)
                .Index(t => t.ClienteId)
                .Index(t => t.EmpresaId);
            
            DropTable("dbo.EmpresaClientes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.EmpresaClientes",
                c => new
                    {
                        Empresa_EmpresaId = c.Int(nullable: false),
                        Cliente_ClienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Empresa_EmpresaId, t.Cliente_ClienteId });
            
            DropForeignKey("dbo.ClientesDaEmpresa", "EmpresaId", "dbo.Empresas");
            DropForeignKey("dbo.ClientesDaEmpresa", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.ClientesDaEmpresa", new[] { "EmpresaId" });
            DropIndex("dbo.ClientesDaEmpresa", new[] { "ClienteId" });
            DropTable("dbo.ClientesDaEmpresa");
            CreateIndex("dbo.EmpresaClientes", "Cliente_ClienteId");
            CreateIndex("dbo.EmpresaClientes", "Empresa_EmpresaId");
            AddForeignKey("dbo.EmpresaClientes", "Cliente_ClienteId", "dbo.Clientes", "ClienteId", cascadeDelete: true);
            AddForeignKey("dbo.EmpresaClientes", "Empresa_EmpresaId", "dbo.Empresas", "EmpresaId", cascadeDelete: true);
        }
    }
}
