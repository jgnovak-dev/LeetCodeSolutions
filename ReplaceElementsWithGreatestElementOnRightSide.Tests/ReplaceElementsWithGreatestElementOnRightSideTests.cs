namespace ReplaceElementsWithGreatestElementOnRightSide.Tests;

[TestFixture]
public class Tests {

    private Solution _solution;
    
    [SetUp]
    public void Setup() {
        _solution = new Solution();
    }

    [Test]
    [TestCase(new int[] {17, 18, 5, 4, 6, 1}, new int[] {18, 6, 6, 6, 1, -1})]
    [TestCase(new int[] {400}, new int[] {-1})]
    public void ReplaceElementsWithGreatestElementOnRightSide_WhenCalled_ReturnsCorrectAnswer(
        int[] numbers,
        int[] correctAnswer
    ) {

        var result = _solution.ReplaceElementsWithGreatestElementOnRightSide(numbers);
        
        Assert.That(result, Is.EqualTo(correctAnswer));
    }
}
