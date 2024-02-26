//Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

string [] CreateArray(int size)
{
    string [] array = new string[size];
    for (int i=0; i<array.Length; i++)
    {
        array[i] = Console.ReadLine();    
    }
    return array;
}
Console.WriteLine("Введите количество  ");
int n = Convert.ToInt32(Console.ReadLine());
string [] array = CreateArray(n);
Console.WriteLine($"Исходный массив: [{string.Join("; ", array)}]");

///* 
string [] NewArray(string [] original_array)
{
   //string [] new_array = new string[original_array.Length];
   int count=0;  
   for (int i=0; i<original_array.Length; i++)
   {    
    if (original_array[i].Length<4)
    {
        count++;
    }
   }
string [] new_array = new string[count];
int j=0;
for (int i=0; i<original_array.Length; i++)
   {    
    if (original_array[i].Length<4)
    {
        new_array[j]=original_array[i];
        j++;
    }    
   }
   return new_array;
}
string [] new_array=NewArray(array);
Console.WriteLine($"Модифицированный массив: [{string.Join("; ", new_array)}]");