namespace ValidAnagram;

public class Solution {

   public bool IsAnagram(string firstString, string secondString) {

      // An anagram requires two strings to be the same length
      if (firstString.Length != secondString.Length) {
         return false;
      }

      int[] store = new int[26];

      for (int i = 0; i < firstString.Length; i++) {
         // Add the first character
         store[firstString[i] - 'a']++;
         // Decrement the second character
         store[secondString[i] - 'a']--;
      }

      // All elements should be zero if it is an anagram
      for (int i = 0; i < store.Length; i++) {
         if (store[i] != 0) {
            return false;
         }
      }

      return true;
   } 

}
