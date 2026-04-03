//Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.

//Input: nums = [1,2,3,4,5,6,7], k = 3
//Output: [5,6,7,1,2,3,4]
//Explanation:
//rotate 1 steps to the right: [7,1,2,3,4,5,6]
//rotate 2 steps to the right: [6,7,1,2,3,4,5]
//rotate 3 steps to the right: [5,6,7,1,2,3,4]
 
class RotateArray {
    public void rotate(int[] nums, int k) {
        k = k % nums.length;   // find reminder of k divided by nums.length because k is more than nums.length we don't need to iterate huge iterations.
        reverse(nums,0,nums.length-1);  // first of all reverse entire the array.
        reverse(nums,0,k-1);   // reverse the array from 0th index to k-1 index.
        reverse(nums,k,nums.length-1);   // reverse the array from kth index to araay.length-1 index.
    }
    void reverse(int[] nums,int i,int j){   // Create a reverse function to reverse array from ith position to jth position.
        while(i<j){
            swap(nums,i,j);
            i++;
            j--;
        }
    }
    void swap(int[] nums,int i,int j){   // Create a swap function to swap to array elements.
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}