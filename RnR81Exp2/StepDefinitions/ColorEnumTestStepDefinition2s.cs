namespace RnRGH81CucumberExpr_ItemWithSameKeyAlreadyAdded.StepDefinitions
{

    public enum Shade
    {
        Light,
        Dark,
        Grey
    }

    [Binding]
    public sealed class ShadeEnumTestStepDefinitions
    {
        [Given("a shade of '{Shade}'")]
        public void ThisWillResultInAnError(Shade shade) { }
    }
}
namespace RnRGH81CucumberExpr_ItemWithSameKeyAlreadyAdded.AnotherNamespace
{
    public enum Shade
    {
        Light,
        Dark,
        Grey
    }

    [Binding]
    public sealed class AnotherShadeEnumTestStepDefinitions
    {
        [Given("a shade of '{Shade}'")]
        public void ThisWillResultInAnError(Shade shade) { }
    }

}
