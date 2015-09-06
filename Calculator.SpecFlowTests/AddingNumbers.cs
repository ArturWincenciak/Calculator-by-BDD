using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Calculator.SpecFlowTests
{
    [Binding]
    public class AddingNumbers
    {
        static private ICalculator calculator;

        [BeforeScenario]
        static public void BeforeFeature()
        {
            calculator = new Calculator();
        }


        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            calculator.Enter(p0);
        }

        [When(@"I press plus")]
        public void WhenIPressPlus()
        {
            calculator.Plus();
        }

        [When(@"I press asterisk")]
        public void WhenIPressAsterisk()
        {
            calculator.Multiply();
        }

        [When(@"I press minus")]
        public void WhenIPressMinus()
        {
            calculator.Substruction();
        }

        [When(@"I press equal")]
        public void WhenIPressEqual()
        {
            calculator.PressEqual();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            int expected = p0;
            int actual = calculator.Result;
            Assert.AreEqual(expected, actual);
        }
    }
}
