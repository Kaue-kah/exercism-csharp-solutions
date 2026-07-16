public static class SaddlePoints
{
    public static IEnumerable<(int, int)> Calculate(int[,] matrix)
    {
        List<(int, int)> result = new();
     
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        if (rows == 0 || columns == 0)
            return result;


        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                bool isLargestInRow = true;
                bool isSmallestInColumn = true;

                for (int k = 0; k < columns; k++)
                {
                    if (matrix[i, j] < matrix[i, k])
                    {
                        isLargestInRow = false;
                        break;
                    }

                }

                for (int k = 0; k < rows; k++)
                {
                    if (matrix[i, j] > matrix[k, j])
                    {
                        isSmallestInColumn = false;
                        break;
                    }
                }

                if (isLargestInRow && isSmallestInColumn)
                    result.Add((i + 1, j + 1));
            }
        }

        return result;
    }
}
