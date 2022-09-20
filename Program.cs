string[] CreateArray(string[] array, int leng)
{
    int rows = 0;
    int[] index = new int[array.Length];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (String.IsNullOrEmpty(array[i]) == true)
        {
            rows++;
            index[j] = i;
            j++;
        }
        else if (array[i].Length <= leng)
        {
            rows++;
            index[j] = i;
            j++;
        }
    }
    string[] result = new string[rows];
    {
    if (rows > 0)
    {
        for (int i = 0; i < rows; i++)
        {
            result[i] = array[index[i]];
        }
    }
    return result;
    }
}

void ShowArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.WriteLine(arr[i] + " ");
}

string[] arrayString = {"abc", "de", "fghj", "klm", "noprs", "t"};
int countChar = 3;

ShowArray(CreateArray(arrayString, countChar));