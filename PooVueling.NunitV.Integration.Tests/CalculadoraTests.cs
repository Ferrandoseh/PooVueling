using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling.NunitV.Integration.Tests
{
    [TestFixture]
    class CalculadoraTests
    {
        ICalculadora iCalculadora;
   
        [SetUp]
        public void Init()
        {
            iCalculadora = new Calculadora();
        }

        [TestCase(4, 2, 2)]
        public void DivisionTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Division(num1, num2) == resultado);
        }

        [TestCase(9, 0)]
        public void DivisioDivideByZeroExceptionTest(int num1, int num2)
        {
            Assert.That(() => iCalculadora.Division(num1, num2),
                Throws.TypeOf<DivideByZeroException>());
        }

        [TestCase(4, 2, 8)]
        [TestCase(6, 3, 18)]
        public void MultiplicacionTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Multiplicacion(num1, num2) == resultado);
        }

        [TestCase(4, 2, 2)]
        [TestCase(6, 3, 3)]
        public void RestaTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Resta(num1, num2) == resultado);
        }

        [TestCase(4, 2, 6)]
        [TestCase(6, 3, 9)]
        public void SumaTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Suma(num1, num2) == resultado);
        }
    }
}
