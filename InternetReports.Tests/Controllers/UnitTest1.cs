using System;
using System.Collections.Generic;
using Hinojosa.RECOVFP.DataAccessLayer.Entidades.Scontrol;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace InternetReports.Tests.Controllers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var repo = new Hinojosa.RECOVFP.DataAccessLayer.Repositorios.Scontrol.LayoutDanfossRepositorio();
            
            LayoutDanfossCollection sd = repo.Ejecutar("590", new DateTime(2018, 11, 1), new DateTime(2018, 11, 30));
            //ShimsContext
            // var arr = Array.
            Assert.AreNotEqual(0, sd.LayoutDanfossModels.Length);
        }
    }
}
