string ourtask25 = "Условие задачи № 25: Напишите цикл, который принимает на вход \n" +
"два числа (A и B) и возводит число A в натуральную\n" + 
"степень B. \n 3, 5 -> 243 (3⁵) \n 2, 4 -> 16";

string ourtask27 = "Условие задачи № 27: Напишите программу, которая принимает на" +
"вход число и выдаёт сумму цифр в числе. \n452 -> 11\n82 -> 10\n9012 -> 12";

string ourtask29 = "Условие задачи № 29: Напишите программу, которая задаёт массив" +
"из 8 элементов и выводит их на экран. \n1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]\n6, 1, 33 -> [6, 1, 33]";


void task25()
{
    Console.Clear();
    Console.WriteLine(ourtask25);
    Console.Write("Введите число A: ");
    int numa = int.Parse(Console.ReadLine());
    Console.Write("Введите число B: ");
    int numb = int.Parse(Console.ReadLine());
    double result = 0;
    if (numb == 0) result = 1;
    else result = numa;

    for (int i = 1; i < Math.Abs(numb); i++)
    {
        result = result * numa;
    }
    // Работа с отр степенями
    if (numb < 0) result = Math.Round(1/result, 3);

    Console.WriteLine($"Число {numa} в степени {numb} равно: {result}");
}

/* Задача 27: Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

void task27()
{
    Console.Clear();
    Console.WriteLine(ourtask27);
    Console.Write("Введите число: ");
    int userinput = int.Parse(Console.ReadLine());
    // Проверка на знак числа
    bool isnegative = false;
    if (userinput < 0) isnegative = true;
    else isnegative = false;

    int ourint = Math.Abs(userinput);
    int result = 0;

    for (; ourint > 0; ourint = ourint/10)
    {
        result = result + ourint%10;
    }

    if (isnegative == true) result = result * -1;
    Console.WriteLine($"Сумма цифр числа ({userinput}) равна: {result}");
}



/* Задача 29: Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

void PrintArray(int[] coll)
{
    for (int i = 0; i < coll.Length; i++)
    {
        Console.Write(coll[i] + " ");
    }
}

void task29()
{
    Console.Clear();
    Console.WriteLine(ourtask29);
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,100);
    }
    Console.Write("\nСгенерирован массив: ");
    PrintArray(array);

    // Console.Write("\nСгенерирован массив: ");
    // for (int i = 0; i < array.Length; i++)
    // {
    //     Console.Write(array[i] + " ");
    // }
}

bool flag = true;
while (flag == true)

{
    Console.WriteLine();
    Console.WriteLine("Введите номер задачи из списка [25, 27, 29] 111 - для выхода: ");
    int task_number = int.Parse(Console.ReadLine());
    if (task_number == 25) task25();
    else if (task_number == 27) task27();
    else if (task_number == 29) task29();
    else if (task_number == 111) flag = false;
    else Console.WriteLine("Введите корректный номер задачи");
    Console.WriteLine();
}