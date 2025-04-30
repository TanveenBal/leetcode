public class SolutionMoveZeroes
{
    public void MoveZeroes(int[] nums)
    {
        int insert = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[insert] = nums[i];
                insert++;
            }
        }

        for (int i = insert; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}
