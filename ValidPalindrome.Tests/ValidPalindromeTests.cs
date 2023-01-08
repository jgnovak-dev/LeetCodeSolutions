namespace ValidPalindrome.Tests;

[TestFixture]
public class Tests {

    private Solution _solution;
    
    [SetUp]
    public void Setup() {
        _solution = new Solution();
    }

    [Test]
    [TestCase("tacocat", true)]
    [TestCase("otto", true)]
    [TestCase("otto", true)]
    [TestCase("Borrow or rob?", true)]
    [TestCase("Poor Dan is in a droop", true)]
    [TestCase("A man, a plan, a canal: Panama", true)]
    [TestCase("race a car", false)]
    [TestCase("  ", true)]
    [TestCase(".", true)]
    [TestCase("......a.....", true)]
    public void IsPalindrome_WhenCalled_ResturnsCorrectAnswer(
        string aString, 
        bool correctAnswer) {
        var result = _solution.IsPalindrome(aString);
        
        Assert.That(result, Is.EqualTo(correctAnswer));
    }
}
