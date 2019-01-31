using System;

namespace candles
{
public class Program
{
	
	public static  void Main(string[]args)
	{
        int greatest = 0;
	    int count = 0;
		int[]allCandles = new int[]{2, 5, 3, 1 };
		int count = BirthdayCakeCounter(allCandles.Length, allCandles);
		Console.WriteLine("I can blow out {count} candles");
	}
	public static BirthdayCakeCounter(int length, int[] candles)
		{
			foreach(var candle in candles)
			{
			if (candle > greatest)
			{

				greatest = candles;

				count = 0;
			}
				if (candle == greatest)
				{
					count++;
				}
			}
		return count;
	}
}
}
