Console.Write("Введите кол-во эл-тов массива:  ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int number = 0;
int max = 0;
int min = 0;
InputArray(array);
Console.Write($"массив:[{string.Join(", ", array)}] ");
ReleaseArray(array);

void InputArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
    array[i] = new Random().Next(-100,100);
}


 void ReleaseArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    
      if (max < array[i])
    
      max = number + array[i];
    
      else if (min > array[i])
    
      min = number + array[i];
    
}

  Console.WriteLine(max-min);
