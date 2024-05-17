namespace Homework_w9_2

public class Cat
{
    public bool CatIsPlaying(bool isSummer, int temp)
    {
        if (isSummer)
        {
            return temp >= 25 && temp <= 45;
        }
        else
        {
            return temp >= 25 && temp <= 35;
        }
    }
}

[TestClass]
public class UnitTest1
{
    public Cat cat = new Cat();

    [TestMethod]
    public void TestMethod_Summer_Temp_40()
    {
        bool result = cat.CatIsPlaying(true, 40); // Corrected temp value
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void TestMethod_Winter_Temp_40()
    {
        bool result = cat.CatIsPlaying(false, 40); // Corrected temp value
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestMethod_Summer_Temp_10()
    {
        bool result = cat.CatIsPlaying(true, 10);
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestMethod_Winter_Temp_10()
    {
        bool result = cat.CatIsPlaying(false, 10);
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestMethod_Winter_Temp_25()
    {
        bool result = cat.CatIsPlaying(false, 25);
        Assert.IsTrue(result);
    }
}
