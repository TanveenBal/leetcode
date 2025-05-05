public class Solution
{
    private char[][] board;
    private string word;
    private int rows;
    private int cols;

    private bool dfs(int r, int c, int progress)
    {
        if (progress >= word.Length)
            return true;
        if (r < 0 || r >= rows ||
            c < 0 || c >= cols ||
            board[r][c] == '#' ||
            board[r][c] != word[progress])
            return false;


        char temp = board[r][c];
        board[r][c] = '#';

        bool found = dfs(r + 1, c, progress + 1) ||
                     dfs(r - 1, c, progress + 1) ||
                     dfs(r, c + 1, progress + 1) ||
                     dfs(r, c - 1, progress + 1);

        board[r][c] = temp;

        return found;
    }
    public bool Exist(char[][] board, string word)
    {
        this.board = board;
        this.word = word;
        this.rows = board.Length;
        this.cols = board[0].Length;

        for (int r = 0; r < rows; ++r)
        {
            for (int c = 0; c < cols; ++c)
            {
                if (board[r][c] == word[0] && dfs(r, c, 0))
                    return true;
            }
        }
        return false;
    }
}
