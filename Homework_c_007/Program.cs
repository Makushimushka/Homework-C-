string ourtask47 = "Задача 47: Задайте двумерный массив размером m×n,"+
"заполненный случайными вещественными числами. \nm = 3, n = 4."+
"\n0,5 7 -2 -0,2 \n1 -3,3 8 -9,9 \n8 7,8 -7,1 9";

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

void task47()
{
    // решение задачи 47
    Console.Clear();
    Console.WriteLine(ourtask47);
    string[] matrixparamsname = new string [] {"количество строк", "количество столбцов",
                                           "минимальное значение для элементов", "максимальное значения (до)",
                                           "значение для округления (знаков после запятой)"};
    int [] matrixparamsvalues = new int [5];
    for (int i = 0; i < matrixparamsname.Length; i++)
    {
        Console.WriteLine($"Введите (в целых числах) желаемое {matrixparamsname[i]}: ");
        matrixparamsvalues[i] = int.Parse(Console.ReadLine());
    }
    
    
    double[,] massiv = getMatrix(matrixparamsvalues[0], matrixparamsvalues[1],
                                 matrixparamsvalues[2], matrixparamsvalues[3],
                                 matrixparamsvalues[4]);
    printMatrix(massiv);
}

string ourtask50 = "Задача 50: Напишите программу, которая на вход\n"+
"принимает позиции элемента в двумерном массиве, и\n" +
"возвращает значение этого элемента или же указание,\n" +
"что такого элемента нет. \nНапример, задан массив:\n1 4 7 2\n5 9 2 3\n8 4 2 4\n"+
"17 -> такого числа в массиве нет";

bool findElement(double element, double[,] matrix)
{
    // в аргументах на вход подается значение для поиска, и матрица в которой необходимо искать.
    // функция возвращает bool результата
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            if (element == matrix[i,j]) return true;
        }
    }
    return false;
}

void task50()
{
    Console.Clear();
    Console.WriteLine(ourtask50+"\n");
    double[,] massiv = getMatrix(4, 4, -10, 10, 0);
    printMatrix(massiv);
    while (true)
    {
        Console.Write("Введите значение элемента для поиска (для выхода наберите 111): ");
        double value = double.Parse(Console.ReadLine());
        if (findElement(value, massiv))Console.WriteLine($"Элемент ({value}) существует в данной матрице!");
        else Console.WriteLine("Такого элемента нет");
        if (value == 111) break; // если есть то определит перед выходом
    }
}
 


string ourtask52 = "Задача 52: Задайте двумерный массив из целых чисел.\n"+
"Найдите среднее арифметическое элементов в каждом столбце.\n"+
"Например, задан массив:\n1 4 7 2\n5 9 2 3\n8 4 2 4\n"+
"Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.";

double[] meanvalue(double[,] matrix)
{
    // получает в аргументе матрицу, в процессе работы запрашивает ось
    // по которой вычисляется среднее арифметическое
    Console.Write("Выберите ось получения среднего арифметического 1 (по строкам),\n"+
                  "0 (по столбцам) либо любое другое число: ");
    int value = int.Parse(Console.ReadLine());
    
    if (value == 1)
    // 
    {
        double[] result = new double[matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                result[i] += matrix[i,j];
            }
            result[i] = result[i]/matrix.GetLength(1);
        }
        return result;
    }

    else
    {
        double[] result = new double[matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                result[i] += matrix[j,i];
            }
            result[i] = result[i]/matrix.GetLength(0);
        }
        return result;
    }
}

void PrintArrayfordouble(double[] coll)
{
    // Принимает в аргументе массив и печатает его в консоль.
    Console.Write("Результат: ");
    for (int i = 0; i < coll.Length; i++)
    {
        Console.Write(coll[i] + "|");
    }
    Console.WriteLine("");
}


void task52()
{
    Console.Clear();
    Console.WriteLine(ourtask52+"\n");
    double[,] massiv = getMatrix(4, 5, 0, 10, 0);
    printMatrix(massiv);
    PrintArrayfordouble(meanvalue(massiv));
}




bool flag = true;
while (flag == true)

{
    Console.WriteLine();
    Console.WriteLine("Введите номер задачи из списка [47, 50, 52] 111 - для выхода: ");
    int task_number = int.Parse(Console.ReadLine());
    if (task_number == 47) task47();
    else if (task_number == 50) task50();
    else if (task_number == 52) task52();
    else if (task_number == 111) flag = false;
    else Console.WriteLine("Введите корректный номер задачи");
    Console.WriteLine();
}