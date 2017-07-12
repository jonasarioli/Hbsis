using HBSIS_Test_Clients.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace HBSIS_Test_Clients.Tests.Models
{
    public class TestModeloDados : IModeloDados
    {
        public TestModeloDados()
        {
            this.Clientes = new TestClientDbSet();
        }

        public DbSet<Cliente> Clientes { get; set; }

        public void Dispose() { }

        public void MarkAsModified(Cliente item) { }

        public int SaveChanges()
        {
            return 0;
        }
    }
}
