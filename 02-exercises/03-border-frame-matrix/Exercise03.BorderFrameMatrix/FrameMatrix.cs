namespace Exercise03.BorderFrameMatrix
{
    public class FrameMatrix
    {
        private int[,] marco;

        public FrameMatrix()
        {
            marco = new int[5, 15];
        }

        public void BuildFrame()
        {
            int lastRow = marco.GetLength(0) - 1;
            int lastCol = marco.GetLength(1) - 1;

            for (int row = 0; row <= lastRow; row++)
                for (int col = 0; col <= lastCol; col++)
                {
                    bool isBorder = row == 0 || row == lastRow || col == 0 || col == lastCol;
                    marco[row, col] = isBorder ? 1 : 0;
                }
        }

        public void DisplayMatrix()
        {
            for (int row = 0; row < marco.GetLength(0); row++)
            {
                for (int col = 0; col < marco.GetLength(1); col++)
                    Console.Write($"{marco[row, col]} ");
                Console.WriteLine();
            }
        }
    }
}
