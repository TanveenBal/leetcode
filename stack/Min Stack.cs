public class MinStack
{

    private Stack<(int, int)> stack; // (int val, int curMin)

    public MinStack()
    {
        stack = new Stack<(int, int)>();
    }
    public void Push(int val)
    {
        int min = val;
        if (stack.Count > 0)
        {
            (int _, int minimum) = stack.Peek();
            min = Math.Min(min, minimum);
        }
        stack.Push((val, min));
    }
    public void Pop()
    {
        stack.Pop();
    }
    public int Top()
    {
        (int val, int _) = stack.Peek();
        return val;
    }
    public int GetMin()
    {
        (int _, int minimum) = stack.Peek();
        return minimum;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
