//22 var high lvl
int n = 4; 
int[,] mas = new int[n, n]; 
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i == j) 
            mas[i, j] = 1;
        else if (i < j) 
            mas[i, j] = 0;
        else 
            mas[i, j] = 2;
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(mas[i, j] + " ");
    }
    Console.WriteLine();
}

