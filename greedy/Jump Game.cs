public class SolutionCanJump
{
    public bool CanJump(int[] nums)
    {
        int goal = nums.Length - 1;
        for (int i = nums.Length - 2; i >= 0; --i)
        {
            int jump = nums[i];
            // Can we reach from current state to the goal
            if (i + jump >= goal)
                goal = i; // Since we can we can set the goal to the current state
        }

        // if goal == 0 we can get to the back of the array
        return goal == 0;
    }
}
