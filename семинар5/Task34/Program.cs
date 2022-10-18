Console.Write("Введите кол-во эл-тов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int result = 0;
InputArray(array);
Console.Write($"массив:[{string.Join(", ", array)}] ");
ReleaseArray(array);

void InputArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
    array[i] = new Random().Next(100,1000);
}
 void ReleaseArray(int[] array)
 {
    for(int i = 0; i<array.Length; i++)
    if(array[i]%2==0)
    result ++;
 }
  
   
  Console.Write(result);

