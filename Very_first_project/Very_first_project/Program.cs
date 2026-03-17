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