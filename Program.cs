﻿int[] arr = {1, 6, 7, 6, 9, 8, 2, 3, 4, 5};

void PrintArray (int [] array)
{
    int count = array.Length;

    for (int i=0 ; i<count; i++)
    {
        Console.Write ($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray (arr);

void SelectionSort (int [] array)
{
    for (int i= 0; i < array.Length; i++)
    {
        int minPosition = i;
        for (int j= i + 1; j < array.Length -1 ; j++)
        {
            if(array [j] > array[minPosition]) minPosition = j;
        }
        int temporary = array [i];
        array [i] = array [minPosition];
        array [minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort (arr);

PrintArray (arr);