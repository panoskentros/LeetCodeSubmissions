// Example 1:
//
// Input: grid = [
//     ["1","1","1","1","0"],
//     ["1","1","0","1","0"],
//     ["1","1","0","0","0"],
//     ["0","0","0","0","0"]
// ]
// Output: 1
// Example 2:
//
// Input: grid = [
//     ["1","1","0","0","0"],
//     ["1","1","0","0","0"],
//     ["0","0","1","0","0"],
//     ["0","0","0","1","1"]
// ]
// Output: 3

public class Solution {
    public int NumIslands(char[][] grid) 
    {
        int rows = grid.Length;
        int cols = grid[0].Length;
        HashSet<(int, int)> visited = new();
        int result = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (grid[i][j] == '1' && !visited.Contains((i, j)))
                {
                    result++;
                    Bfs(grid, i, j, visited);
                }
            }
        }
        return result;
    }
    private void Bfs(char[][] grid, int startR, int startC, HashSet<(int, int)> visited)
    {
        int rows = grid.Length;
        int cols = grid[0].Length;
        Queue<(int, int)> queue = new();
        (int, int)[] directions = new[] {(-1, 0), (1, 0), (0, -1), (0, 1)};
        visited.Add((startR, startC));
        queue.Enqueue((startR, startC));
        while (queue.Count > 0)
        {
            var (currR, currC) = queue.Dequeue();
            foreach (var (dr, dc) in directions)
            {
                int r = currR + dr;
                int c = currC + dc;
                if (r >= 0 && r < rows &&
                    c >= 0 && c < cols &&
                    grid[r][c] == '1' &&
                    !visited.Contains((r, c)))
                {
                    visited.Add((r, c));
                    queue.Enqueue((r, c));
                }
            }
        }
    }
}

