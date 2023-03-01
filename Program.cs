// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.");
Console.WriteLine("Enter number greater than 0:");
int number = int.Parse(Console.ReadLine());
NumbersView(number);

void NumbersView(int number)
{
    if (number < 0) 
    {
        Console.Write("Enter number greater than 0"); 
        return;
    }
    else if (number == 0) return;
    Console.Write(number + " ");
    NumbersView(number - 1);
}



// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
Console.WriteLine("Enter M:");
int numberM = int.Parse(Console.ReadLine());
Console.WriteLine("Enter N:");
int numberN = int.Parse(Console.ReadLine());

int temp = numberM;
if (numberM > numberN) 
{
  numberM = numberN; 
  numberN = temp;
}

Sum(numberM, numberN, temp=0);

void Sum(int m, int n, int sum)
{
  sum = sum + n;
  if (n <= m)
  {
    Console.Write(sum);
    return;
  }
  Sum(m, n - 1, sum);
}


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
Console.WriteLine("Enter M:");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter N:");
int number2 = int.Parse(Console.ReadLine());


int AckermannFunction (int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return AckermannFunction(m - 1, 1);
    if (m > 0 && n > 0) return AckermannFunction(m - 1, AckermannFunction (m,n - 1));
return AckermannFunction(m, n);
}

Console.WriteLine(AckermannFunction(number1, number2));
