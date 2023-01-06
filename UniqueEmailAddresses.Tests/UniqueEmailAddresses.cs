namespace UniqueEmailAddresses.Tests;

[TestFixture]
public class Tests {

    private Solution _solution;
    
    [SetUp]
    public void Setup() {
        _solution = new Solution();
    }

    [Test]
    [TestCase(new string[] {
        "test.email+alex@leetcode.com",
        "test.e.mail+bob.cathy@leetcode.com",
        "testemail+david@lee.tcode.com"
    }, 2)]
    [TestCase(new string[] {
       "a@leetcode.com",
        "b@leetcode.com",
        "c@leetcode.com"
    }, 3)]
    public void UniqueEmailAddresses_WhenCalled_ReturnsCorrectAnswer(
        string[] addresses,
        int correctAnswer) {

        var result = _solution.NumUniqueEmails(addresses);
        
        Assert.That(result, Is.EqualTo(correctAnswer));
    }
}
