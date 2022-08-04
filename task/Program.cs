using System;
using static System.Console;
Clear();
// Инициализация массивов
string[] arr1 = new string[5] {"78956", "Ho", "dog", "Hello", "pepsi"};
string[] arr2 = new string[arr1.Length];
FillArray(arr1, arr2);
PrintArray(arr2);
// Метод заполнения второго массива строками из первого <= 3-х элементам
void FillArray(string[] arr1, string[] arry2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        arr2[count] = arr1[i];
        count++;
        }
    }
}

