namespace MergeSortedArray.Tests;

[TestFixture]
public class Tests {

    private Solution _solution;

    [SetUp]
    public void Setup() {
        _solution = new Solution();
    }

    [Test]
    [TestCase(
    new[] { 1, 2, 3, 0, 0, 0 },
    3,
    new[] { 2, 5, 6 },
    3,
    new[] { 1, 2, 2, 3, 5, 6 }
    )]
    [TestCase(
    new[] { 1 },
    1,
    new int[] {},
    0,
    new[] { 1 }
    )]
    [TestCase(
    new[] { 0 },
    0,
    new[] { 1 },
    1,
    new[] { 1 }
    )]
    public void MergeSortedArrays_WhenCalled_ReturnsCorrectAnswer(
        int[] nums1,
        int m,
        int[] nums2,
        int n,
        int[] correctAnswer
    ) {

        _solution.Merge(nums1, m, nums2, n);

        Assert.That(nums1, Is.EqualTo(correctAnswer));
    }
}
