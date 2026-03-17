Console.WriteLine("My very first commit");


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
    int min = 0;

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