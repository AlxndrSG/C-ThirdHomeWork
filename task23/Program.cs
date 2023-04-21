//Напишите программ, которая принимает на вход число (N) и
//выдает таблицу кубов чисел от 1 до N.

Console.Clear();

int number = GetNumberFromUser("Введите число: ", "Ошибка ввода!");
PrintCube(number);

void PrintCube(int cubeNumber)
{
    int index = 1;
    while (index <= number)
    {
        double result = Math.Pow(index, 3);
        Console.Write($"{result}, ");
        index++;
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
