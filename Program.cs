/*
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int m = InputInt(" enter M: ");
int n = InputInt(" enter N: ");
Console.WriteLine($" Sum elements from {m} before {n} = {CountNaturalSum(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int CountNaturalSum(int m, int n)
{
    if (m == n)
        return n;
    return n + CountNaturalSum(m, n - 1);
}
*/
/*
//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int m = InputNumbers(" enter m: ");
int n = InputNumbers(" enter n: ");

int functionAkkerman = akkerman(m, n);

Console.Write($" function Akkerman = {functionAkkerman} ");

int akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return akkerman(m - 1, 1);
  else return akkerman(m - 1, akkerman(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
*/