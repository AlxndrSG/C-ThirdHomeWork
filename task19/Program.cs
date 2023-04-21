//Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.

Console.Clear();

int num = GetNumberFromUser("Введите число: ", "Ошибка ввода!");

PrintPalindrom(num);

void PrintPalindrom(int number)
{
    if (num > 9999 && num < 100000)
    {

        int pal = num;
        int result = 0;
        while (num > 0)
        {
            int dig = num % 10;
            result = result * 10 + dig;
            num = num / 10;
        }
        if (pal == result)
        {
            Console.WriteLine("Палиндром");
        }
        else
        {
            Console.WriteLine("Не палиндром");
        }
    }
    else
    {
        Console.WriteLine("Введите пятизначное число!");
    }
}

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

