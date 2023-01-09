namespace MergeSortedArray;

public class Solution {

    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        // Get the last index of nums1
        var last = m + n - 1;
    
        // Merge in reverse order
        while (m > 0 && n > 0) {
            if (nums1[m - 1] > nums2[n - 1]) {
                nums1[last] = nums1[m - 1];
                m--;
            } else {
                nums1[last] = nums2[n - 1];
                n--;
            }
    
            last--;
        }

        while (n > 0) {
            nums1[last] = nums2[n - 1];
            n--;
            last--;
        }
    
    }

}
