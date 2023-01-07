namespace FindPivotIndex;

public class Solution {

    public int PivotIndex(int[] numbers) {

        var totalSum = numbers.Sum();

        var leftSum = 0;

        for (var i = 0; i < numbers.Length; i++) {
            var rightSum = totalSum - leftSum - numbers[i];
            if (leftSum == rightSum) {
               // Found the pivot index 
                return i;
            }

            leftSum += numbers[i];
        }

        // Did not find a pivot index
        return -1;
    }

}
