using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComiqueriaLogic;
using Archivos;

namespace TestUnitario
{
    [TestClass]
    public class TestUnitario
    {
        [TestMethod]
        public void PudoInsertar()
        {
            DAO d = new DAO();
            try
            {
                d.Insert("esto es una prueba", (float)10, 20);
            }
            catch
            {
                Assert.Fail();
            }
        }
    }
}
