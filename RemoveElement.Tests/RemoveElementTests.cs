namespace RemoveElement.Tests;

public class Tests {

    private Solution _solution;
    
    [SetUp]
    public void Setup() {
        _solution = new Solution();
    }

    [Test]
    [TestCase(new int[] {3, 2, 2, 3}, 3, 2)]
    [TestCase(new int[] {0, 1, 2, 2, 3, 0, 4, 2}, 2, 5)]
    [TestCase(new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}, 7, 9)]
    [TestCase(new int[] {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}, 1, 1)]
    [TestCase(new int[] {5, 5, 5, 5, 5}, 5, 0)]
    public void RemoveElement_WhenCalled_ReturnsCorrectAnswer(
        int[] numbers, 
        int removeTarget,
        int correctAnswer) {

        var result = _solution.RemoveElement(numbers, removeTarget);
        
        Assert.That(result, Is.EqualTo(correctAnswer));
    }
}
