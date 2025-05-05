public class MedianFinder
{
    private PriorityQueue<int, int> left;
    private PriorityQueue<int, int> right;

    public MedianFinder()
    {
        left = new PriorityQueue<int, int>(); // max heap using negative numbers
        right = new PriorityQueue<int, int>(); // min heap
    }

    public void AddNum(int num)
    {
        // Add to left by default
        left.Enqueue(num, -num);
        // If left and right exist then make sure left max < right min
        if (left.Count != 0 && right.Count != 0
            && left.Peek() > right.Peek())
        {
            int leftMax = left.Dequeue();
            right.Enqueue(leftMax, leftMax);

        }

        // If either left or right are larger than the other then balance them
        if (left.Count > right.Count + 1)
        {
            int leftMax = left.Dequeue();
            right.Enqueue(leftMax, leftMax);
        }
        else if (right.Count > left.Count + 1)
        {
            int rightMin = right.Dequeue();
            left.Enqueue(rightMin, -rightMin);
        }
    }

    public double FindMedian()
    {
        if (left.Count > right.Count)
            return left.Peek();
        else if (right.Count > left.Count)
            return right.Peek();
        else
            return (right.Peek() + left.Peek()) / 2.0;
    }
}


/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */
