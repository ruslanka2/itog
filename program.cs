string[] array1 = new string[5] {"p", "ri", "hllo", "wo00rld", "vet"};
string[] array2 = new string[array1.Length];
void Mas(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintMas(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Mas(array1, array2);
PrintMas(array1);
PrintMas(array2);