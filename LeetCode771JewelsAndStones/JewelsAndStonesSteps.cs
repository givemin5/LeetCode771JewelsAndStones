using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace LeetCode771JewelsAndStones
{
    [Binding]
    public class JewelsAndStonesSteps
    {
        [Given(@"I have entered J (.*) into the solution")]
        public void GivenIHaveEnteredJIntoTheSolution(string J)
        {
            ScenarioContext.Current.Add("J",J);
        }
        
        [Given(@"I have entered S (.*) into the solution")]
        public void GivenIHaveEnteredSIntoTheSolution(string S)
        {
            ScenarioContext.Current.Add("S", S);
        }
        
        [When(@"I press NumJewelsInStones")]
        public void WhenIPressNumJewelsInStones()
        {
            var solution = new Solution();
            var J = ScenarioContext.Current.Get<string>("J");
            var S = ScenarioContext.Current.Get<string>("S");
            var actual = solution.NumJewelsInStones(J, S);
            ScenarioContext.Current.Add("actual", actual);
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expected)
        {
            var actual = ScenarioContext.Current.Get<int>("actual");

            Assert.AreEqual(expected, actual);
        }
    }
}
