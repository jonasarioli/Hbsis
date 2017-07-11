using HBSIS_Test_Clients.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace HBSIS_Test_Clients.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DBEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
        protected override void Seed(DBEntities context)
        {
            //  This method will be called after migrating to the latest version.
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            context.Clientes.AddOrUpdate(
              p => p.Nome,
              new Clientes { Nome = "Joao", Codigo = "201701", Documento = "224234234234", Telefone="19874569874" },
              new Clientes { Nome = "Jose", Codigo = "201702", Documento = "224234234234", Telefone = "19874569874" },
              new Clientes { Nome = "Julia", Codigo = "201703", Documento = "224234234234", Telefone = "19874569874" },
              new Clientes { Nome = "Julian", Codigo = "201704", Documento = "224234234234", Telefone = "19874569874" },
              new Clientes { Nome = "Juliana", Codigo = "201705", Documento = "224234234234", Telefone = "19874569874" },
              new Clientes { Nome = "Jesse", Codigo = "201706", Documento = "224234234234", Telefone = "19874569874" }
            );
        }
    }
}
