Console.WriteLine("My very first commit");

int[] table = [3, 5, 15, 10];

Console.WriteLine(average(table));
Console.WriteLine(maximum(table));
Console.WriteLine(minimum(table));
Console.WriteLine(sum(table));
static int average(int[] values)
{
    int sum = 0;

    foreach (int i in values)
    {
        sum += i;
    }
    
    int avg = sum / values.Length;
    return avg;
}

static int maximum(int[] values)
{
    int max = 0;

    foreach (int i in values)
    {
        if (max < i)
            max = i;
    }
    return max;
}

static int minimum(int[] values)
{
    int min = 2147483647;

    foreach (int i in values)
    {
        if (min > i)
            min = i;
    }
    return min;
}

static int sum(int[] values)
{
    int sum = 0;

    foreach (int i in values)
    {
        sum += i;
    }

    return sum;
}