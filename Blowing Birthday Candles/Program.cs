using System;

// Console.WriteLine("Input: ");
// string input = Console.ReadLine();
// Console.WriteLine();

string input = "1321";

char blownCandle = '0';

bool candlesBlownOut = false;

// make a char array out of input
char[] candles = new char[input.Length];
char[] nextThreeCandles = new char[3];

candles = input.ToCharArray();

Console.WriteLine($"Input: \"{input}\"");

// blow candles in a loop until they are blown out
while (!candlesBlownOut)
{
    // find next not blown candle
    int blownCandleLocation = input.IndexOf(blownCandle);

    if (blownCandleLocation == -1)
    {
        // get next three candles in a string
    }
    else
    {
        // keep looking for the candle
    }

    Console.WriteLine(nextThreeCandles);
}

bool AreCandlesExntinguished(string currentStateOfCandles)
{
    
    return candlesBlownOut;
}