//=================================================================================
// Написать программу, которая из имеющегося массива строк формирует массив
// из строк, длина которых меньше либо равна 3 символам. Первоначальный
// массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма
//=================================================================================

string[] array = new string[] {"GB", "developer", "test", "PM", "WEB"};

// Метод фильтрации массива
string[] FiltringArray(string[] arr)
{
  //вычисляем длину массива result
  int arrSize = 0;
  for(int i = 0; i < arr.Length; i++)
  {
    if(arr[i].Length <= 3)
    {
      arrSize++;
    }
  }
  // Создаем массив и наполняем подходящими элементами
  string[] result = new string[arrSize];
  int index = 0;
  for(int i = 0; i < arr.Length; i++)
  {
    if(arr[i].Length <= 3)
    {
      result[index] = arr[i];
      index++;
    }
  }
  return result;
}

// Выводим массив в консоль
void Print1DArray(string[] arr)
{
    Console.WriteLine($"Результат: [{string.Join(", ", arr)}]");
}

Print1DArray(FiltringArray(array));