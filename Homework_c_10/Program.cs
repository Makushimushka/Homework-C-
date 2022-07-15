/* Задача 73: Есть число N. Сколько групп M, можно получить при разбиении всех
чисел на группы, так чтобы в одной группе все числа были взаимно просты (все
числа в группе друг на друга не делятся)? Найдите M при заданном N и получите
одно из разбиений на группы N ≤ 10²⁰. */
int n = 50;
int[] persons = new int[n];

for (int i = 0; i < n; i++)
{
    persons[i] = i+1;
}



int m = 1;
int[] temp = new int[5];
int indtemp = 0;


int[] check(int value, int[] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        int[] temp = new int[array.Length];
        int index = 0;
        if (array[i] % value != 0 || array[i] / value == 1)
        {
            index++;
            temp[index] = array[i];
            Console.Write(temp[index] + " ");
        }
        

        else return temp;
    }
    return temp;

}

Console.WriteLine(check(persons[2], persons));
/* for (int i = 0; i < persons.Length; i++)
{
    if (check(persons[i], persons)) Console.Write(persons[i]);
}  */