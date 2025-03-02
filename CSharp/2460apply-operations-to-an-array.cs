// 2460) apply operations to an array

public class Solution {
    public int[] ApplyOperations(int[] nums) {
        
        for (int i=0; i<nums.Length-1; i++) {
            if (nums[i] == nums[i+1]) {
                nums[i] = nums[i]*2;
                nums[i+1] = 0;
            } 
        };

        int x = 0;
        for (int i=0; i<nums.Length; i++) {
            if (nums[i] != 0) {
                nums[x] = nums[i];
                x++;
            }
        };

        for (int i = x; i<nums.Length; i++) {
            nums[i] = 0;
        }
        return nums;
    }
}
