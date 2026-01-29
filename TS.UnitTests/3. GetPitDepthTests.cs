using TS.TechnicalTest;

namespace TS.UnitTests;

[TestClass]
public class GetPitDepthTests
{
    [TestMethod]
    public void Q2_Complete_BasicNominalTest()
    {
        var points = new[] { 1, 2, 3, 1, 2, 3, 1, 2, 3 };
        var result = DeepestPitAnswer.GetPitDepth(points);

        Assert.AreEqual(2, result);
    }
}
