namespace Labirint;

public static class LoadLabirint
{
    public static CodeOfSquare[,] InitOfLabirint()
    {
        CodeOfSquare[,] labirint = null;
        var file = new StreamReader("..\\..\\..\\..\\labirint.txt");
        string? stringFromFile = file.ReadLine();
        string[] numbersFromLabirint = stringFromFile.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        int row = int.Parse(numbersFromLabirint[0]);
        int column = int.Parse(numbersFromLabirint[1]);
        labirint = new CodeOfSquare[row, column];

        int i = 0;
        while ((stringFromFile=file.ReadLine())!=null)
        {
            numbersFromLabirint = stringFromFile.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < column; j++)
            {
                labirint[i, j] = (CodeOfSquare)int.Parse(numbersFromLabirint[j]);
            }

            i++;
        }

        return labirint;
    }
}