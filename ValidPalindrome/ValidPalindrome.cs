namespace ValidPalindrome;

public class Solution {

    public bool IsPalindrome(string aString) {
        var left = 0;
        var right = aString.Length - 1;

        while (left <= right) {
            var leftChar = aString[left];
            var rightChar = aString[right];

            if (!Char.IsLetterOrDigit(leftChar)) {
                left++;
                continue;
            }

            if (!Char.IsLetterOrDigit(rightChar)) {
                right--;
                continue;
            }

            if (Char.ToLower(leftChar) != Char.ToLower(rightChar)) {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }

}
