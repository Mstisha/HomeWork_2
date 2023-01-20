int GetNumber()
{
    Console.WriteLine("Введите трёхзначное число:");
    int numbers = Convert.ToInt32(Console.ReadLine());
    return numbers;
}

int DeletNumber(int number)
{
    return (number % 100) / 10;
}
int number = GetNumber();
Console.WriteLine(DeletNumber(number));