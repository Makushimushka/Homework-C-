/* Задача 73: Есть число N. Сколько групп M, можно получить при разбиении всех
чисел на группы, так чтобы в одной группе все числа были взаимно просты (все
числа в группе друг на друга не делятся)? Найдите M при заданном N и получите
одно из разбиений на группы N ≤ 10²⁰. */

Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());;
int[] persons = new int[n];

for (int i = 0; i < n; i++)
{
    persons[i] = i+1;
}

void PrintArray(int[] array, string message)
{
    Console.Write(message);
    for (int i = 0; i < n; i++)
    {
        if (array[i] == 0) continue;
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(" ");
}

int maxMin(int firstvalue, int secondvalue, string minmax)
{
    if (minmax.ToLower() == "min")
    {
        if (firstvalue <= secondvalue) return firstvalue;
        else return secondvalue;
    }
    if (minmax.ToLower() == "max")
    {
        if (firstvalue >= secondvalue) return firstvalue;
        else return secondvalue;
    }
    else return 0;
}

int m = 1; 
int[] temp; 
bool condition;
int indtemp;
 

for (int ipers = 0; ipers < persons.Length; ipers++) //persons.Length
{
    if (persons[ipers] == 0) continue;
    temp = new int[persons.Length];
    indtemp = 0;
    temp[indtemp] = persons[ipers];
    persons[ipers] = 0;
    
     // присваиваем первому элементу временного массива первое значение массива с данными

    for (int jpers = 0; jpers < persons.Length; jpers++)
    {
        condition = true;
        if (persons[jpers] == 0) continue; // если ноль выходим из цикла
        if (temp[indtemp] != persons[jpers] &&
            maxMin(temp[indtemp], persons[jpers], "max") % maxMin(temp[indtemp], persons[jpers], "min") != 0)
            {
                for (int itemp = 0; itemp < temp.Length; itemp++)
                {
                    if (temp[itemp] == 0 || persons[jpers] == 0) continue; 
                    if (temp[itemp] != persons[jpers] && 
                        maxMin(temp[itemp], persons[jpers], "max") % maxMin(temp[itemp], persons[jpers], "min") != 0
                        );
                    else condition = false;
                }
                if(condition == true )
                {
                    indtemp++;
                    temp[indtemp] = persons[jpers];
                    persons[jpers] = 0;
                }
            }
    }
    PrintArray(temp, $"Группа {m}: ");
    m++;
}
