namespace IsomorphicStrings;

public class Solution {

    public bool IsomorphicStrings(string aString, string bString) {

        if (aString.Length != bString.Length) {
            return false;
        }

        var aDictionary = new Dictionary<char, char>();
        var bDictionary = new Dictionary<char, char>();

        for (int i = 0; i < aString.Length; i++) {
            var aChar = aString[i];
            var bChar = bString[i];

            if (aDictionary.ContainsKey(aChar)) {
                if (aDictionary[aChar] != bChar) {
                    return false;
                }
            } else {
                aDictionary[aChar] = bChar;
            }

            if (bDictionary.ContainsKey(bChar)) {
                if (bDictionary[bChar] != aChar) {
                    return false;
                }
            } else {
                bDictionary[bChar] = aChar;
            }
        }

        return true;
    }

}
