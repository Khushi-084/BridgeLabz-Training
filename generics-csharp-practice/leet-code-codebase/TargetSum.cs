// You are given an integer array nums and an integer target.
//You want to build an expression out of nums by adding one of the symbols '+' and '-' before each integer in nums and then concatenate all the integers.
class TargetSum {
    public int findTargetSumWays(int[] nums, int target) {
        return targetSum(nums, target, 0, 0);
    }

    public int targetSum(int[] nums, int tar, int idx, int currSum) {
        if (idx == nums.length) {
            return (currSum == tar) ? 1 : 0;
        }

        int add = targetSum(nums, tar, idx + 1, currSum + nums[idx]);
        int sub = targetSum(nums, tar, idx + 1, currSum - nums[idx]);

        return add + sub;
    }
}