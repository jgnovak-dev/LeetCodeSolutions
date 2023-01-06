namespace ReplaceElementsWithGreatestElementOnRightSide;

public class Solution {

    public int[] ReplaceElementsWithGreatestElementOnRightSide(int[] numbers) {
        
        var rightMax = -1;

        for (var i = numbers.Length - 1; i >= 0; i--) {
            var newMax = Math.Max(rightMax, numbers[i]);
            numbers[i] = rightMax;
            rightMax = newMax;
        }

        return numbers;
    }

}
