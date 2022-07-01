/* Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

void Task_41()
{
    Console.Write("Введите числа через запятую: ");
    string userinput = Console.ReadLine();
    string[] numers = userinput.Split(",");
    int result = 0;

    for(int i = 0; i < numers.Length; i++)
    {
        if (int.Parse(numers[i]) > 0)result++;
    }
    Console.WriteLine($"Количество цифр больше 0 введенных пользователем: {result}");
}

// Task_41();

/* Задача 43. Напишите программу, которая найдёт точку
пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1,
y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5) 
https://www.youtube.com/watch?v=WfkSVtVkt5M
*/

void Task_43()
{
    Console.Clear();
    string[] coefficients = {"b1", "k1", "b2", "k2"};
    double[] values_cof = new double[4];
    for (int i = 0; i < 4; i++)
    {
        Console.Write($"Введите координаты {coefficients[i]}: ");
        values_cof[i] = double.Parse(Console.ReadLine());
    }
    
    if (values_cof[1] == values_cof[3]) Console.WriteLine("Это параллельные прямые, пересечения нет");
    else
    {
        double x = (values_cof[0] - values_cof[2])  / (values_cof[3] - values_cof[1]);
        double y = values_cof[1] * x + values_cof[0];
        Console.WriteLine($"({x};{y})");
    }
}

bool flag = true;
while (flag == true)

{
    Console.WriteLine();
    Console.WriteLine("Введите номер задачи из списка [41, 43] 111 - для выхода: ");
    int task_number = int.Parse(Console.ReadLine());
    if (task_number == 41) Task_41();
    else if (task_number == 43) Task_43();
    else Console.WriteLine("Введите корректный номер задачи");
    Console.WriteLine();
}