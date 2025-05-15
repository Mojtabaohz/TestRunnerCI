using NUnit.Framework;

public class AlwaysPass
{
    [Test]
    public void AlwaysPasses()
    {
        Assert.IsTrue(true);
    }

    [Test]
    public void AlwaysFails()
    {
        Assert.IsFalse(false);
    }
}