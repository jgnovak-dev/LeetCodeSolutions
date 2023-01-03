namespace IsomorphicStrings.Tests;

[TestFixture]
public class Tests {

    private Solution _solution;

    [SetUp]
    public void Setup() {
        _solution = new Solution();
    }

    [Test]
    [TestCase("egg", "add", true)]
    [TestCase("foo", "bar", false)]
    [TestCase("paper", "title", true)]
    [TestCase("leet", "code", false)]
    [TestCase("double", "dragon", true)]
    [TestCase("awesome", "sauce", false)]
    [TestCase("badc", "baba", false)]
    public void IsomorphicStrings_WhenCalled_ReturnsCorrectAnswer(
        string aString,
        string bString,
        bool correctAnswer) {

        var result = _solution.IsomorphicStrings(aString, bString);

        Assert.That(result, Is.EqualTo(correctAnswer));
    }
}
