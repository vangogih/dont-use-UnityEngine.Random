using NUnit.Framework;

public class FastRandomTests
{
    [Test]
    public void FastRandom_GetFloat_Range0To1()
    {
        var rnd = new FastRandom(50);
        Assert.True(false, rnd.GetInt().ToString());
    }
}