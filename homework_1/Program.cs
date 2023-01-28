// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InputNumber(string str)
{
    int number;
    string?  text;
    while(true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if(int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Вы ввели не число");
    }
    return number;
}

int PowAB(int num1, int num2)
    {
        int number1 = num1;
        int number2 = num2;
        int result = num1;
        for (int i = 1; i < number2; i++)
        {
            result *= number1;
        }
        return result;
    }

int num1 = InputNumber("Введите число: ");
int num2 = InputNumber("Введите желаемую степень: ");

int pow = PowAB(num1, num2);

System.Console.WriteLine($"Число {num1} в степень {num2} равно: {pow}");