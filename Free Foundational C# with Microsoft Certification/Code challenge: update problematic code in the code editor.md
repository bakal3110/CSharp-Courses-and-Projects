# Variable scope challenge
In this challenge, you'll use what you've learned about code blocks and variable scope to fix the poorly written code sample provided. 
There are many improvements that you can make. Good luck!

Starting code
```csharp
int[] numbers = { 4, 8, 15, 16, 23, 42 };

foreach (int number in numbers)
{
    int total;

    total += number;

    if (number == 42)
    {
       bool found = true;

    }

}

if (found) 
{
    Console.WriteLine("Set contains 42");

}

Console.WriteLine($"Total: {total}");
```
Starting Output
```
(17,5): error CS0103: The name 'found' does not exist in the current context
(23,29): error CS0103: The name 'total' does not exist in the current context
(7,5): error CS0165: Use of unassigned local variable 'total'
```
Desired Output
```
Set contains 42
Total: 108
```
Optimize your code for readability.

Depending on the amount of whitespace that you include and some other factors, you should have around 17 lines of code.
## Solution
```csharp
int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;

foreach (int number in numbers)
{
    total += number;

    if (number == 42)
        Console.WriteLine("Set contains 42");
}

Console.WriteLine($"Total: {total}");
```
