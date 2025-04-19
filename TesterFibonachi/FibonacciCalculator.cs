using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TesterFibonacci;

public class FibonacciCalculator
{
    public int Input { get; }
    public int Cycles { get; }

    public int LastResult { get; private set; }
    public int Total { get; private set; }
    public long ElapsedMilliseconds { get; private set; }

    public FibonacciCalculator(int input, int cycles)
    {
        Input = input;
        Cycles = cycles;
    }

    public void Run()
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();

        Total = 0;
        for (int i = 0; i < Cycles; ++i)
        {
            LastResult = Fibo(Input);
            Total += LastResult;
        }

        stopwatch.Stop();
        ElapsedMilliseconds = stopwatch.ElapsedMilliseconds;
    }

    private int Fibo(int v)
    {
        if (v < 2)
            return 1;

        return Fibo(v - 1) + Fibo(v - 2);
    }

    public void PrintReport()
    {
        Console.Write($"\n{Input}-th Fibonacci number is {LastResult}\n" +
        $"cycles {Total}\n" +
        $"time elapsed with OOP:{ElapsedMilliseconds} ms\n");
    }
}

