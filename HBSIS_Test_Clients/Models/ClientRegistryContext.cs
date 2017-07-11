using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HBSIS_Test_Clients.Models
{
    public class ClientRegistryContext : DbContext, IClientRegistryContext
    {
        public ClientRegistryContext() : base("name=ClientRegistryContext")
        {
        }
        
        public DbSet<Clientes> Clientes { get; set; }

        public void MarkAsModified(Clientes item)
        {
            Entry(item).State = EntityState.Modified;
        }
    }
}