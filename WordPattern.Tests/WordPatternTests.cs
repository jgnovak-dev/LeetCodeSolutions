namespace WordPattern.Tests;

[TestFixture]
public class Tests {

    private Solution _solution;
    
    [SetUp]
    public void Setup() {
        _solution = new Solution();
    }

    [Test]
    [TestCase("abba", "dog cat cat dog", true)]
    [TestCase("abba", "dog cat cat fish", false)]
    [TestCase("aaaa", "dog cat cat dog", false)]
    [TestCase("aaa", "aa aa aa aa", false)]
    public void WordPattern_WhenCalled_ReturnsCorrectAnswer(
        string letters, 
        string words, 
        bool correctAnswer) {

        var result = _solution.WordPattern(letters, words);
        
        Assert.That(result, Is.EqualTo(correctAnswer));

    }
}
