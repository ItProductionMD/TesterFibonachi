// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using TesterFibonacci;

Console.WriteLine("Fibonacci Test");
while (true)
{
    Console.WriteLine("Input number:");
    var numberString = Console.ReadLine();
    Console.WriteLine("Input cycle");
    var cycleString = Console.ReadLine();
    int number = int.Parse(numberString);
    int cycles = int.Parse(cycleString);
    int total = 0;
    int f = 0;
    //OOP style
    var calculator = new FibonacciCalculator(number, cycles);
    calculator.Run();
    calculator.PrintReport();
    //procedure style
    var stopWatch = new Stopwatch();
    stopWatch.Start();
    for (int i = 0; i < cycles; ++i)
    {
        f = Fibo(number);
        total += f;
    }
    stopWatch.Stop();
    Console.Write($"\n{number}-th Fibonacci number is {f}\n" +
        $"cycles {total}\n" +
        $"time elapsed with function:{stopWatch.ElapsedMilliseconds} ms\n");

    Console.WriteLine("\nPress Enter to Continue or 'exit' to end the program.");
    if (Console.ReadLine()?.Trim().ToLower() == "exit")
        break;

}


static bool Less(int left, int right)
{
    return left < right;
}

static int Sub(int left, int right)
{
    return left - right;
}

static int Add(int left, int right)
{
    return left + right;
}

static int Fibo(int v)
{
    if (Less(v, 2))
    {
        return 1;
    }
    return Add(Fibo(Sub(v, 1)), Fibo(Sub(v, 2)));
}

