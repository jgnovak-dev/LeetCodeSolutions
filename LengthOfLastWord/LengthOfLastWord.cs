namespace LengthOfLastWord;

public class Solution {

    public int LengthOfLastWord(string aString) {
        // Initialize a pointer to start at the end of the string.
        int pointer = aString.Length - 1;
        // Return value used to track the length of non-punctuation string.
        int length = 0;
        // Punctuation characters to skip.
        var punctuation = " !@#$%^&*?,.;:";

        // While the character at the pointer position is in punctuation
        // move the pointer left to the next character.
        while (pointer >= 0 && punctuation.Contains(aString[pointer])) {
            // Move the pointer left.
            pointer--;
        }

        // Inside a string of letter or number characters, increment length
        // and decrement pointer until reaching a punctuation character.
        while (pointer >= 0 && !punctuation.Contains(aString[pointer])) {
            // Increment the length.
            length++;
            // Move the pointer left.
            pointer--;
        }

        return length;
    }

}
