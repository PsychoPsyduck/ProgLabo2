using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralTelefonica;
using CentralitaHerencia;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestListaLlamadas()
        {
            Centralita testCentral = new Centralita("Test");

            Assert.IsNotNull(testCentral.Llamadas);
        }

        [TestMethod]
        public void TestCentralitaExcepcionLocal()
        {
            Centralita testCentral = new Centralita("Test");
            Local testLlamada = new Local("ACA", 30, "ALLÁ", 2.65f);
            testCentral += testLlamada;

            try
            {
                testCentral += testLlamada;
            }
            catch(CentralitaException msj)
            {
                Assert.IsInstanceOfType(msj, typeof(CentralitaException));
            }
        }

        [TestMethod]
        public void TestCentralitaExcepcionProvincial()
        {
            Centralita testCentral = new Centralita("Test");
            Provincial testLlamada = new Provincial("ACA", Provincial.Franja.Franja_1, 21, "ALLA");
            testCentral += testLlamada;

            try
            {
                testCentral += testLlamada;
            }
            catch (CentralitaException msj)
            {
                Assert.IsInstanceOfType(msj, typeof(CentralitaException));
            }
        }

        //[TestMethod]
        //public void TestSonIguales()
        //{
        //    Centralita testCentral = new Centralita("Test");
        //    Local testLlamada1 = new Local("ACA", 30, "ALLÁ", 2.65f);
        //    Local testLlamada2 = new Local("ACA", 30, "ALLÁ", 2.65f);
        //    Provincial testLlamada3 = new Provincial("ACA", Provincial.Franja.Franja_1, 21, "ALLA");
        //    Provincial testLlamada4 = new Provincial("ACA", Provincial.Franja.Franja_1, 21, "ALLA");

        //    testCentral += testLlamada1;
        //    testCentral += testLlamada2;
        //    testCentral += testLlamada3;
        //    testCentral += testLlamada4;

            
        //     Assert.IsTrue(testCentral.Llamadas[0] == testLlamada1);
            
        //}
    }
}
