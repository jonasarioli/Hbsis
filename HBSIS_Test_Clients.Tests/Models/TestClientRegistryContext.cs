using HBSIS_Test_Clients.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace HBSIS_Test_Clients.Tests.Models
{
    public class TestClientRegistryContext : IDBEntities
    {
        public TestClientRegistryContext()
        {
            this.Clientes = new TestClientDbSet();
        }

        public DbSet<Clientes> Clientes { get; set; }

        public void Dispose() { }

        public void MarkAsModified(Clientes item) { }

        public int SaveChanges()
        {
            return 0;
        }
    }
}
