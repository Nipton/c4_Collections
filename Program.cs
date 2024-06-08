using System.Diagnostics;

namespace c4_Collections
{
    internal class Program
    {
        /*Дан массив и число.Найдите три числа в массиве сумма которых равна искомому числу.
          Подсказка:если взять первое число в массиве, можно ли найти в оставшейся его части два числа равных по сумме первому.*/
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, };
            int target = 20;
            HashSet<int> set = new HashSet<int>(arr);
            foreach (int i in set)
            {
                foreach (int j in set)
                {
                    if (i!=j && set.Contains(target - i - j))
                    {
                        Console.WriteLine($"Искомые числа: {i}, {j} и {target - i - j}.");
                        return;
                    }
                }
            }
        }
    }
}