using System;
using System.Threading.Tasks;


public class MyClass
{
	public static async Task Main()
	{
		var mc = new MyClass();
        var t3 = mc.Linger(3);
        var t2 = mc.Linger(2);
        var t1 = mc.Linger(1);

        await t1;
        Console.WriteLine($"{DateTime.Now} 1 completed");
        await t3;
        Console.WriteLine($"{DateTime.Now} 3 completed");
        await t2;
        Console.WriteLine($"{DateTime.Now} 2 completed");
	}
}


static class ExtensionMethods
{
    public static async Task<int> Linger(this MyClass mc, int delay_sec)
    {
        string name = nameof(mc);
        Console.WriteLine($"{DateTime.Now} {name} {delay_sec} Start");
        await Task.Delay(delay_sec * 1000);
        Console.WriteLine($"{DateTime.Now} {name} {delay_sec} End");
        return delay_sec;
    }
}