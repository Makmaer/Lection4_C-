
/*string [,] table = new string[2, 5];
table [1,2] = "слово"; // [строки, столбцы]

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.Write($"-{table[rows, columns]}-");
    }
    Console.WriteLine();
} */


void PrintArray (int[,] matr)
{for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i, j]} ");
    }
    Console.WriteLine();
}
}
void FillAray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}


int [,] chisla = new int [3, 4];
PrintArray (chisla);
FillAray(chisla);
Console.WriteLine();
PrintArray (chisla);
