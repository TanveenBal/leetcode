public class SolutionIsValidSudoku
{
    public bool IsValidSudoku(char[][] board)
    {
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[] square = new HashSet<char>[9];

        for (int i = 0; i < 9; i++)
        {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            square[i] = new HashSet<char>();
        }

        for (int r = 0; r < 9; r++)
        {
            for (int c = 0; c < 9; c++)
            {
                char curr = board[r][c];
                if (curr != '.')
                {
                    int squareInd = (r / 3) * 3 + (c / 3);
                    if (rows[r].Contains(curr) || cols[c].Contains(curr) || square[squareInd].Contains(curr))
                        return false;

                    rows[r].Add(curr);
                    cols[c].Add(curr);
                    square[squareInd].Add(curr);
                }
            }
        }

        return true;
    }
}
