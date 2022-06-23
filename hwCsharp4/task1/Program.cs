// Задача 1: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

int prompt(string message)
{
    Console.WriteLine(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
}

int numberA = prompt("Enter a number, please: ");
int numberB = prompt("Enter a power, please: ");
int result = 1;
int i;
for (i = 1; i <= numberB; i++)
{
    result = result * numberA;
}
Console.WriteLine($"The result is {result}");

