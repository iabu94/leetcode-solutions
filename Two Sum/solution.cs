public class Solution {
    public int[] TwoSumCS(int[] nums, int target) {
        // Loop through each element from 0 to before the last element.
        for (int i = 0; i < nums.Length - 1; i++) {
            // Loop through each element from 1 to last element
            for (int j = i + 1; j < nums.Length; j++) {
                // Check the i th element and j th element's addition equals to target
                if (nums[i] + nums[j] == target) {
                    // Return the elements positions
                    return new int[] {i, j};
                }
            }
        }
        // Return null when there are no matches
        return null;
    }
}