namespace ContainsDuplicate;

public class Solution {

    public bool ContainsDuplicate(int[] numbers) {

        var uniques = new HashSet<int>();

        // Hand written for loop
        // for (int i = 0; i < numbers.Length; i++) {
        //     // Check if the set already has the number
        //     if (uniques.Contains(numbers[i])) {
        //         // Found a duplicate, return true
        //         return true;
        //     }
        //     
        //     // Set does not have the number yet, add it
        //     uniques.Add(numbers[i]);
        //
        // }
        
        // foreach loop
        foreach (var number in numbers) {
            // Check if the set already has the number
            if (uniques.Contains(number)) {
                // Found a duplicate, return true
                return true;
            }
            
            // Set does not have the number yet, add it
            uniques.Add(number);
        }

        // Searched the entire array and did not find a duplicate
        return false;
    }

}
