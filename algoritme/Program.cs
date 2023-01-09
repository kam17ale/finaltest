/* 
Написать программу, которая из имеющегося массива строк, формирует массив из строк, длина которых меньше или равна трем символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
ПРИМЕРЫ:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234","1567", "-2", "computer science"] -> ["-2"]
["Russia", "Demmark", "Kazan"] -> []
*/

// ВВОД ДАННЫХ ЗАДАЮ НА СТАРТЕ ВЫПОЛНЕНИЯ АЛГОРИТМА:
Console.Clear();
Console.WriteLine();
string[] FirstArray = new string[4] { "hello", "2", "world", ":-)" };
string[] SecondArray = new string[FirstArray.Length];
void SecondArrayWithIF(string[] FirstArray, string[] SecondArray)

{
int count = 0;
for (int i = 0; i < FirstArray.Length; i++)
{
if (FirstArray[i].Length <= 3)
{
SecondArray[count] = FirstArray[i];
count++;
}
}
}
Console.WriteLine("Ваш массив из строк: ");

void PrintArray(string[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write($"{array[i]} ");
}
Console.WriteLine();
}
SecondArrayWithIF(FirstArray, SecondArray);
PrintArray(SecondArray);
Console.WriteLine();
