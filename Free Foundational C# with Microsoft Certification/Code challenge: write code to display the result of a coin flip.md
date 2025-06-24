# Code challenge: write code to display the result of a coin flip

Challenge requirements:
  1. Use the `Random` class to generate a value.
  
      Consider the range of numbers that is required.
  2. Based on the value generated, use the conditional operator to display either `heads` or `tails`.

     There should be a 50% chance that the result is either heads or tails.
  3. Your code should be easy to read, but with as few lines as possible.

     You should be able to accomplish the desired result in three lines of code.

## Solution
```
Random coin = new Random();

int coinFlip = coin.Next(0,2);

Console.WriteLine(coinFlip == 0 ? "Heads" : "Tails");
```
