namespace HBSIS_Test_Clients.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelDeDadosMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 200),
                        Codigo = c.String(nullable: false),
                        Telefone = c.String(nullable: false),
                        Documento = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cliente");
        }
    }
}
