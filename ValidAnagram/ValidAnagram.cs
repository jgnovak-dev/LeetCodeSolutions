namespace ValidAnagram;

public class Solution {

    public bool IsAnagram(string firstString, string secondString) {

        // An anagram requires two strings to be the same length
        if (firstString.Length != secondString.Length) {
            return false;
        }

        int[] store = new int[26];

        for (int i = 0; i < firstString.Length; i++) {

            // Increment the character seen at this position
            store[firstString[i] - 'a']++;
            // Decrement the character seen at this position
            store[secondString[i] - 'a']--;
        }

        // All elements should be zero if it is an anagram
      
        // Hand written for loop example
        // for (int i = 0; i < store.Length; i++) {
        //     if (store[i] != 0) {
        //         return false;
        //     }
        // }
        
        // foreach loop example
        // foreach (var t in store) {
        //     if (t != 0) {
        //         return false;
        //     }
        // }

        // LINQ expression example
        return store.All(t => t == 0);

        // When using either a for loop or foreach loop, would need to 
        // return true here.
        // return true;
    } 

}
