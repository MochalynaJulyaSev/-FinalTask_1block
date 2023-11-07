
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