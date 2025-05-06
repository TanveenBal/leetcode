public class SolutionPacificAtlantic
{
    private int rows;
    private int cols;

    private void Dfs(int r, int c, int h, int[][] heights, HashSet<(int, int)> reached)
    {
        if (r < 0 || r >= rows ||
            c < 0 || c >= cols ||
            reached.Contains((r, c)) ||
            h > heights[r][c]) // cannot go uphill
            return;

        reached.Add((r, c));
        Dfs(r + 1, c, heights[r][c], heights, reached);
        Dfs(r - 1, c, heights[r][c], heights, reached);
        Dfs(r, c + 1, heights[r][c], heights, reached);
        Dfs(r, c - 1, heights[r][c], heights, reached);
    }
    public IList<IList<int>> PacificAtlantic(int[][] heights)
    {
        HashSet<(int, int)> p = new HashSet<(int, int)>();
        HashSet<(int, int)> a = new HashSet<(int, int)>();

        rows = heights.Length;
        cols = heights[0].Length;

        for (int r = 0; r < rows; ++r)
            Dfs(r, 0, 0, heights, p);
        for (int c = 0; c < cols; ++c)
            Dfs(0, c, 0, heights, p);
        for (int r = 0; r < rows; ++r)
            Dfs(r, cols - 1, 0, heights, a);
        for (int c = 0; c < cols; ++c)
            Dfs(rows - 1, c, 0, heights, a);

        List<IList<int>> ans = new List<IList<int>>();

        p.IntersectWith(a);
        foreach ((int r, int c) in p)
            ans.Add(new List<int> { r, c });
        return ans;
    }
}
