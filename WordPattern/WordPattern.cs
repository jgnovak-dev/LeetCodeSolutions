namespace WordPattern;

public class Solution {

    public bool WordPattern(string letters, string words) {

        var wordArray = words.Split();

        if (letters.Length != wordArray.Length) {
            return false;
        }

        var letterDictionary = new Dictionary<char, string>();
        var wordDictionary = new Dictionary<string, char>();

        for (int i = 0; i < letters.Length; i++) {
            var letter = letters[i];
            var word = wordArray[i];

            if (letterDictionary.ContainsKey(letter)) {
                if (letterDictionary[letter] != word) {
                    return false;
                }
            } else {
                letterDictionary[letter] = word;
            }

            if (wordDictionary.ContainsKey(word)) {
                if (wordDictionary[word] != letter) {
                    return false;
                } 
            } else {
                wordDictionary[word] = letter;
            }
        }


        return true;
    }

}
