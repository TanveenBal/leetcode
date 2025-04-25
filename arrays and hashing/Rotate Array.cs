public class SolutionRotateArray
{
    public void Rotate(int[] nums, int k)
    {
        int n = nums.Length;
        k = k % n;
        int count = 0;
        for (int start = 0; count < n; start++)
        {
            int curr = start;
            int prev = nums[start];
            do
            {
                int next = (curr + k) % n;
                int temp = nums[next];
                nums[next] = prev;
                prev = temp;
                curr = next;
                count++;
            }
            while (start != curr);
        }
    }
}
