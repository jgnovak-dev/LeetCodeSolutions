namespace FindPivotIndex;

public class Solution {

    public int PivotIndex(int[] numbers) {

        int totalSum = 0;

        for (int i = 0; i < numbers.Length; i++) {
            totalSum += numbers[i];
        }

        int leftSum = 0;

        for (int i = 0; i < numbers.Length; i++) {
            int rightSum = totalSum - leftSum - numbers[i];
            if (leftSum == rightSum) {
                return i;
            }

            leftSum += numbers[i];
        }

        return -1;
    }

}
