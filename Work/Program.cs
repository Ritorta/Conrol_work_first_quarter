// Итоговая проверочная работа за первый блок первой четверти курса "Разработчик". 

// Условия задачи:

// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выпоолнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:

// ["hello,", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

//
// Решение:
//

Console.Write("Enter the number of rows for array: ");
int size = Convert.ToInt32(Console.ReadLine());

if(size == 0)
{
   Console.WriteLine("Error!");
   Console.WriteLine("You need enter number rows dont null.");
}
else
{
   string[] strArray = CreateArray1();
   int ThreeCharacters = CheekArray(strArray);
   string[] newArray = CreateArray2(strArray, ThreeCharacters);
   ShowArrayText(newArray);
}

string[] CreateArray1()
{
   string[] array1 = new string[size];
        
      for(int i = 0; i < array1.Length; i++)
      {
         Console.Write($"Enter text the rows {i + 1}: ");
         array1[i] = Console.ReadLine();     
      }
    
return array1; 
}

int CheekArray(string[] array)
{
   int count = 0;
   for(int i = 0; i < array.Length; i++)
      {
      if(array[i].Length <= 3)
         {
            count++; 
         }
      }

return count;    
}

string[] CreateArray2(string[] array, int size)
{
   string[] array2 = new string[size];

      for(int i = 0; i < array.Length; i++)
      {
         if(array[i].Length <= 3)
         {
            array2[array2.Length - size] = array[i];
            size--;
         }
      }
    
return array2; 
}

void ShowArrayText(string[] array)
{
   Console.Write("[ ");
   for (int i = 0; i < array.Length; i++)
      if(array[i] == "")
      {
         Console.Write("");
      }
      else
      {  
         Console.Write($"\"{array[i]}\" ");
      }

Console.Write($"]");
}