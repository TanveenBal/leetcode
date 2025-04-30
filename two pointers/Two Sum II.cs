public class SolutionTwoSum
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int l = 0;
        int r = numbers.Length - 1;

        while (l < r)
        {
            int sum = numbers[l] + numbers[r];
            if (sum > target)
                --r;
            else if (sum < target)
                ++l;
            else
                return new int[2] { ++l, ++r };
        }

        return new int[2] { -1, -1 };
    }
}
