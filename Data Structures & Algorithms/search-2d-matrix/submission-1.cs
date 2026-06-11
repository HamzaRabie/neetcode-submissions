public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int m = matrix.Length , n = matrix[0].Length;
        int l=0  , r=(m*n)-1 ;
        while(l <= r)
        {
            int mid = l + (r-l+1)/2;
            int i = mid/n;
            int j = mid%n;

            if(matrix[i][j] == target)return true;
            else if(matrix[i][j] < target)l=mid+1;
            else r=mid-1;
        }
        return false;
    }
}
