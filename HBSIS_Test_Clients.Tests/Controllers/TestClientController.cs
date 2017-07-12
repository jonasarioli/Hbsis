using HBSIS_Test_Clients.Controllers;
using HBSIS_Test_Clients.Models;
using HBSIS_Test_Clients.Tests.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Web.Http.Results;

namespace HBSIS_Test_Clients.Tests.Controllers
{
    [TestClass]
    class TestClientController
    {
        [TestMethod]
        public void PostClientes_ShouldReturnSameClient()
        {
            var controller = new ClienteController(new TestModeloDados());

            var item = GetDemoCliente();

            var result =
                controller.PostClientes(item) as CreatedAtRouteNegotiatedContentResult<Clientes>;

            Assert.IsNotNull(result);
            Assert.AreEqual(result.RouteName, "DefaultApi");
            Assert.AreEqual(result.RouteValues["id"], result.Content.Id);
            Assert.AreEqual(result.Content.Nome, item.Nome);
            Assert.AreEqual(result.Content.Codigo, item.Codigo);
        }

        [TestMethod]
        public void PutClientes_ShouldReturnStatusCode()
        {
            var controller = new ClienteController(new TestModeloDados());

            var item = GetDemoCliente();

            var result = controller.PutClientes(item.Id, item) as StatusCodeResult;
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(StatusCodeResult));
            Assert.AreEqual(HttpStatusCode.NoContent, result.StatusCode);
        }

        [TestMethod]
        public void PutCliente_ShouldFail_WhenDifferentID()
        {
            var controller = new ClienteController(new TestModeloDados());

            var badresult = controller.PutClientes(999, GetDemoCliente());
            Assert.IsInstanceOfType(badresult, typeof(BadRequestResult));
        }

        [TestMethod]
        public void GetCliente_ShouldReturnClienteWithSameID()
        {
            var context = new TestModeloDados();
            context.Clientes.Add(GetDemoCliente());

            var controller = new ClienteController(context);
            var result = controller.GetClientes(3) as OkNegotiatedContentResult<Clientes>;

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Content.Id);
        }

        [TestMethod]
        public void GetClientes_ShouldReturnAllClientes()
        {
            var context = new TestModeloDados();
            context.Clientes.Add(new Clientes { Id = 1, Nome = "Demo1", Codigo = "20", Telefone = "(99) 9999-9999", Documento = "999.999.999-99" });
            context.Clientes.Add(new Clientes { Id = 2, Nome = "Demo2", Codigo = "30", Telefone = "(88) 8888-8888", Documento = "888.888.888-88" });
            context.Clientes.Add(new Clientes { Id = 3, Nome = "Demo3", Codigo = "40", Telefone = "(77) 7777-7777", Documento = "777.777.777-77" });

            var controller = new ClienteController(context);
            var result = controller.GetClientes() as TestClientDbSet;

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Local.Count);
        }

        [TestMethod]
        public void DeleteCliente_ShouldReturnOK()
        {
            var context = new TestModeloDados();
            var item = GetDemoCliente();
            context.Clientes.Add(item);

            var controller = new ClienteController(context);
            var result = controller.DeleteClientes(3) as OkNegotiatedContentResult<Clientes>;

            Assert.IsNotNull(result);
            Assert.AreEqual(item.Id, result.Content.Id);
        }

        Clientes GetDemoCliente()
        {
            return new Clientes() { Id = 3, Nome = "Demo name", Codigo = "5", Telefone = "(55) 5555-5555", Documento = "555.555.555-55" };
        }
    }
}
