using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecflowCodeBehindGen
{
    [Binding]
    public class SpecFlowSteps
    {
        private int x1;
        private int x2;
        private int result;

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            x1 = p0;
        }
        
        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            x2 = p0;
        }
        
        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            result = x1 + x2;
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.AreEqual(p0, result);
        }
    }
}
