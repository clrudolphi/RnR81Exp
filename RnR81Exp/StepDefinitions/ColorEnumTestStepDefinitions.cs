namespace RnRGH81CucumberExpr_ItemWithSameKeyAlreadyAdded.StepDefinitions
{
    public enum Colors
    {
        Red,
        Blue, 
        Green, 
        Yellow,
        Black,
        abc
    }
    [Binding]
    public sealed class ColorEnumTestStepDefinitions
    {
        [Given("the color of '{RnRGH81CucumberExpr_ItemWithSameKeyAlreadyAdded.StepDefinitions.Colors}'")]

        [Then("the color of '{RnRGH81CucumberExpr_ItemWithSameKeyAlreadyAdded.StepDefinitions.Colors}' should be OK")]
        public void TheColorOfShouldBeOK(Colors color)
        {
            
        }
    }

}
namespace RnRGH81CucumberExpr_ItemWithSameKeyAlreadyAdded.AnotherNamespace
{
    public enum Colors
    {
        Red,
        Blue,
        Black,
        abc
    }

    [Binding]
    public sealed class ADifferentColorEnumTestStepDefinitions
    {

        [Given("a color of '{RnRGH81CucumberExpr_ItemWithSameKeyAlreadyAdded.AnotherNamespace.Colors}'")]
        public void TheOtherColorOfShouldBeOK(Colors color)
        {
        }
    }

}
