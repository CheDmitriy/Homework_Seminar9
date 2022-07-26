/*int Count (int n)  // Задача 64
{
    if (n/10!=0)

        return 1 + Count(n/10);
    else

        return 1;
}

Console.WriteLine(Count(0));*/


Console.WriteLine("Enter the initial number m:");  // Задача 66
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the initial number n:");
int n = Convert.ToInt32(Console.ReadLine());

void SumofNumber (int m, int n, int sum)
{
    if (m > n) 
    {
        Console.WriteLine($"The sum of natural elements in the range from m to n: {sum}"); 
        return;
    }
    sum = sum + (m++);
    SumofNumber(m, n, sum);
}

SumofNumber(m, n, 0);