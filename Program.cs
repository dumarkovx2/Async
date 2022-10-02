using System;
using System.Threading.Tasks;


public static class MyClass
{
	public static async Task Main()
	{
        await MyClass.Linger(4); // sync. Might catch 2 threads. anti-pattern.

        var t3 = MyClass.Linger(3); // async
        var t2 = MyClass.Linger(2); // async
        var t1 = MyClass.Linger(1); // async

        await t1; // wait for completion
        Console.WriteLine($"{DateTime.Now} 1 completed");
        await t3; // wait for completion
        Console.WriteLine($"{DateTime.Now} 3 completed");
        await t2; // wait for completion
        Console.WriteLine($"{DateTime.Now} 2 completed");
	}

    public static async Task<int> Linger(int delay_sec)
    {
        Console.WriteLine($"{DateTime.Now} {delay_sec} Start");
        var t = Task.Delay(delay_sec * 1000);
        await t;
        Console.WriteLine($"{DateTime.Now} {delay_sec} End");
        return delay_sec;
    }    
}

