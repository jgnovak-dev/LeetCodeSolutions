namespace FindPivotIndex;

public class Solution {

    public int PivotIndex(int[] numbers) {

        var totalSum = numbers.Sum();

        var leftSum = 0;

        for (var i = 0; i < numbers.Length; i++) {
            var rightSum = totalSum - leftSum - numbers[i];
            if (leftSum == rightSum) {
                return i;
            }

            leftSum += numbers[i];
        }

        return -1;
    }

}
