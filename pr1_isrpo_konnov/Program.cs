Random rand = new Random();
Console.Write("Введите количество строк: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine());

int[,] matrix = new int[n, m];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrix[i, j] = rand.Next(10);
    }
}

Console.WriteLine("\nСгенерированная матрица");
for (int i = 0;i < n; i++)
{
    for (int j = 0;j < m; j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

int summ = SumMatrix(matrix);
Console.WriteLine("Сумма элементов столбцов, содержащих хотя бы один нулевой элемент: " + summ);

static int SumMatrix(int[,] matrix)
{
    int n = matrix.GetLength(0);
    int m = matrix.GetLength(1);
    int sum = 0;

    for (int j = 0; j < m; j++)
    {
        int columnSum = 0; //сумма значений в столбце
        bool Zero = false; //переменная для определения нуля в столбце

        for (int i = 0; i < n; i++)
        {
            columnSum += matrix[i, j];

            if (matrix[i, j] == 0)
            {
                Zero = true;
            }
        }

        if (Zero == true)
        {
            sum += columnSum;
        }
    }
    return sum;
}
