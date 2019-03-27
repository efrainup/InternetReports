using System;
using System.Linq;
using System.Data.Entity;
using System.Web.Mvc;
using InternetReports.Areas.Operacion.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Security.Principal;
using InternetReports.AppExtensions;
using System.Security.Claims;
using Moq;

namespace InternetReports.Tests.Controllers
{
    [TestClass]
    public class DescargaExpedientesControllerTest
    {
        [TestMethod]
        public void Index()
        {
            //Arrange
            var controller = new InternetReports.Areas.Operacion.Controllers.DescargaExpedientesController();

            //Act
            ActionResult result = controller.Index();

            //Assert
            
        }

        [TestMethod]
        public void ListadoExpedienteConReferencia()
        {
            //Arrange
            //ClaimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity().)

            Moq.Mock<IIdentityExtensions> mockI = new Moq.Mock<IIdentityExtensions>();
            mockI.Setup(s => s.GetClientId(It.IsAny<IIdentity>())).Returns("590");
            mockI.Setup(s => s.GetNombreCliente(It.IsAny<IIdentity>())).Returns("DANFOSS INDUSTRIES S. DE R. L.");

            IdentityExtensions.Implementation = mockI.Object;

            Moq.Mock<ClaimsPrincipal> mockP = new Moq.Mock<ClaimsPrincipal>();
            mockP.SetupGet(p => p.Identity.Name).Returns("Heidi.MenaLopez@danfoss.com");
            mockP.Setup(p => p.IsInRole("Administrador")).Returns(false);
            mockP.Setup(p => p.FindFirst("ClientId")).Returns(new Claim("ClientId", "590"));
            mockP.As<IPrincipal>();
            IPrincipal unmockedIPrincipal =  mockP.Object;
            //((ClaimsIdentity)unmockedIPrincipal.Identity).AddClaim(new Claim("ClientId", "590"));

            Moq.Mock<ControllerContext> mockContext = new Moq.Mock<ControllerContext>();
            mockContext.SetupGet(p => p.HttpContext.User).Returns(unmockedIPrincipal);
            mockContext.SetupGet(p => p.HttpContext.Request.IsAuthenticated).Returns(true);

            var controller = new InternetReports.Areas.Operacion.Controllers.DescargaExpedientesController();
            controller.ControllerContext = mockContext.Object;
            controller._catalogos = new InternetReports.Models.FakeARCHIVOS_ALT();
            var pedimento = new InternetReports.Models.PedimentosSaaiSirView()
            {
                Referencia = "1900024-00",
                Pedimento = "9000751",
                Aduana = "81",
                Seccion = "0",
                IdClienteC = 590,
                IdClienteP = 590,
                FechaPago = new DateTime(2019,1,10)
            };
            controller._catalogos.PedimentosSaaiSirViews.Add(pedimento);
            controller._catalogos.SaveChanges();

            BusquedaExpedienteViewModel busquedaViewModel = new BusquedaExpedienteViewModel()
            {
                 Referencia = "1900024-00"
            };

            //Act
            ViewResult result = controller.ListadoExpediente(busquedaViewModel).Result as ViewResult;

            //Assert
            Assert.AreEqual("Index", result.ViewName);
            Assert.IsInstanceOfType(result.Model,typeof(InternetReports.Areas.Operacion.Models.BusquedaExpedienteViewModel));
        }

