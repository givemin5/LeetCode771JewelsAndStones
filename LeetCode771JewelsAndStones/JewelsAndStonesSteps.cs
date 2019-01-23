using System;
using TechTalk.SpecFlow;

namespace LeetCode771JewelsAndStones
{
    [Binding]
    public class JewelsAndStonesSteps
    {
        [Given(@"I have entered J (.*) into the solution")]
        public void GivenIHaveEnteredJIntoTheSolution()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered S (.*) into the solution")]
        public void GivenIHaveEnteredSIntoTheSolution()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press NumJewelsInStones")]
        public void WhenIPressNumJewelsInStones()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
