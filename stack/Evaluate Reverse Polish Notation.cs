public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        Stack<int> nums = new Stack<int>();

        foreach (string token in tokens)
        {
            if (token == "+")
            {
                int r = nums.Pop();
                int l = nums.Pop();
                int res = l + r;
                nums.Push(res);
            }
            else if (token == "-")
            {
                int r = nums.Pop();
                int l = nums.Pop();
                int res = l - r;
                nums.Push(res);
            }
            else if (token == "/")
            {
                int r = nums.Pop();
                int l = nums.Pop();
                int res = l / r;
                nums.Push(res);
            }
            else if (token == "*")
            {
                int r = nums.Pop();
                int l = nums.Pop();
                int res = l * r;
                nums.Push(res);
            }
            else
                nums.Push(Convert.ToInt32(token));

        }
        return nums.Pop();
    }
}