        [TestMethod]
        public void ListadoExpedienteConPedimentoSinFechasRegresaError()
        {
            //Arrange
            //ClaimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity().)

            Moq.Mock<IIdentityExtensions> mockI = new Moq.Mock<IIdentityExtensions>();
            mockI.Setup(s => s.GetClientId(It.IsAny<IIdentity>())).Returns("590");
            mockI.Setup(s => s.GetNombreCliente(It.IsAny<IIdentity>())).Returns("DANFOSS INDUSTRIES S. DE R. L.");

            IdentityExtensions.Implementation = mockI.Object;

            Moq.Mock<ClaimsPrincipal> mockP = new Moq.Mock<ClaimsPrincipal>();
            mockP.SetupGet(p => p.Identity.Name).Returns("Heidi.MenaLopez@danfoss.com");
            mockP.Setup(p => p.IsInRole("Administrador")).Returns(false);
            mockP.Setup(p => p.FindFirst("ClientId")).Returns(new Claim("ClientId", "590"));
            mockP.As<IPrincipal>();
            IPrincipal unmockedIPrincipal = mockP.Object;
            //((ClaimsIdentity)unmockedIPrincipal.Identity).AddClaim(new Claim("ClientId", "590"));

            Moq.Mock<ControllerContext> mockContext = new Moq.Mock<ControllerContext>();
            mockContext.SetupGet(p => p.HttpContext.User).Returns(unmockedIPrincipal);
            mockContext.SetupGet(p => p.HttpContext.Request.IsAuthenticated).Returns(true);

            var controller = new InternetReports.Areas.Operacion.Controllers.DescargaExpedientesController();
            controller.ControllerContext = mockContext.Object;
            controller._catalogos = new InternetReports.Models.FakeARCHIVOS_ALT();
            var pedimento = new InternetReports.Models.PedimentosSaaiSirView()
            {
                Referencia = "1900024-00",
                Pedimento = "9000751",
                Aduana = "81",
                Seccion = "0",
                IdClienteC = 590,
                IdClienteP = 590,
                FechaPago = new DateTime(2019, 1, 10)
            };
            controller._catalogos.PedimentosSaaiSirViews.Add(pedimento);
            controller._catalogos.SaveChanges();

            BusquedaExpedienteViewModel busquedaViewModel = new BusquedaExpedienteViewModel()
            {
                Pedimento = "9000751"
            };

            //Act
            ViewResult result = controller.ListadoExpediente(busquedaViewModel).Result as ViewResult;

            //Assert
            Assert.AreEqual("Index", result.ViewName);
            Assert.IsTrue(result.ViewData.ModelState.ContainsKey("InformacionIncompletaBusqueda"));
            Assert.IsNotNull(result.ViewData.ModelState["InformacionIncompletaBusqueda"].Errors);
            Assert.IsNotNull(result.ViewData.ModelState["InformacionIncompletaBusqueda"].Errors.Contains(new ModelError("Se requiere establecer parámetros de búsqueda por referencia o por pedimento inlcuyendo el año y la aduana")));

        }

        [TestMethod]
        public void ListadoExpedienteConPedimentoInexistenteRegresaError()
        {
            //Arrange
            //ClaimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity().)

            Moq.Mock<IIdentityExtensions> mockI = new Moq.Mock<IIdentityExtensions>();
            mockI.Setup(s => s.GetClientId(It.IsAny<IIdentity>())).Returns("590");
            mockI.Setup(s => s.GetNombreCliente(It.IsAny<IIdentity>())).Returns("DANFOSS INDUSTRIES S. DE R. L.");

            IdentityExtensions.Implementation = mockI.Object;

            Moq.Mock<ClaimsPrincipal> mockP = new Moq.Mock<ClaimsPrincipal>();
            mockP.SetupGet(p => p.Identity.Name).Returns("Heidi.MenaLopez@danfoss.com");
            mockP.Setup(p => p.IsInRole("Administrador")).Returns(false);
            mockP.Setup(p => p.FindFirst("ClientId")).Returns(new Claim("ClientId", "590"));
            mockP.As<IPrincipal>();
            IPrincipal unmockedIPrincipal = mockP.Object;
            //((ClaimsIdentity)unmockedIPrincipal.Identity).AddClaim(new Claim("ClientId", "590"));

            Moq.Mock<ControllerContext> mockContext = new Moq.Mock<ControllerContext>();
            mockContext.SetupGet(p => p.HttpContext.User).Returns(unmockedIPrincipal);
            mockContext.SetupGet(p => p.HttpContext.Request.IsAuthenticated).Returns(true);

            var controller = new InternetReports.Areas.Operacion.Controllers.DescargaExpedientesController();
            controller.ControllerContext = mockContext.Object;
            controller._catalogos = new InternetReports.Models.FakeARCHIVOS_ALT();
            var pedimento = new InternetReports.Models.PedimentosSaaiSirView()
            {
                Referencia = "1900024-00",
                Pedimento = "9000751",
                Aduana = "81",
                Seccion = "0",
                IdClienteC = 590,
                IdClienteP = 590,
                FechaPago = new DateTime(2019, 1, 10)
            };
            controller._catalogos.PedimentosSaaiSirViews.Add(pedimento);
            controller._catalogos.SaveChanges();

            BusquedaExpedienteViewModel busquedaViewModel = new BusquedaExpedienteViewModel()
            {
                Pedimento = "9000754",
                Aduana = "810",
                Año="2019"
            };

            //Act
            ViewResult result = controller.ListadoExpediente(busquedaViewModel).Result as ViewResult;

            //Assert
            Assert.AreEqual("Index", result.ViewName);
            Assert.IsTrue(result.ViewData.ModelState.ContainsKey("PedimentoNoEncontrado"));
            Assert.IsNotNull(result.ViewData.ModelState["PedimentoNoEncontrado"].Errors);
            Assert.IsNotNull(result.ViewData.ModelState["PedimentoNoEncontrado"].Errors.Contains(new ModelError("No se encontró el pedimento o la referencia requerida")));

        }

