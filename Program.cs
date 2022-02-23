string[] array = {"Hello", "2", "world", ":-)"};

string[] newarray (string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }

    string[] newarray = new string [count];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarray[j] = array[i];
            j++;
        }
    }
    return newarray;
}

void PrintArray(string[] array)           
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}
PrintArray(array);
PrintArray(newarray(array)); 