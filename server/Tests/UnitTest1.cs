namespace Tests; // new update => file-scoped

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Console.WriteLine("Hello Test1");
        Assert.Equal(2,2);
    }

    [Fact]
    public void Test2()
    {
        System.Console.WriteLine("Hello Test2");
        Assert.NotEqual(2,1);
    }
}