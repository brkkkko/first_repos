int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

int n = array.Length;
int find = 4;

int i = 0;

while (i < n)
{
    if (array[i] == find)
    {
        Console.WriteLine(i);
        break;
    }
    i++;
}