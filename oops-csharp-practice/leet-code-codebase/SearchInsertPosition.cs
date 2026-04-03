//Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order. 

class SearchInsertPosition {
    public int searchInsert(int[] nums, int target) {
        int a = 0;
        int z = nums.length-1;

        while (a <= z) {
            int b = a + (z-a)/2;
            if (nums[b] == target) return b;
            else if (nums[b] > target) z = b-1;
            else a = b+1;
        }

        return a ;
    }
}