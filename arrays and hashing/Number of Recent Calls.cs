public class RecentCounter
{
    private Queue<int> requests;
    private int Count;

    public RecentCounter() { this.requests = new Queue<int>(); this.Count = 0; }

    public int Ping(int t)
    {
        requests.Enqueue(t);
        Count++;

        while (requests.Peek() < t - 3000)
        {
            requests.Dequeue();
            Count--;
        }

        return Count;
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */
