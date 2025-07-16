#Parse a string of orders, sort the orders and tag possible errors
Data comes in many formats. In this challenge you have to parse the individual "Order IDs", and output the "OrderIDs" sorted and tagged as "Error" if they aren't exactly four characters in length.

1. Select and delete all code lines in the Visual Studio Code Editor.
2. In Visual Studio Code, add the following code to get the data for the challenge:
```csharp
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
```
3. Notice in the previous code, the orderStream variable contains a string of multiple Order IDs separated by commas.
4. Add code below the previous code to parse the "Order IDs" from the string of incoming orders and store the "Order IDs" in an array.
5. Add code to output each "Order ID" in sorted order and tag orders that aren't exactly four characters in length as "- Error".
6. Save and run your code.

   Your code must produce the following output:
```
A345
B123
B177
B179
C15     - Error
C234
C235
G3003   - Error
```
## Solution
```csharp
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orders = orderStream.Split(',');
Array.Sort(orders);

for (int i = 0; i < orders.Length; i++)
{
	char[] letters = orders[i].ToCharArray();

	if (letters.Length == 4)
	{
		Console.WriteLine(orders[i]);
	}
	else
	{
		Console.WriteLine(orders[i] + "\t- Error");
	}
}
```
