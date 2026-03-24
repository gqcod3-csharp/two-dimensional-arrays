namespace Exercise01.MatrixRowColumnSum
{
    public class Matrix
    {
        private int[,] matriz;

        public Matrix()
        {
            matriz = new int[5, 5];
        }

        public void FillMatrix()
        {
            int value = 1;
            for (int row = 0; row < matriz.GetLength(0); row++)
                for (int col = 0; col < matriz.GetLength(1); col++)
                    matriz[row, col] = value++;
        }

        public void CalculateRowSums()
        {
            for (int row = 0; row < matriz.GetLength(0); row++)
            {
                int sum = 0;
                for (int col = 0; col < matriz.GetLength(1); col++)
                    sum += matriz[row, col];
                Console.WriteLine($"Row {row} sum: {sum}");
            }
        }

        public void CalculateColumnSums()
        {
            for (int col = 0; col < matriz.GetLength(1); col++)
            {
                int sum = 0;
                for (int row = 0; row < matriz.GetLength(0); row++)
                    sum += matriz[row, col];
                Console.WriteLine($"Column {col} sum: {sum}");
            }
        }

        public void DisplayResults()
        {
            Console.WriteLine("=== Row Sums ===");
            CalculateRowSums();
            Console.WriteLine("\n=== Column Sums ===");
            CalculateColumnSums();
        }
    }
}
