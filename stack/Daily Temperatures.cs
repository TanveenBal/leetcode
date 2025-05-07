public class Solution
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        int[] ans = new int[temperatures.Length];
        Stack<(int Temp, int Index)> temps = new Stack<(int, int)>();

        for (int i = 0; i < temperatures.Length; ++i)
        {
            int currTemp = temperatures[i];
            while (temps.Count > 0 && currTemp > temps.Peek().Temp)
            {
                (int prevTemp, int index) = temps.Pop();
                ans[index] = i - index;
            }

            temps.Push((currTemp, i));
        }

        return ans;
    }
}
