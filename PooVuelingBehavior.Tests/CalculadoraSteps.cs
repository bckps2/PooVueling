using Microsoft.VisualStudio.TestTools.UnitTesting;
using PooVueling;
using System;
using TechTalk.SpecFlow;

namespace PooVuelingBehavior.Tests
{
    [Binding]
    public class CalculadoraSteps
    {
        private readonly Calculadora calc = new Calculadora();
        int num1;
        int num2;
        int result;
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenHaveEnteredIntoCalculator(int p0)
        {
            num1 = p0;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoCalculator(int num)
        {
            num2 = num;
        }
        [When(@"I press the sum button")]
        public void WhenIPressSumButton()
        {
            result = calc.Suma(num1, num2);
        }

        [When(@"I press the subtracts button")]
        public void WhenIPressSubtractsButton()
        {
            result = calc.Resta(num1, num2);
        }

        [When(@"I press the divide button")]
        public void WhenIPressDivideButton()
        {
            result = calc.Division(num1, num2);
        }

        [When(@"I press the multiply button")]
        public void WhenIPressMultiplyButton()
        {
            result = calc.Multiplicacion(num1, num2);
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
             Assert.AreEqual(p0, result);
        }
    }
}
