public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int m = matrix.Length; // rows
        int n = matrix[0].Length; // columns

        int row = 0, colm = n - 1; // starting from the top right corner
        while(row < m && colm >= 0)
        {
            if(target == matrix[row][colm])
            {
                // target found
                return true;
            } else if( target > matrix[row][colm])
            {
                // target exists below this
                // eliminate this entire row
                row++;
            } else
            {
                // target exists in left of this
                // eliminate this entire column
                colm--;
            }
        }
        return false;
    }
}
