using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PooVueling;
using NUnit.Framework;

namespace PooVueling.NunitV.Integration.Tests
{
    public class CalculadoraTest
    {
        private ICalculadora iCalculadora = new Calculadora();

        [TestCase(4, 4, 1)]
        [TestCase(9, 3, 3)]
        public void DivisionTest(int num1, int num2, int resultado)
        {
            Assert.AreEqual(iCalculadora.Division(num1, num2),resultado);
        }

        [TestCase(4, 4, 16)]
        [TestCase(9, 3, 27)]
       
        public void MultiplicacionTest(int num1, int num2, int resultado)
        {
            Assert.AreEqual(iCalculadora.Multiplicacion(num1, num2),resultado);
        }

        [TestCase(4, 4, 0)]
        [TestCase(9, 3, 6)]
        public void RestaTest(int num1, int num2, int resultado)
        {
            Assert.AreEqual(iCalculadora.Resta(num1, num2),resultado);
        }

        [TestCase(4, 4, 8)]
        [TestCase(9, 3, 12)]
        public void SumaTest(int num1, int num2, int resultado)
        {
            Assert.AreEqual(iCalculadora.Suma(num1, num2),resultado);
        }


    }

}
