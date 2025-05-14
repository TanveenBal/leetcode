public class SolutionInsert
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        if (intervals.Length == 0)
        {
            return new int[][] { newInterval };
        }

        int n = intervals.Length;
        int target = newInterval[0];
        int low = 0, high = n - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            if (intervals[mid][0] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        List<int[]> result = new List<int[]>();
        for (int i = 0; i < low; i++)
        {
            result.Add(intervals[i]);
        }

        result.Add(newInterval);
        for (int i = low; i < n; i++)
        {
            result.Add(intervals[i]);
        }

        List<int[]> merged = new List<int[]>();
        foreach (int[] interval in result)
        {
            if (merged.Count == 0 ||
                merged[merged.Count - 1][1] < interval[0])
            {
                merged.Add(interval);
            }
            else
            {
                merged[merged.Count - 1][1] =
                    Math.Max(merged[merged.Count - 1][1], interval[1]);
            }
        }

        return merged.ToArray();
    }
}
