namespace LengthOfLastWord.Tests;

[TestFixture]
public class Tests {

    private Solution _solution;
    
    [SetUp]
    public void Setup() {
        _solution = new Solution();
    }

    [Test]
    [TestCase("Hello, World", 5)]
    [TestCase("  Fly me  to  the  moon  ", 4)]
    [TestCase("luffy is still joyboy", 6)]
    [TestCase(" Taco Cat   ", 3)]
    [TestCase("   National Finals Rodeo !", 5)]
    [TestCase("racecar", 7)]
    [TestCase("otto", 4)]
    [TestCase("  someword  ", 8)]
    [TestCase("  A nut for a jar of tuna?  ", 4)]
    [TestCase("Borrow or rob?", 3)]
    [TestCase("!@#$%^&*,.?:; ", 0)]
    [TestCase(" 0123456789 ", 10)]
    public void LengthOfLastWord_WhenCalled_ReturnsCorrectAnswer(
        string aString, 
        int correctAnswer) {

        var result = _solution.LengthOfLastWord(aString);
        
        Assert.That(result, Is.EqualTo(correctAnswer));
    }
}
