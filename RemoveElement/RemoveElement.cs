namespace RemoveElement;

public class Solution {

    public int RemoveElement(int[] numbers, int removeTarget) {

        // Pointer to track the number and position of moved elements.
        int movedElements = 0;

        for (int i = 0; i < numbers.Length; i++) {
            if (numbers[i] != removeTarget) {
                // Whenever we find a number that is not the removeTarget
                // in numbers[index] we copy it to the position pointed 
                // to by movedElements.
                numbers[movedElements] = numbers[i];
                movedElements++;
            }
        }
        
        // movedElements holds a count of the number of times a number
        // was moved to a new position.

        return movedElements;
    }

}
