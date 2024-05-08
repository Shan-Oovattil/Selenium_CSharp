using TechTalk.SpecFlow.Assist;

namespace SpecFlowBasic.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            Console.WriteLine($"First Number:{number}");

           
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            Console.WriteLine($"Second Number:{number}");
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(string result)
        {
            Console.WriteLine($"Result should be PASSED");
        }
               
        [Given(@"I enter following input numberss")]
        public void GivenIEnterFollowingInputNumberss(Table table)
        {
            var datas = table.CreateSet<Calculations>();

            foreach(var data in datas)
            {
                Console.WriteLine(data);
            }
        }

        [Given(@"I enter following input number")]
        public void GivenIEnterFollowingInputNumber(Table table)
        {
            var data = table.CreateInstance<Calculations>();
            Console.WriteLine(data);
        }


        [When(@"the number is displayed")]
        public void WhenTheNumberIsDisplayed()
        {
            Console.WriteLine("Displayed");
        }

        [Given(@"I enter following Dynamic input numberss")]
        public void GivenIEnterFollowingDynamicInputNumberss(Table table)
        {
            dynamic datas = table.CreateDynamicSet();

            foreach(var data in datas)
            {
                Console.WriteLine(data.NumbersToAdd);
            }
        }

        [Then(@"I see the result and few more details")]
        public void ThenISeeTheResultAndFewMoreDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            Console.WriteLine($"The result is going to hold the Value {data.Result} with Logo {data.Logo}");
        }

        /*
          Record types in C# are classes or structs that use value-based equality to work 
          with data models. 
          They are useful for storing data and are immutable by default. 
          Record types were introduced in C# 9.0.
         */
        public record Calculations()
        {
            public int Numbers { get; set; }
        }

    }
}