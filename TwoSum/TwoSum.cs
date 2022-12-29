namespace TwoSum;

public class Solution {

    public int[] TwoSum(int[] numbers, int target) {

        Dictionary<int, int> seen = new Dictionary<int, int>();

        for (int i = 0; i < numbers.Length; i++) {
            int diff = target - numbers[i];

            if (seen.ContainsKey(diff)) {
                return new int[] { seen[diff], i };
            }

            seen[numbers[i]] = i;
        }


        return new int[] {};
    }

}
