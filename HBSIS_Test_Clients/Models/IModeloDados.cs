using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBSIS_Test_Clients.Models
{
    public interface IModeloDados : IDisposable
    {
        DbSet<Cliente> Clientes { get; }
        int SaveChanges();
        void MarkAsModified(Cliente item);
    }
}
