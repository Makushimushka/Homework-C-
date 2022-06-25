
int[] Fillarray(int len, int min, int max)
{
    // создает массив целых чисел длинны len и 
    // заполняет его псевдослучайными числами
    // из диапазона min - max, возвращает созданный массив.

    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}


void PrintArray(int[] coll)
{
    // Принимает в аргументе массив и печатает его в консоль.
    Console.Write("Сгенерирован массив: ");
    for (int i = 0; i < coll.Length; i++)
    {
        Console.Write(coll[i] + " ");
    }
    Console.WriteLine("");
}


double[] Fillarrayfordouble(int len)
{
    // создает массив вещественных чисел длинны len и 
    // заполняет его псевдослучайными числами
    // из диапазона min - max, возвращает созданный массив.

    double[] array = new double[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble();
    }
    return array;
}


void PrintArrayfordouble(double[] coll)
{
    // Принимает в аргументе массив и печатает его в консоль.
    Console.Write("Сгенерирован массив: ");
    for (int i = 0; i < coll.Length; i++)
    {
        Console.Write(coll[i] + " ");
    }
    Console.WriteLine("");
}


string ourtask34 = "Условие задачи № 34: Задайте массив заполненный случайными " +
"положительными трёхзначными числами. Напишите " + 
"программу, которая покажет количество чётных чисел в массиве." +
"\n[345, 897, 568, 234] -> 2\n";

string ourtask36 = "Условие задачи № 36: Задайте одномерный массив, заполненный "+
"случайными числами. Найдите сумму элементов, стоящих "+
"на нечётных позициях. \n[3, 7, 23, 12] -> 19\n[-4, -6, 89, 6] -> 0\n";

string ourtask38 = "Условие задачи № 38: Задайте массив вещественных чисел. Найдите "+
"разницу между максимальным и минимальным элементов массива."+
"\n[3 7 22 2 78] -> 76\n";

void task34()
{
    Console.Clear();
    Console.WriteLine(ourtask34);
    Console.Write("Введите желаемую длинну массива: ");
    int len = int.Parse(Console.ReadLine());
    
    // Создадим массив длинны len и заполним его трехзначными числами.

    int[] mass = Fillarray(len, 100, 1000);
    PrintArray(mass);
    int count = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i]%2 == 0) count++;
    }
    Console.Write($"Количество четных эллементов в массиве: {count}");
}



void task36()
{
    Console.Clear();
    Console.WriteLine(ourtask36);
    Console.Write("Введите желаемую длинну массива: ");
    int len = int.Parse(Console.ReadLine());

    Console.Write("Введите min значение диапазона чисел для заполнения массива: ");
    int min = int.Parse(Console.ReadLine());

    Console.Write("Введите max значение диапазона чисел для заполнения массива: ");
    int max = int.Parse(Console.ReadLine()); 
    // Создадим массив длинны len и заполним его трехзначными числами.

    int[] mass = Fillarray(len, min, max);
    PrintArray(mass);
    int result = 0;
    for (int i = 1; i < mass.Length; i += 2)
    {
        result+=mass[i];
    }
    Console.Write($"Сумма элементов на нечетных позициях массива: {result}");
}

void task38()
{
    Console.Clear();
    Console.WriteLine(ourtask38);
    Console.Write("Введите желаемую длинну массива: ");
    int len = int.Parse(Console.ReadLine());

    Console.Write("Введите min значение диапазона чисел для заполнения массива: ");
    int min = int.Parse(Console.ReadLine());

    Console.Write("Введите max значение диапазона чисел для заполнения массива: ");
    int max = int.Parse(Console.ReadLine()); 
    // Создадим массивы длинны len с форматами double и int, а затем сложим их.

    double[] mass = Fillarrayfordouble(len);
    //PrintArrayfordouble(mass);
    int[] additionalarray = Fillarray(len, min, max);
    //PrintArray(additionalarray);
    
    //Сложим массивы
    for (int i = 0; i < len; i++)
    {
        mass[i] = Math.Round(mass[i] + additionalarray[i], 2);
    }

    PrintArrayfordouble(mass);

    double minvalue = mass[0];
    double maxvalue = mass[0];
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] > maxvalue) maxvalue = mass[i];
        if (mass[i] < minvalue) minvalue = mass[i];
    }
    double result = Math.Round(maxvalue - minvalue, 2);
    Console.Write($"Разница между максимальным и минимальным элементов массива.: {result}");
}

bool flag = true;
while (flag == true)

{
    Console.WriteLine();
    Console.WriteLine("Введите номер задачи из списка [34, 36, 38] 111 - для выхода: ");
    int task_number = int.Parse(Console.ReadLine());
    if (task_number == 34) task34();
    else if (task_number == 36) task36();
    else if (task_number == 38) task38();
    else if (task_number == 111) flag = false;
    else Console.WriteLine("Введите корректный номер задачи");
    Console.WriteLine();
}