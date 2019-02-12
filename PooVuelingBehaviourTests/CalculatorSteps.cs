using Microsoft.VisualStudio.TestTools.UnitTesting;
using PooVueling;
using System;
using TechTalk.SpecFlow;

namespace PooVuelingBehaviourTests
{
    [Binding]
    public class CalculatorSteps
    {
        ICalculadora iCalculadora = new Calculadora();
        
        private int result, num1, num2;

        [Given(@"I first have entered (.*) into the calculator")]
        public void GivenIFirstHaveEnteredIntoTheCalculator(int p0)
        {
            num1 = p0;
        }
        
        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int p0)
        {
            num2 = p0;
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = iCalculadora.Suma(num1, num2);
        }
        
        [When(@"I press substract")]
        public void WhenIPressSubstract()
        {
            result = iCalculadora.Resta(num1, num2);
        }
        
        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            result = iCalculadora.Multiplicacion(num1, num2);
        }
        
        [When(@"I press divide")]
        public void WhenIPressDivide()
        {
            result = iCalculadora.Division(num1, num2);
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.AreEqual(p0, result);
        }
    }
}
