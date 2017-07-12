using HBSIS_Test_Clients.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace HBSIS_Test_Clients.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ModeloDados>
    {
        public Configuration()
        {
            this.AutomaticMigrationDataLossAllowed = true;
            this.AutomaticMigrationsEnabled = false;
        }
        protected override void Seed(ModeloDados context)
        {
            //  This method will be called after migrating to the latest version.
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            context.Clientes.AddOrUpdate(
              p => p.Nome,
              new Cliente { Id = 1, Nome = "Joao", Codigo = "201701", Documento = "224.234.234-234", Telefone="(19)87456-9874" },
              new Cliente { Id = 2, Nome = "Jose", Codigo = "201702", Documento = "224.234.234-234", Telefone = "(19)87456-9874" },
              new Cliente { Id = 3, Nome = "Julia", Codigo = "201703", Documento = "224.234.234-234", Telefone = "(19)87456-9874" },
              new Cliente { Id = 4, Nome = "Julian", Codigo = "201704", Documento = "224.234.234-234", Telefone = "(19)87456-9874" },
              new Cliente { Id = 5, Nome = "Juliana", Codigo = "201705", Documento = "224.234.234-234", Telefone = "(19)87456-9874" },
              new Cliente { Id = 6, Nome = "Jesse", Codigo = "201706", Documento = "224.234.234-234", Telefone = "(19)87456-9874" }
            );

            base.Seed(context);
            context.SaveChanges();
        }
    }
}
