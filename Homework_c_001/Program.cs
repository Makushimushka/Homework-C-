string task_2 = "Задача 2: Напишите программу, которая на вход" +
 "\n принимает два числа и выдаёт, какое число большее, а \n какое" +
 " меньшее. \n a = 5; b = 7 -> max = 7 \n a = 2 b = 10 -> max = 10" +
 " \n a = -9 b = -3 -> max = -3 \n Решение: \n ";

string task_4 = "Задача 4: Напишите программу, которая принимает на" +
" \n вход три числа и выдаёт максимальное из этих чисел." +
" \n 2, 3, 7 -> 7 \n 44 5 78 -> 78 \n 22 3 9 -> 22 \n Решение: \n ";

string task_6 = "Задача 6: Напишите программу, которая на вход" +
" \n принимает число и выдаёт, является ли число чётным" +
" \n (делится ли оно на два без остатка). \n 4 -> да \n -3 -> нет \n 7 -> нет \n Решение: \n ";

string task_8 = "Задача 8: Напишите программу, которая на вход" +
" \n принимает число (N), а на выходе показывает все чётные" +
" \n числа от 1 до N. \n 5 -> 2, 4 \n 8 -> 2, 4, 6, 8 \n Решение: \n ";

bool flag = true;
while (flag == true)
{
    Console.WriteLine("Введите номер задачи из списка [2, 4, 6, 8] 111 - для выхода: ");
    int task_number = int.Parse(Console.ReadLine());
    if (task_number == 2)
    // Решение задачи № 2
    {   Console.Clear();
        Console.Write(task_2);
        Console.Write("Введите первое число: ");
        int n_1 = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int n_2 = int.Parse(Console.ReadLine());

        if (n_1 > n_2)Console.WriteLine("Число " + n_1 + " больше числа " + n_2);
        else if (n_1 < n_2)Console.WriteLine("Число " + n_2 + " больше числа " + n_1);
        else {Console.WriteLine("Числа равны");}
    }
    else if (task_number == 4)
    // Решение задачи № 4
    {
        Console.Clear();
        Console.Write(task_4);
        Console.Write("Введите первое число: ");
        int num_1 = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int num_2 = int.Parse(Console.ReadLine());

        Console.Write("Введите третье число: ");
        int num_3 = int.Parse(Console.ReadLine());

        int max = num_1;

        if (num_1 == num_2 & num_2 == num_3) Console.WriteLine("Числа равны! ");
        else
        {
            if (num_2 > max) max = num_2;
            if (num_3 > max) max = num_3;
            Console.WriteLine("Среди чисел: " + num_1 + ", " + num_2 + ", " + num_3 + ", максимальное: " + max);
        }
    }
    else if (task_number == 6)
    // Решение задачи № 6
    {
        Console.Clear();
        Console.Write(task_6);
        Console.Write("Введите число для проверки на четность: ");
        int n_3 = int.Parse(Console.ReadLine());
        if ((n_3 % 2) == 0) Console.WriteLine("Число: " + n_3 + " - четное");
        else{Console.WriteLine("Число: " + n_3 + " - нечетное");}
    }
     else if (task_number == 8)
    // Решение задачи № 8
    {
        Console.Clear();
        Console.Write(task_8);
        Console.Write("Введите число: ");
        int n_4 = int.Parse(Console.ReadLine());
        int answer = 2;

        while (answer <= n_4)
        {
            Console.Write(answer + ", ");
            answer += 2;
        }
        Console.WriteLine("");
    }
    else if (task_number == 111){flag = false;}
}









