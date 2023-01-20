Console.WriteLine("Введите число");
int numbers = Convert.ToInt32(Console.ReadLine());

if(numbers > 99 & numbers < 1000)
{
    Console.Write(numbers % 10);
}
else if(numbers > 999 & numbers < 10000)
{
    Console.Write((numbers % 100) / 10);
}
else if(numbers > 9999 & numbers < 100000)
{
    Console.Write((numbers % 1000) / 100);
}
else if(numbers > 99999 & numbers < 1000000)
{
    Console.Write((numbers % 10000) / 1000);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}