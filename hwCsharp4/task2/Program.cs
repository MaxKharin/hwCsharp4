// Задача 2: Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.

int prompt(string message)
{
    Console.WriteLine(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
}

int digitSum(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number /= 10;
    }
    return result;
}
int number = prompt ("Enter a number, please: ");
int result = digitSum(number);
Console.WriteLine($"Result is {result}");
