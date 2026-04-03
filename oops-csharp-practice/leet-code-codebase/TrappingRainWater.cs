//Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it can trap after raining.

class TrappingRainWater {
    public int trap(int[] nums) {
        int[] left = new int [nums.length];
        int[] right = new int [nums.length];
        int sum = 0;
        left[0] = nums[0];
        right[nums.length-1] = nums[nums.length-1];
        for(int i =1;i<nums.length;i++)
        {
            left[i] = Math.max(left[i-1],nums[i]);
            right[nums.length-1-i] = Math.max(right[nums.length-i],nums[nums.length-1-i]);
        }
        for(int i  = 0 ;i<nums.length;i++)
        {
            sum+= Math.min(left[i],right[i])-nums[i];
        }
        return sum;
    }
}