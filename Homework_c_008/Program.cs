double[,] getMatrix(int m, int n, int min, int max, int round)
{
    // создает матрицу размером m на n,
    // заполняет ее псевдослучайными вещественными числами
    // из диапазона min - max, возвращает созданную матрицу.
    // аргумент round указывает до скольки знаков надо округлить после запятой, 0 округление до целых

    double[,] matrix = new double[m,n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = Math.Round(new Random().Next(min, max - 1) + new Random().NextDouble(), round);
        }
    }
    return matrix;
}


void printMatrix(double[,] matrix)
{
    // Принимает в аргументе матрицу и печатает ее в консоль.
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "|");
        }
        Console.WriteLine(" ");
    }
    Console.WriteLine(" ");
}


void PrintArrayfordouble(double[] coll, string message)
{
    // Принимает в аргументе массив и текст сообщения и печатает все в консоль.
    Console.Write($"{message}: ");
    for (int i = 0; i < coll.Length; i++)
    {
        Console.Write(coll[i] + " ");
    }
    Console.WriteLine("");
}

/* Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива. */

void sortMatrix(double[,] matrix)
{
    double temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = j; k < matrix.GetLength(1); k++)
                {
                    if (matrix[i, k] > matrix[i, j])
                    {
                        temp = matrix[i, j];
                        matrix[i, j] = matrix[i, k];
                        matrix[i, k] = temp;
                    }
                }
        }
    }
}

double[,] ourmatrix = getMatrix(4, 4, 0, 100, 0);
printMatrix(ourmatrix);
sortMatrix(ourmatrix);
printMatrix(ourmatrix);



/* Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов. */

void task56()
{
    double[,] ourmatrix = getMatrix(4, 4, 0, 100, 0);
    double[] result = new double[ourmatrix.GetLength(0)];
    int minelementindex = 0;

    for (int i = 0; i < ourmatrix.GetLength(0); i++)
        {
            for (int j = 0; j < ourmatrix.GetLength(1); j++) result[i] += ourmatrix[i,j];
            if (result[i] < result[minelementindex]) minelementindex = i;
        }

    PrintArrayfordouble(result, "Сумма строк (в соответствии с их индексами) ");
    Console.WriteLine();
    Console.WriteLine($"Строка с наименьшей суммой элементов соответствует индексу {minelementindex}, \n"+
    $"что соответствует значению {result[minelementindex]}.");
}

task56();


/* Задача 58: Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц. */



void matrixMultiplication(double[,] matrixA, double[,] matrixB)
{
    Console.WriteLine("\nЗадача 58\n");
    if (matrixA.GetLength(1) != matrixB.GetLength(0)) 
    {
        Console.WriteLine("\nУмножение матриц возможно только при условии, \n"+
        " что ширина первой матрицы равна высоте второй, исправьте ввод данны");
    }
    else
    {
        double[,] result = new double [matrixA.GetLength(0), matrixB.GetLength(1)];
        
        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            double temp = 0;
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                for (int k = 0; k < matrixA.GetLength(1); k++)
                {
                    result[i, j] += matrixA[i, k] * matrixB[k, j];  
                }
            }
        }

        Console.WriteLine("Матрица А:");
        printMatrix(matrixA);
        Console.WriteLine("Матрица B:");
        printMatrix(matrixB);
        Console.WriteLine("Результат произведения:");
        printMatrix(result);

    }
}



double[,] matrixAA = getMatrix(2, 4, 0, 10, 0);
double[,] matrixBB = getMatrix(4, 3, 0, 10, 0);
matrixMultiplication(matrixAA, matrixBB);

/* Задача 60: Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно выводить
массив, добавляя индексы каждого элемента. */


/* Задача 62: Заполните спирально массив 4 на 4. */
Console.WriteLine("Задача 62:");

double[,] newmatrix = new double[4,4];
int row = 0;
int col = 0;
int razvorotRow = newmatrix.GetLength(0)-1;
int razvorotCol = newmatrix.GetLength(1)-1;
int value = 0;


while(col <= razvorotCol && row <= razvorotRow)
{
    //вправо
    for (int i = col; i <= razvorotCol; i++)
    {
        newmatrix[row, i] = value;
        value++;
    }
    row++;

    // вниз
    for (int j = row; j <= razvorotRow; j++)
    {
        newmatrix[j, razvorotCol] = value;
        value++;
        //Console.WriteLine(j);
    }
    razvorotCol--;

    //влево
    for (int k = razvorotCol; k >= col; k--)
    {
        newmatrix[razvorotRow, k] = value;
        value++;
    }
    razvorotRow--;

    //вверх
    for (int t = razvorotRow; t >= row; t--)
    {
        newmatrix[t, col] = value;
        
        value++;
    }
    col++;
}


printMatrix(newmatrix);
// Console.Write(newmatrix[11]);



