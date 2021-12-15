using Railflow.xUnit.TestRail.Reporter.Attributes;
using Xunit;

namespace Example
{
    [RailflowTestClass(Title = "class-title")]
    public class RailflowAttributeExamples
    {
        [RailflowTestMethod(Title = "func-title-1", TestRailIds = new[] { 1, 2, 3 })]
        [Fact]
        public void Test1()
        {
        }

        [RailflowTestMethod(Title = "func-title-2", ResultFields = new[] { "func-result-field-1", "func-result-field-2" })]
        [Fact]
        public void Test2()
        {
        }

        [Fact]
        public void Test3()
        {
        }
    }
}
