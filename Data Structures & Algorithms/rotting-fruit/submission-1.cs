public class Solution {
    public int OrangesRotting(int[][] grid) {
        Queue<(int i , int j)> q = new Queue<(int i, int j)>();
        int n = grid.Length , m = grid[0].Length , fresh=0;
        for(int i=0 ; i<n ; i++)
        {
            for(int j=0 ; j<m ; j++)
            {
                if(grid[i][j] == 2)
                    q.Enqueue((i,j));
                if(grid[i][j] == 1)
                    fresh++;
            }
        }
        if(q.Count == 0 && fresh > 0) return -1;
        int res = 0;
        while(q.Count > 0)
        {
            int size = q.Count ; 
            bool f =false;
            for(int k=0 ; k<size ; k++)
            {
                var fruit = q.Dequeue();
                if( fruit.i + 1 < n && grid[fruit.i +1][fruit.j] == 1)
                {
                    fresh--;
                    grid[fruit.i +1][fruit.j] = 2 ;
                    f=true;
                    q.Enqueue((fruit.i +1,fruit.j));
                }

                if( fruit.i - 1 >= 0 && grid[fruit.i - 1][fruit.j] == 1)
                {
                    fresh--;
                    grid[fruit.i - 1][fruit.j] = 2 ;
                    f=true;
                    q.Enqueue((fruit.i -1,fruit.j));
                }

                if( fruit.j + 1 < m && grid[fruit.i][fruit.j +1] == 1)
                {
                    fresh--;
                    grid[fruit.i][fruit.j +1] = 2 ;
                    f=true;
                    q.Enqueue((fruit.i ,fruit.j+1));
                }

                if( fruit.j - 1 >= 0 && grid[fruit.i][fruit.j - 1] == 1)
                {
                    fresh--;
                    grid[fruit.i][fruit.j - 1] = 2 ;
                    f=true;
                    q.Enqueue((fruit.i,fruit.j - 1));
                }
            }
            if(f)res++;
        }
        
        return fresh != 0 ? -1 : res;
    }

}