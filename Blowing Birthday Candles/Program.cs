using System;

string input = "1321";
string blownInput = "";

int moveCounter = 1;

// create blown string of input
for (int i = 0; i < input.Length; i++)
{
    blownInput += "0";
}

Console.WriteLine($"Input: \"{input}\"\n");

while(input != blownInput) BlowCandles();

void BlowCandles()
{
	string remainingCandles = input.TrimStart('0');

	// get next three or less candles and blow them
	string nextCandles = remainingCandles.Substring(0, (remainingCandles.Length > 3) ? 3 : remainingCandles.Length);
	int[] candlesToBlow = new int[nextCandles.Length];
	for (int i = 0; i < candlesToBlow.Length; i++)
	{
		string digit = nextCandles.Substring(i, 1);
		candlesToBlow[i] = Int32.Parse(digit);
		if (candlesToBlow[i] != 0) candlesToBlow[i]--;
	}

	string blownCandles = "";

	foreach (int candle in candlesToBlow)
	{
		blownCandles += Convert.ToString(candle);
	}

	string trimmedCandles = input.Remove(input.Length - remainingCandles.Length);
	string leftoverCandles = input.Substring(input.IndexOf(nextCandles)+nextCandles.Length);
	string foundCandlesToBlow = $"{trimmedCandles}({nextCandles}){leftoverCandles}";
	string candlesAfterBlowing = $"{trimmedCandles}{blownCandles}{leftoverCandles}";

	Console.WriteLine($"Move {moveCounter++} | \"{foundCandlesToBlow}\" -> \"{candlesAfterBlowing}\"");

	input = candlesAfterBlowing;
}