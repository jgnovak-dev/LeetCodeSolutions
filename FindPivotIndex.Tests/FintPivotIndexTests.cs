namespace FindPivotIndex.Tests;

[TestFixture]
public class Tests {

    private Solution _solution;
    
    [SetUp]
    public void Setup() {
        _solution = new Solution();
    }

    [Test]
    [TestCase(new int[] {1, 7, 3, 6, 5, 6}, 3)]
    [TestCase(new int[] {1, 2, 3}, -1)]
    [TestCase(new int[] {2, 1, -1}, 0)]
    public void PivotIndex_WhenCalled_ReturnsCorrectAnswer(int[] numbers, int correctAnswer) {

        var result = _solution.PivotIndex(numbers);
        
        Assert.That(result, Is.EqualTo(correctAnswer));
    }
}
