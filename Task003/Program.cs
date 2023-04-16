// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Clear();
int n = ReadNumberFromConsole("Введите требуемое количество строк: ");
int m = ReadNumberFromConsole("Введите требуемое количество столбцов: ");
int[,] numbers = new int[n, m];   // объявляю новый массив с указанной пользователем сеткой
FillArrayRandomNumbers(numbers);  // заполняю массив псевдослучайными числами
Console.WriteLine("Мы получили массив:");
PrintArray(numbers);
Console.WriteLine("Среднее аррифметическое значение каждого столбца равно: ");

for (int j = 0; j < numbers.GetLength(1); j++)  // цикл для подсчёта и вывода среднего арифметического значения
{
  double middle = 0;
  for (int i = 0; i < numbers.GetLength(0); i++)
  {
    middle = (middle + numbers[i, j]);
  }
  middle = middle / n;
  Console.Write($"{Math.Round(middle, 1)}");  // установил вывод результата на округление до одной цифры после запятой
  if (j != numbers.GetLength(1) - 1) Console.Write("; ");  // вывод последнего значения без ";"
}
// Решено - Подскажите пожалуйста, как избавиться от ";" в конце вывода ср.ар значения?

int ReadNumberFromConsole(string message = "")  // метод для чтения из консоли введённого значения
{
  if (message != "")
    Console.WriteLine(message);
  string input = Console.ReadLine();
  return int.Parse(input);
}

void FillArrayRandomNumbers(int[,] array)   // метод для наполнения двумерного массива случайными числами
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(-99, 100);
    }
  }
}

void PrintArray(int[,] array)   // метод для вывода массива на печать с табуляцией
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    Console.Write("[      ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j]}\t");  // табуляция
    }
    Console.Write("]");
    Console.WriteLine();
  }
}