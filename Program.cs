public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }


        return new int[] { 0, 0 };
    }
}
class Program
{
    static void Main(string[] args)
    {
        Solution sol = new Solution();
        int[] nums = [2, 7, 11, 15];
        int target = 9;
        int[] result = sol.TwoSum(nums, target);

        Console.WriteLine($"Indexes` [{result[0]}, {result[1]}]");

    }
}

