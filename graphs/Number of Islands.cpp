#include <iostream>
#include <queue>
#include <vector>
using namespace std;

class Solution {
public:
  void bfs(int row, int col, vector<vector<char>> &grid,
           vector<pair<int, int>> &dirs) {
    int rows = grid.size();
    int cols = grid[0].size();
    queue<pair<int, int>> q;
    q.push(make_pair(row, col));
    grid[row][col] = '0'; // mark as visited

    while (!q.empty()) {
      pair<int, int> current = q.front();
      q.pop();
      int r = current.first;
      int c = current.second;

      for (size_t i = 0; i < dirs.size(); ++i) {
        int dr = dirs[i].first;
        int dc = dirs[i].second;
        int nr = r + dr;
        int nc = c + dc;

        if (nr >= 0 && nr < rows && nc >= 0 && nc < cols &&
            grid[nr][nc] == '1') {
          q.push(make_pair(nr, nc));
          grid[nr][nc] = '0'; // mark visited
        }
      }
    }
  }

  int numIslands(vector<vector<char>> &grid) {
    if (grid.empty())
      return 0;

    int count = 0;
    vector<pair<int, int>> dirs{{1, 0}, {-1, 0}, {0, 1}, {0, -1}};

    int rows = grid.size();
    int cols = grid[0].size();

    for (int r = 0; r < rows; ++r) {
      for (int c = 0; c < cols; ++c) {
        if (grid[r][c] == '1') {
          ++count;
          bfs(r, c, grid, dirs);
        }
      }
    }
    return count;
  }
};

int main() {
  vector<vector<char>> grid = {{'1', '1', '1', '1', '0'},
                               {'1', '1', '0', '1', '0'},
                               {'1', '1', '0', '0', '0'},
                               {'0', '0', '0', '0', '0'}};

  Solution solution;
  int result = solution.numIslands(grid);
  cout << "Number of islands: " << result << endl;
  return 0;
}
