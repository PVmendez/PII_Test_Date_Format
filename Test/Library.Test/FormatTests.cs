using NUnit.Framework;
using DateFormat;
namespace Library.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void TestCorrectChangeFormat()
    {
        string testDate = "10/11/1977";
        string expected = Program.ChangeFormat(testDate);
        Assert.AreEqual("10/11/1977", expected);
    }
    [Test]
    public void TestCorrectChangeFormat()
    {
        string testDate = "10111977";
        string expected = Program.ChangeFormat(testDate);
        Assert.AreEqual("10/11/1977", expected);
    }

    [Test]
    public void TestCorrectChangeFormat2()
    {
        string testDate = "10/11/1977";
        string expected = Program.ChangeFormat_2(testDate);
        Assert.AreEqual("10/11/1977", expected);
    }

    [Test]
    public void TestIncorrectChangeFormat2()
    {
        string testDate = "10111977";
        string expected = Program.ChangeFormat_2(testDate);
        Assert.AreEqual("10/11/1977", expected);
    }
}