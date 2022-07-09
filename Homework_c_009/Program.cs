string ourtask64 = "\nЗадача 64: Задайте значения M и N. Напишите программу, которая выведет все\n" +
"натуральные числа в промежутке от M до N.\n M = 1; N = 5. -> \"1, 2, 3, 4, 5\" \n" +
"M = 4; N = 8. -> \"4, 5, 6, 7, 8\"\n M = 8; N = 4. -> \"8, 7, 6, 5, 4\"\n";


void PrintNumbers2(int m, int n)
{
    if (m == n)
    {
        Console.Write(n + ", ");
        return;
    }
    if (m < n)
    {
        PrintNumbers2(m, n-1);
        Console.Write(n + ", ");
    }
    if (m > n)
    {
        PrintNumbers2(m, n+1);
        Console.Write(n + ", ");
    }
}

void Task64()
{
    Console.WriteLine(ourtask64);
    Console.Write("Введите число M: ");
    int mvalue = int.Parse(Console.ReadLine());
    Console.Write("Введите число N: ");
    int nvalue = int.Parse(Console.ReadLine());
    //PrintNumbers(mvalue, nvalue, mvalue < nvalue);
    PrintNumbers2(mvalue, nvalue);

}

string ourtask66 = "\nЗадача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму\n"+
"натуральных элементов в промежутке от M до N.\n M = 1; N = 15 -> 120\nM = 4; N = 8. -> 30\n";

int cumsumm(int m, int n)
{
    if (m > n) return 0;
    //Console.WriteLine(m);
    return m + cumsumm(m + 1, n);
}

void Task66()
{
    Console.WriteLine(ourtask66);
    Console.Write("Введите число M: ");
    int mvalue = int.Parse(Console.ReadLine());
    Console.Write("Введите число N: ");
    int nvalue = int.Parse(Console.ReadLine());
    Console.WriteLine($"Ответ: {cumsumm(mvalue, nvalue)}");
}


string ourtask68 = "\nЗадача 68: Напишите программу вычисления функции Аккермана с помощью\n"+
"рекурсии. Даны два неотрицательных числа m и n.\n m = 3, n = 2 -> A(m,n) = 29 \n";

int Accerman(int m, int n)

{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Accerman(m-1, 1);
    if (m > 0 && n > 0) return Accerman(m-1, Accerman(m, n-1));
    else return 0;
}

void Task68()
{
    Console.WriteLine(ourtask68);
    Console.Write("Введите число M: ");
    int mvalue = int.Parse(Console.ReadLine());
    Console.Write("Введите число N: ");
    int nvalue = int.Parse(Console.ReadLine());
    Console.Write(Accerman(mvalue, nvalue));
}


bool flag = true;
while (flag == true)

{
    Console.WriteLine();
    Console.WriteLine("Введите номер задачи из списка [64, 66, 68] 111 - для выхода: ");
    int task_number = int.Parse(Console.ReadLine());
    if (task_number == 64) Task64();
    else if (task_number == 66) Task66();
    else if (task_number == 68) Task68();
    else if (task_number == 111) break;
    else Console.WriteLine("Введите корректный номер задачи");
    Console.WriteLine();
}