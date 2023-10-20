int[] array = { 19, 27, 33, 42, 53, 66, 71, 8 };

int n = array.Length;

int find = 71;
int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
    }

    index++;
}