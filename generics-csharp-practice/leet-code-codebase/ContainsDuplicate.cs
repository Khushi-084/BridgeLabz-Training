// Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

public class ContainsDuplicates {
    public bool ContainsDuplicate(int[] nums) {
        Dictionary<int, bool> arr = new Dictionary<int, bool>();
        foreach(int n in nums){
            if(arr.ContainsKey(n))
                return true;
            arr.Add(n,true);
        }
        return false;
    }
}