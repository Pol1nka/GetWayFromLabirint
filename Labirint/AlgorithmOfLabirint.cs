namespace Labirint;

public static class AlgorithmOfLabirint
{
    private static List<string> steps = new List<string>();
    public static bool ToFindWay(CodeOfSquare[,] labirint, int row, int col, Direction dir)
    {
        if ((labirint[row, col] & CodeOfSquare.Finish) != 0) //целевая клетка?
        {
            //Console.Write($"[{row},{col}]");
            steps.Add($"[{row},{col}]");
            Console.WriteLine($"Конечная точка: [{row};{col}] ");
            return true;
        }
        bool reached = false;
        //если налево свободно И пришел НЕ справа
        if ((labirint[row, col] & CodeOfSquare.Left) != 0 && dir != Direction.Right)
            reached = ToFindWay(labirint, row, col - 1, Direction.Left);
        
        //если направо свободно И пришел НЕ слева
        if (!reached && (labirint[row, col] & CodeOfSquare.Right) != 0 && dir != Direction.Left)
            reached = ToFindWay(labirint, row, col + 1, Direction.Right);
        
        //если наверх свободно И пришел НЕ снизу
        if (!reached && (labirint[row, col] & CodeOfSquare.Up) != 0 && dir != Direction.Down)
            reached = ToFindWay(labirint, row - 1, col, Direction.Up);
        
        //если вниз свободно И пришел НЕ сверху
        if (!reached && (labirint[row, col] & CodeOfSquare.Down) != 0 && dir != Direction.Up)
            reached = ToFindWay(labirint, row + 1, col, Direction.Down);

        if (reached)
        {
            //Console.Write($"<-[{row},{col}]");
            steps.Add($"<-[{row},{col}]");
        }
        //steps.Reverse();
        foreach (var step in steps)
        {
            Console.Write(step);
        }
        steps.Clear();  

        //Console.WriteLine(steps);
        return reached;;
    }

}