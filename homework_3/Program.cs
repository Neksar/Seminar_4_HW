// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] numbers = new int[8];
Random rand = new Random();
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rand.Next(0, 99);
    
}
System.Console.WriteLine("[" + string.Join(", ", numbers) + "]");