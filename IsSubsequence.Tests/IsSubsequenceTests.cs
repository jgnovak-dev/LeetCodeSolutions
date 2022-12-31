namespace IsSubsequence.Tests;

[TestFixture]
public class Tests {

    private Solution _solution;
    
    [SetUp]
    public void Setup() {
        _solution = new Solution();
    }

    [Test]
    [TestCase("abc", "ahbgdc", true)]
    [TestCase("axc", "ahbgdc", false)]
    [TestCase("xyz", "axbycz", true)]
    [TestCase("cat", "act", false)]
    [TestCase("state", "taste", false)]
    [TestCase("hjkl", "xhcjzkql", true)]
    public void IsSubsequence_WhenCalled_ReturnCorrectAnswer(
        string a,
        string b,
        bool correctAnswer) {

        var result = _solution.IsSubsequence(a, b);
        
        Assert.That(result, Is.EqualTo(correctAnswer));
    }
    
}
