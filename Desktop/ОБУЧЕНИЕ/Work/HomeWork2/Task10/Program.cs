int GetNumber()
{
    Console.WriteLine("Введите трёхзначное число:");
    int number1 = Convert.ToInt32(Console.ReadLine());
    return number1;
}

int DeleteNumber(int number)
{
    return (number / 10) % 10;
}

int number = GetNumber();
int result = DeleteNumber(number);
Console.WriteLine($"Было {number}, стало {result}.");
