public class SpiralMatrix
{
    public static int[,] GetMatrix(int size)
    {
        int[,] map = new int[size, size];

        int[] dirX = [1, 0, -1, 0];
        int[] dirY = [0, 1, 0, -1];

        int currentX = -1;
        int currentY = 0;
        int currentDir = 0;



        for (var i = 1; i <= Math.Pow(size, 2); i++)
        {
            var nextX = currentX + dirX[currentDir % 4];
            var nextY = currentY + dirY[currentDir % 4];

            if (((nextX >= size || nextX < 0) || nextY >= size || nextY < 0)
                || (map[nextY, nextX] != 0))
            {
                currentDir++;
                nextX = currentX + dirX[currentDir % 4];
                nextY = currentY + dirY[currentDir % 4];
            }

            currentX = nextX;
            currentY = nextY;

            map[currentY, currentX] = i;
        }

        return map;

    }
}
