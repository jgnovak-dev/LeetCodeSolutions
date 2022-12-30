namespace ContainsDuplicate.Tests;

[TestFixture]
public class Tests {

    private Solution _solution;
    
    [SetUp]
    public void Setup() {
        _solution = new Solution();
    }

    [Test]
    [TestCase(new int[] {1, 2, 3, 1}, true)]
    [TestCase(new int[] {1, 2, 3, 4}, false)]
    [TestCase(new int[] {1, 1, 1, 3, 3, 4, 3, 2, 4, 2}, true)]
    public void ContainsDuplicate_WhenCalled_ReturnsCorrectAnswer(
        int[] numbers,
        bool correctAnswer) {

        var result = _solution.ContainsDuplicate(numbers);
        
        Assert.That(result, Is.EqualTo(correctAnswer));

    }
}
