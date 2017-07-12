using HBSIS_Test_Clients.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBSIS_Test_Clients.Tests.Models
{
    class TestClientDbSet : TestDbSet<Cliente>
    {
        public override Cliente Find(params object[] keyValues)
        {
            return this.SingleOrDefault(cliente => cliente.Id == (int)keyValues.Single());
        }
    }
}
