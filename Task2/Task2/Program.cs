

    Repeat("alma", 5);

static string Repeat(string word, int count)
{


    for (int i = 0; i < count; i++)
    {
        Console.Write(" " + word);
    }
    return word;
}