// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InputNumber(string str)
{
    int number;
    //string?  text;
    while(true)
    {
        System.Console.Write(str);
        if(int.TryParse(Console.ReadLine(), out number))
        {
            break;
        }
        System.Console.WriteLine("Вы ввели не число");
    }
    return number;
}

int SumChar(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;

}

int num = InputNumber("Введите Ваше число!: ");
int result = SumChar(num);

System.Console.WriteLine($"Сумма цифр числа {num} равно: {result}");

