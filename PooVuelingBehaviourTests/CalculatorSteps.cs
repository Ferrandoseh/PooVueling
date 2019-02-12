using Microsoft.VisualStudio.TestTools.UnitTesting;
using PooVueling;
using System;
using TechTalk.SpecFlow;

namespace PooVuelingBehaviourTests
{
    [Binding]
    public class CalculatorSteps
    {
        private readonly ICalculadora iCalculadora = new Calculadora();
        private int result;

        [Given(@"I first have entered (.*) into the calculator")]
        public void GivenIFirstHaveEnteredIntoTheCalculator(int p0)
        {
            iCalculadora.FirstNumber = p0;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int p0)
        {
            iCalculadora.SecondNumber = p0;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = iCalculadora.Suma(iCalculadora.FirstNumber, iCalculadora.SecondNumber);
        }

        [When(@"I press substract")]
        public void WhenIPressSubstract()
        {
            result = iCalculadora.Resta(iCalculadora.FirstNumber, iCalculadora.SecondNumber);
        }

        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            result = iCalculadora.Multiplicacion(iCalculadora.FirstNumber, iCalculadora.SecondNumber);
        }

        [When(@"I press divide")]
        public void WhenIPressDivide()
        {
            result = iCalculadora.Division(iCalculadora.FirstNumber, iCalculadora.SecondNumber);
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.AreEqual(p0, result);
        }
    }
}
