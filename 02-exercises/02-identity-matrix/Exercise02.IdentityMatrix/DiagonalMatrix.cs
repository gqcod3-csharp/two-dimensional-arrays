namespace Exercise02.IdentityMatrix
{
    public class DiagonalMatrix
    {
        private int[,] diagonal;

        public DiagonalMatrix()
        {
            diagonal = new int[5, 5];
        }

        public void BuildMatrix()
        {
            for (int row = 0; row < diagonal.GetLength(0); row++)
                for (int col = 0; col < diagonal.GetLength(1); col++)
                    diagonal[row, col] = (row == col) ? 1 : 0;
        }

        public void DisplayMatrix()
        {
            for (int row = 0; row < diagonal.GetLength(0); row++)
            {
                for (int col = 0; col < diagonal.GetLength(1); col++)
                    Console.Write($"{diagonal[row, col]} ");
                Console.WriteLine();
            }
        }
    }
}
