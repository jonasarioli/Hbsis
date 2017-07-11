using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBSIS_Test_Clients.Models
{
    public interface IClientRegistryContext : IDisposable
    {
        DbSet<Clientes> Clientes { get; }
        int SaveChanges();
        void MarkAsModified(Clientes item);
    }
}
