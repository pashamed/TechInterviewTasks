
int result;
result = FibRecursion(9);
//result = FibMemoization(9);
//result = FibItterative(9);
//result = FibBinet(9);

Console.WriteLine(result);


//simpel recursion, time complexity O(2^n), space complexity O(n) for n > 1
int FibRecursion(int n)
{
    if (n <= 1)
    {
        return n;
    }
    else
    {
        return (FibRecursion(n - 1) + FibRecursion(n - 2));
    }
}

//improved recursive itteration using top-down(memoization) dynamic programming approach,  time complexity O(n), space complexity O(n)
int FibMemoization(int n, int[] memo = null)
{
    if (n <= 1)
    {
        return n;
    }
    if (memo == null)
    {
        memo = new int[n + 1];
    }
    if (memo[n] == 0)
    {
        memo[n] = FibMemoization(n - 1, memo) + FibMemoization(n - 2, memo);
    }
    return memo[n];
}

//calculating fibonacci with itterative approach, time complexity O(n), space complexity O(1)
int FibItterative(int n)
{
    if (n <= 1)
    {
        return n;
    }
    int x = 0, y = 1;
    for (int i = 2; i < n; i++)
    {
        int tmp = x + y;
        x = y;
        y = tmp;
    }
    return x + y;
}

//calculating fibonacci number using Binet's formula, based on golden ratio constant. Time complexity O(log n), space complexity O(1)
int FibBinet(int n)
{
    double phi = (1 + Math.Sqrt(5)) / 2;
    return (int)Math.Round(Math.Pow(phi, n) / Math.Sqrt(5));
}

