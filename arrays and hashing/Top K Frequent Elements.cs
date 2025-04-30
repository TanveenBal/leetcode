public class SolutionTopKFrequent
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        PriorityQueue<int, int> heap = new PriorityQueue<int, int>();
        Dictionary<int, int> counts = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (!counts.ContainsKey(num))
                counts[num] = -1;
            else
                counts[num]--;
        }

        foreach ((int key, int val) in counts)
            heap.Enqueue(key, val);

        int[] ans = new int[k];
        for (int i = 0; i < k; i++)
            ans[i] = heap.Dequeue();

        return ans;
    }
}
