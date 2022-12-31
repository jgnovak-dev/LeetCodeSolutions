namespace IsSubsequence;

public class Solution {

    public bool IsSubsequence(string aString, string bString) {
        // i is the pointer for moving through aString.
        // j is the pointer for moving through bString.
        int i = 0, j = 0;
        
        while (i < aString.Length && j < bString.Length) {
            // Compare the characters at pointer positions i in
            // aString and j in bString
            if (aString[i] == bString[j]) {
                // Found a matching character for pointer position
                // in aString with pointer position in bString.
                // Advance the i pointer to look for the next 
                // character in aString.
                i++;
            }

            // Each pass we will move the pointer for bString to
            // the next position to look for the next matching char.
            j++;
        }


        // If we found a Subsequence then the pointer for aString
        // will have moved the length of aString.
        // Otherwise we did not find all the characters in aString
        // and advance the pointer for aString to the end. 
        return i == aString.Length;
    }

}
