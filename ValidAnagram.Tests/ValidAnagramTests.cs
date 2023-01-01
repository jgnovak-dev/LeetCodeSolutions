namespace ValidAnagram.Tests;

[TestFixture]
public class Tests {

    private Solution _solution;
    
    [SetUp]
    public void Setup() {
        _solution = new Solution();
    }

    [Test]
    [TestCase("newyorktimes", "monkeyswrite", true)]
    [TestCase("elbow", "below", true)]
    [TestCase("angel", "glean", true)]
    [TestCase("arc", "car", true)]
    [TestCase("brag", "grab", true)]
    [TestCase("cheap", "peach", true)]
    [TestCase("night", "thing", true)]
    [TestCase("toxin", "taxi", false)]
    [TestCase("abbc", "aabc", false)]
    [TestCase("paper", "reapa", false)]
    [TestCase("cats", "tocs", false)]
    [TestCase("wrong", "wong", false)]
    public void ValidAnagram_WhenCalled_ReturnsCorrectAnswer(
        string firstString,
        string secondString,
        bool correctAnswer) {

        var result = _solution.IsAnagram(firstString, secondString);
        
        Assert.That(result, Is.EqualTo(correctAnswer));

    }
}
