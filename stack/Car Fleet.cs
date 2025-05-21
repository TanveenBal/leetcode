public class SolutionCarFleet
{
    public int CarFleet(int target, int[] position, int[] speed)
    {
        int n = position.Length;
        if (n == 0) return 0;

        (int pos, int spd)[] p_s = new (int, int)[n];
        for (int i = 0; i < n; ++i)
            p_s[i] = (position[i], speed[i]);

        Array.Sort(p_s, (a, b) => b.pos.CompareTo(a.pos));

        Stack<double> times = new Stack<double>();

        for (int i = 0; i < n; ++i)
        {
            double time = (double)(target - p_s[i].pos) / p_s[i].spd;
            if (times.Count == 0 || time > times.Peek())
                times.Push(time);
        }

        return times.Count;
    }
}
