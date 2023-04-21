//Напишите программу, которая принимает на вход координаты двух точек 
//и нахотид расстояние между ними в 3D пространстве.

Console.Clear();

int a1 = GetUserInput("Введите значение x1: ");
int b1 = GetUserInput("Введите значение y1: ");
int c1 = GetUserInput("Введите значение z1: ");
int a2 = GetUserInput("Введите значение x2: ");
int b2 = GetUserInput("Введите значение y2: ");
int c2 = GetUserInput("Введите значение z3: ");

double result = Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2) + Math.Pow(c2 - c1, 2));
Console.WriteLine($"A ({a1},{b1},{c1}); B ({a2},{b2},{c2}) -> {result:f2}");

static int GetUserInput(string message)
{
    while (true)
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out int userInput))
            return userInput;

        Console.WriteLine("Вы ввели некорректные данные");
    }
}
