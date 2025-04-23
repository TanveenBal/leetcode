public class SolutionConvert
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1 || s.Length <= numRows)
            return s;

        string[] strs = Enumerable.Repeat("", numRows).ToArray();

        int row = 0;
        bool down = false;

        foreach (char c in s)
        {
            strs[row] += c;

            if (row == 0 || row == numRows - 1)
                down = !down;

            row += down ? 1 : -1;
        }

        string ans = "";
        foreach (string str in strs)
        {
            ans += str;
        }

        return ans;
    }
}
