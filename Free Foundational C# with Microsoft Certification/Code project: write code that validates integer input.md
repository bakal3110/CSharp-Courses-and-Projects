# Write code that validates integer input
Here are the conditions that your first coding project must implement:

- Your solution must include either a `do-while` or `while` iteration.

- Before the iteration block: your solution must use a `Console.WriteLine()` statement to prompt the user for an integer value between 5 and 10.

- Inside the iteration block:
  - Your solution must use a Console.ReadLine() statement to obtain input from the user.
  - Your solution must ensure that the input is a valid representation of an integer.
  - If the integer value isn't between 5 and 10, your code must use a `Console.WriteLine()` statement to prompt the user for an integer value between 5 and 10.
  - Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.
- Below (after) the iteration code block: your solution must use a `Console.WriteLine()` statement to inform the user that their input value has been accepted.
## Solution
```csharp
string? readResult;

int numericValue = 0;

bool validNumber = false;
bool validEntry = false;

Console.WriteLine("Enter an integer value between 5 and 10:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (!(validNumber = int.TryParse(readResult, out numericValue)))
		{
			Console.WriteLine("Sorry, you entered an invalid number, please try again.");
		}
		else
		{
			if (numericValue <= 5 || numericValue >= 10)
			{
				Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
				continue;
			}
			validEntry = true;
		}
    }
} while (validEntry == false);

Console.WriteLine($"Your input value ({numericValue}) has been accepted.");
```
