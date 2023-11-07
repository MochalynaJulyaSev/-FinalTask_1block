
string[] basicArray =  {"sheep", "hi", "world", "cat", "dog", "hamster"};

int GetSizeNewArray(string[] array) 
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string[] FillResultArray(string[] array, int size)
{
    string[] result = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[result.Length - size] = array[i];
            size--;
        }
    }
    return result;
}