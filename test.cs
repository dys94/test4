string[] array1 = new string[] { "123", "23", "hello", "world", "res" };
string[] array2;

void SecondArrayWithIF(string[] array1)
{

    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            count++;
        }
    }
    array2 = new string[count];
    count = 0;

    for (int i = 0;i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        
        Console.Write(array[i] + " ");
        
    }

}
SecondArrayWithIF(array1 );
PrintArray(array2);
