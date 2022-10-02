using System;
using System.Threading.Tasks;


public static class MyClass
{
	public static async Task Main()
	{
        var t3 = MyClass.Linger(3);
        var t2 = MyClass.Linger(2);
        var t1 = MyClass.Linger(1);

        await t1;
        Console.WriteLine($"{DateTime.Now} 1 completed");
        await t3;
        Console.WriteLine($"{DateTime.Now} 3 completed");
        await t2;
        Console.WriteLine($"{DateTime.Now} 2 completed");
	}

    public static async Task<int> Linger(int delay_sec)
    {
        Console.WriteLine($"{DateTime.Now} {delay_sec} Start");
        await Task.Delay(delay_sec * 1000);
        Console.WriteLine($"{DateTime.Now} {delay_sec} End");
        return delay_sec;
    }    
}

