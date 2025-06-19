namespace JP.MoneyExtensions.New.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void ShouldConvertTheDecimalNumberToIntWithOutPontuation()
    {
        decimal value = 123.45m;

        int result = value.ToIntValue();

        Assert.AreEqual(12345, result);
    }
}