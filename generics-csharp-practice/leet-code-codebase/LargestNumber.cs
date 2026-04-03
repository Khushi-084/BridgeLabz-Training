// Given a list of non-negative integers nums, arrange them such that they form the largest number and return it.
// Since the result may be very large, so you need to return a string instead of an integer.

 
public class LargestNumber {
      public string LargestNumber(int[] nums)
  {
      if (nums.Length == 0) return string.Empty;
      if (nums.Length == 1) return nums[0].ToString();

      var numsStr = nums.Select(num => num.ToString()).ToArray();
      Array.Sort(numsStr, (a, b) => (b + a).CompareTo(a + b));

      if (numsStr[0] == "0") return "0";

      var sb = new StringBuilder();
      foreach (var str in numsStr)
          sb.Append(str);

      return sb.ToString();
  }
}