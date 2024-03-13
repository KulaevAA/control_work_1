//Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

string [] CreateArray(int size)   // функция создания исходного массива
{  
    string [] array = new string[size];
    Console.WriteLine("Введите строки через Enter");
    for (int i=0; i<array.Length; i++)
    {        
        array[i] = Console.ReadLine();     // заполняется массив значениями, вводимыми с клавиатуры   
    }
    return array;
}

Console.WriteLine("Введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());

string [] original_array = CreateArray(n);       //создали массив

string [] NewArray(string [] original_array)  // функция, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
{
int count=0;  
   for (int i=0; i<original_array.Length; i++)
   {    
    if (original_array[i].Length<4)
    {
        count++;                      // определяем размерность нового массива
    }
   }  
string [] new_array = new string[count];
int j=0;
for (int i=0; i<original_array.Length; i++)
   {    
    if (original_array[i].Length<4)      // если длина строки исходного массива меньше или равна 3 символам, то добавлем эту строку в новый массив
    {
        new_array[j]=original_array[i];
        j++;
    }    
   }
   return new_array;
}
string [] new_array = NewArray(original_array);

Console.WriteLine($"Исходный массив: [{string.Join("; ", original_array)}]");
Console.WriteLine($"Модифицированный массив: [{string.Join("; ", new_array)}]");

