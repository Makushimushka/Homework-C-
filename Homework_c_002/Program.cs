string task_10 = "Задача 10: Напишите программу, которая принимает на вход трёхзначное число"+
"\nи на выходе показывает вторую цифру этого числа.\n";

string task_15 = "Задача 15: Напишите программу, которая принимает на"+
"\nвход цифру, обозначающую день недели, и проверяет,"+
"\nявляется ли этот день выходным.\n";

bool flag = true;
while (flag == true)
{
    Console.WriteLine("Домашнее задание. Введите номер задачи 10, 15 или 111 для выхода \n");
    int tasknumber = int.Parse(Console.ReadLine());
    if (tasknumber == 10)
    // решение задачи 10
    {
        Console.Clear();
        Console.WriteLine(task_10);
        Console.Write("Введите трехзначное число: ");
        int number = int.Parse(Console.ReadLine());
        if (number > 99 & number < 1000)
        {
            Console.WriteLine($"Было введено число {number} вторая цифра это {(number % 100)/10}");
        }
        else {Console.WriteLine("Введенное число не удовлетворяет условию задачи! \nНеобходимо ввести трехзначное число");}
    }
    else if (tasknumber == 15)
    // решение задачи 15

    {
        Console.Clear();
        Console.WriteLine(task_15);
        Console.Write("Номер дня недели: ");
        int number = int.Parse(Console.ReadLine());
        if (0 < number &  number <= 7)
        {
            if (number == 6 | number == 7)Console.WriteLine("Выходной");
            else Console.WriteLine("Рабочий");
        }
        else Console.WriteLine("В неделе только 7 дней. Введите цифру 1 - 7");
    }
    else if (tasknumber == 111) flag = false;
}