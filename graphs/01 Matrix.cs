public class Solution
{
    public int[][] UpdateMatrix(int[][] mat)
    {
        int rows = mat.Length;
        int cols = mat[0].Length;
        (int, int)[] dirs = new (int, int)[] {
            (0, -1), (-1, 0), (0, 1), (1, 0)
        };

        Queue<(int, int)> q = new Queue<(int, int)>();
        int[][] dist = new int[rows][];
        for (int r = 0; r < rows; r++)
        {
            dist[r] = new int[cols];
            for (int c = 0; c < cols; c++)
            {
                if (mat[r][c] == 0)
                {
                    q.Enqueue((r, c));
                    dist[r][c] = 0;
                }
                else
                {
                    dist[r][c] = -1;
                }
            }
        }

        while (q.Count > 0)
        {
            (int r, int c) = q.Dequeue();

            foreach ((int dr, int dc) in dirs)
            {
                int newRow = r + dr;
                int newCol = c + dc;

                if (0 <= newRow && newRow < rows &&
                    0 <= newCol && newCol < cols &&
                    dist[newRow][newCol] == -1)
                {
                    dist[newRow][newCol] = dist[r][c] + 1;
                    q.Enqueue((newRow, newCol));
                }
            }
        }

        return dist;
    }
}
