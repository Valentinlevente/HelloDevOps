namespace HelloDevOps.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void shouldSucceed()
    {
        int expected = 2;
        int actual = 1 + 1;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void shouldFail()
    {
        bool shouldBeTrue = false;
        Assert.IsTrue(shouldBeTrue);
    }
}