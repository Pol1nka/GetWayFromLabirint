namespace Labirint
{
    class Program
    {
        static void Main(string[] args)
        {
            int startRow = 7;
            int startCol = 2;
            Console.WriteLine($"Начальная точка: [{startRow};{startCol}]");
            CodeOfSquare[,] labirint = LoadLabirint.InitOfLabirint();
            bool reached = AlgorithmOfLabirint.ToFindWay(labirint, startRow, startCol, Direction.None);
            Console.WriteLine("\n\nНайден путь:" + reached);
        }
    }
}

