// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.Clear();
int lines = ReadNumberFromConsole("Введите желаемое количество строк");
int columns = ReadNumberFromConsole("Введите желаемое количество столбцов");
double[,] numbers = new double[lines, columns];   // объявляю новый массив с данными пользователя
FillArrayRandomNumbers(numbers);    // команда на заполнение массива псевдослучайными числами
Console.WriteLine("Мы получили массив:");   // для "красоты")
PrintArray(numbers);  // выводим массив на печать

void FillArrayRandomNumbers(double[,] array)  // метод для наполнения двумерного массива случайными числами
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = Convert.ToDouble(new Random().Next(-99, 100)) / 10; // деление на 10 использую для получения дробного результата
    }
  }
}

void PrintArray(double[,] array)   // метод для вывода массива на печать
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    Console.Write("[  ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j]}  ");
    }
    Console.Write("]");
    Console.WriteLine();
  }
}

int ReadNumberFromConsole(string message = "")  // метод для чтения из консоли введённого значения
{
  if (message != "")
    Console.WriteLine(message);
  string input = Console.ReadLine();
  return int.Parse(input);
}









