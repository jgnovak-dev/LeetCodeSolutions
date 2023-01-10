namespace ValidParentheses;

public class Solution {

    public bool IsValid(string aString) {
        // aString must be an even number of chars to be balanced, e.g. "()"
        if (aString.Length % 2 != 0) {
            return false;
        }

        var stack = new Stack<char>();
        var parensDictionary = new Dictionary<char, char> {
            [')'] = '(',
            [']'] = '[',
            ['}'] = '{'
        };

        foreach (var aChar in aString) {
            if (!parensDictionary.ContainsKey(aChar)) {
                stack.Push(aChar);
            } else if (stack.Count == 0 || stack.Pop() != parensDictionary[aChar]) {
                return false;
            }
        }

        return stack.Count == 0;
    }

}
