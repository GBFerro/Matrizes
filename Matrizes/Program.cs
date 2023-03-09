int[,] mat = new int[5, 5];

for (int linha = 0; linha < 5; linha++)
{
    for (int col = 0; col < 5; col++)
    {
        mat[linha, col] = linha * col;
    }
}

for (int linha = 0; linha < 5; linha++)
{
    for (int col = 0; col < 5; col++)
    {
        Console.Write(mat[col, linha] + " ");
    }
    Console.WriteLine("\n");
}

for (int i = 0, j = 4; i < 5; i++)
{
    Console.Write(mat[i, j]+" ");
    j--;
}