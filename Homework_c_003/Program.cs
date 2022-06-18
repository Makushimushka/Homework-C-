/* Задача 19: Напишите программу, которая принимает на
вход пятизначное число и проверяет, является ли оно
палиндромом.
14212 -> нет
23432 -> да
12821 -> да */

void task19()
{
    Console.Clear();
    Console.WriteLine("Введите пятизначное число");
    int number = int.Parse(Console.ReadLine());
    int numlen = (int)Math.Log10(number) + 1;
    string msg = "является палиндромом!";
    string msg2 = "не палиндром!";
    if (numlen == 5)
    {
        int firstnum = number /10000;
        int secondnum = (number /1000)%10;
        int fourthnum = (number /10)%10;
        int fifthnum = number % 10;
        //Console.WriteLine($"{firstnum} | {secondnum} | {fourthnum}| {fifthnum}");
        if ((firstnum == fifthnum) & (secondnum == fourthnum)) Console.WriteLine($"Число: {number} {msg}");
        else Console.WriteLine($"Число: {number} {msg2}");
    }
    else {Console.WriteLine("Введенное число не удовлетворяет условию задачи!"+
    " \nНеобходимо ввести пятизначное число");}
    Console.WriteLine();
}

//task19();

/* Задача 21: Напишите программу, которая принимает на
вход координаты двух точек и находит расстояние между
ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */
void task21()
{   
    Console.Clear();
    double[] point1 = new double[3];
    double[] point2 = new double[3];
    string[] coordinates = {"x", "y", "z"};
    for (int i = 0; i < 3; i++)
    {
        Console.Write($"Введите координаты {coordinates[i]}1: ");
        point1[i] = double.Parse(Console.ReadLine());
    }
    for (int i = 0; i < 3; i++)
    {
        Console.Write($"Введите координаты {coordinates[i]}2: ");
        point2[i] = double.Parse(Console.ReadLine());
    }

    double result = 
    Math.Pow(point1[0] - point2[0], 2)+ 
    Math.Pow(point1[1] - point2[1], 2)+ 
    Math.Pow(point1[2] - point2[2], 2);

    result = Math.Round(Math.Sqrt(result), 2);
    Console.WriteLine($"Расстояние между точками {result}");
    Console.WriteLine();
}
//task21();

/* Задача 23: Напишите программу, которая принимает на
вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9.
5 -> 1, 8, 27, 64, 125
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

void task23()
{
    Console.Clear();
    Console.Write("Введите число: ");
    int num = int.Parse(Console.ReadLine());
    for (int i = 1; i <= num; i++)
    {
        Console.Write(Math.Pow(i, 3) + ", ");
    }
    Console.WriteLine();
}
//task23();


bool flag = true;
while (flag == true)

{
    Console.WriteLine("Введите номер задачи из списка [19, 21, 23] 111 - для выхода: ");
    int task_number = int.Parse(Console.ReadLine());
    if (task_number == 19) task19();
    else if (task_number == 21) task21();
    else if (task_number == 23) task23();
    else if (task_number == 111) flag = false;
    else Console.WriteLine("Введите корректный номер задачи");
    Console.WriteLine();
}