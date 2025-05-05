public class SolutionNumIslands
{
    private int ans = 0;
    private (int, int)[] dirs = new (int, int)[4] { (0, 1), (0, -1), (1, 0), (-1, 0) };
    private int rows;
    private int cols;

    private void bfs(int r, int c, char[][] grid)
    {
        Queue<(int, int)> queue = new Queue<(int, int)>();
        queue.Enqueue((r, c));

        while (queue.Count != 0)
        {
            (int row, int col) = queue.Dequeue();
            if (row >= 0 && row < rows &&
                col >= 0 && col < cols &&
                grid[row][col] != '#' &&
                grid[row][col] == '1')
            {
                grid[row][col] = '#';
                foreach ((int x, int y) in dirs)
                {
                    int newR = row + x;
                    int newC = col + y;
                    queue.Enqueue((newR, newC));
                }
            }
        }
        ++ans;
    }
    public int NumIslands(char[][] grid)
    {
        rows = grid.Length;
        cols = grid[0].Length;

        for (int r = 0; r < rows; ++r)
        {
            for (int c = 0; c < cols; ++c)
            {
                if (grid[r][c] == '1')
                    bfs(r, c, grid);
            }
        }

        return ans;
    }
}
