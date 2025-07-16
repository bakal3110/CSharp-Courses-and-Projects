# Write code to reverse each word in a message
1. Select and delete all code lines in the Visual Studio Code Editor.
2. Update your code in the Visual Studio Code Editor as follows:
```csharp
string pangram = "The quick brown fox jumps over the lazy dog";
```
3. Write the code necessary to reverse the letters of each word in place and display the result.

In other words, don't just reverse every letter in the variable pangram. Instead, you need to reverse just the letters in each word, but print the reversed word in its original position in the message.

Your code must produce the following output:
```
ehT kciuq nworb xof spmuj revo eht yzal god
```
> [!Important]
> This is a particularly difficult challenge.
> You will need to combine many of the concepts you learned in this exercise, including the use of the `Split()`, `ToCharArray()`, `Array.Reverse()`, and `String.Join()`. 
> You'll also need to create multiple arrays, and at least one iteration statement.
## Solution
```csharp
string pangram = "The quick brown fox jumps over the lazy dog";

// first split string into words, then make a char array of every word,
// reverse char order for each word, convert char array to a string,
// save inverted word in original string array

string[] wordsInPangram = pangram.Split(' ');

for (int i = 0; i < wordsInPangram.Length; i++)
{
	char[] wordChar = wordsInPangram[i].ToCharArray();
	Array.Reverse(wordChar);
	string invertedWord = new string(wordChar);
	wordsInPangram[i] = invertedWord;	
}
string finalResult = String.Join(' ', wordsInPangram);
Console.WriteLine(finalResult);
```
