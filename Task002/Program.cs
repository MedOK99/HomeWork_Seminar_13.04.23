// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();

int n = ReadNumberFromConsole("Введите позицию искомого элемента в строке: ");
int m = ReadNumberFromConsole("Введите позицию искомого элемента в столбце: ");
int[,] numbers = new int[10, 10];  // объявляю новый массив с решёткой 10*10
Console.WriteLine("В нашем массиве:");
FillArrayRandomNumbers(numbers);  // наполняю массив псевдослучайными числами
PrintArray(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))  // цикл для проверки на нахождения числа внутри массива
{
  Console.WriteLine();
  Console.WriteLine("НЕТ элемента с запрошенными Вами данными");
}
else
{
  Console.WriteLine();
  Console.WriteLine($"Элемент в {n} строке и в {m} столбце равен {numbers[n - 1, m - 1]}");
}

int ReadNumberFromConsole(string message = "")  // метод для чтения из консоли введённого значения
{
  if (message != "")
    Console.WriteLine(message);
  string input = Console.ReadLine();
  return int.Parse(input);
}

void FillArrayRandomNumbers(int[,] array)  // метод для наполнения двумерного массива случайными числами
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(-99, 100);
    }
  }
}

void PrintArray(int[,] array)  // метод для вывода массива на печать
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    Console.Write("[ ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j]}  ");
    }
    Console.Write("]");
    Console.WriteLine();
  }
}











