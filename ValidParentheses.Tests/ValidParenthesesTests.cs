namespace ValidParentheses.Tests;

[TestFixture]
public class Tests {

    private Solution _solution;
    
    [SetUp]
    public void Setup() {
        _solution = new Solution();
    }

    [Test]
    [TestCase("()", true)]
    [TestCase("(]", false)]
    [TestCase("()[]{}", true)]
    [TestCase("(({}))", true)]
    [TestCase("{{[)}}", false)]
    public void ValidParentheses_WhenCalled_ReturnsCorrectAnswer(
        string parenString, 
        bool correctAnswer) {

        var result = _solution.IsValid(parenString);
        
        Assert.That(result, Is.EqualTo(correctAnswer));

    }
}
