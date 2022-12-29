namespace TwoSum.Tests;

[TestFixture]
public class Tests {

    private Solution _solution;
    
    [SetUp]
    public void Setup() {
        _solution = new Solution();
    }

    [Test]
    [TestCase(new int[] {2, 7, 11, 15}, 9, new int[] {0, 1})]
    [TestCase(new int[] {3, 2, 4}, 6, new int[] {1, 2})]
    [TestCase(new int[] {3, 3}, 6, new int[] {0, 1})]
    public void TwoSum_WhenCalled_ReturnCorrectAnswer(int[] numbers, int target, int[] correctAnswer) {

        var result = _solution.TwoSum(numbers, target);
        
        Assert.That(result, Is.EqualTo(correctAnswer));
    }

}