        [TestMethod]
        public void ListadoExpedienteConPedimentoExistenteOk()
        {
            //Arrange
            //ClaimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity().)

            Moq.Mock<IIdentityExtensions> mockI = new Moq.Mock<IIdentityExtensions>();
            mockI.Setup(s => s.GetClientId(It.IsAny<IIdentity>())).Returns("590");
            mockI.Setup(s => s.GetNombreCliente(It.IsAny<IIdentity>())).Returns("DANFOSS INDUSTRIES S. DE R. L.");

            IdentityExtensions.Implementation = mockI.Object;

            Moq.Mock<ClaimsPrincipal> mockP = new Moq.Mock<ClaimsPrincipal>();
            mockP.SetupGet(p => p.Identity.Name).Returns("Heidi.MenaLopez@danfoss.com");
            mockP.Setup(p => p.IsInRole("Administrador")).Returns(false);
            mockP.Setup(p => p.FindFirst("ClientId")).Returns(new Claim("ClientId", "590"));
            mockP.As<IPrincipal>();
            IPrincipal unmockedIPrincipal = mockP.Object;
            //((ClaimsIdentity)unmockedIPrincipal.Identity).AddClaim(new Claim("ClientId", "590"));

            Moq.Mock<ControllerContext> mockContext = new Moq.Mock<ControllerContext>();
            mockContext.SetupGet(p => p.HttpContext.User).Returns(unmockedIPrincipal);
            mockContext.SetupGet(p => p.HttpContext.Request.IsAuthenticated).Returns(true);

            var controller = new InternetReports.Areas.Operacion.Controllers.DescargaExpedientesController();
            controller.ControllerContext = mockContext.Object;
            controller._catalogos = new InternetReports.Models.FakeARCHIVOS_ALT();
            var pedimento = new InternetReports.Models.PedimentosSaaiSirView()
            {
                Referencia = "1900024-00",
                Pedimento = "9000751",
                Aduana = "81",
                Seccion = "0",
                IdClienteC = 590,
                IdClienteP = 590,
                FechaPago = new DateTime(2019, 1, 10)
            };
            controller._catalogos.PedimentosSaaiSirViews.Add(pedimento);
            controller._catalogos.SaveChanges();

            BusquedaExpedienteViewModel busquedaViewModel = new BusquedaExpedienteViewModel()
            {
                Pedimento = "9000751",
                Aduana = "810",
                Año = "2019"
            };

            //Act
            ViewResult result = controller.ListadoExpediente(busquedaViewModel).Result as ViewResult;

            //Assert
            Assert.AreEqual("Index", result.ViewName);
            Assert.IsInstanceOfType(result.Model, typeof(InternetReports.Areas.Operacion.Models.BusquedaExpedienteViewModel));

        }
    }
}
