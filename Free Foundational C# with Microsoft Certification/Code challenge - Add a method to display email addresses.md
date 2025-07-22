# Display email addresses
Your challenge is to create a method that displays the correct email address for both internal and external employees. You're given lists of internal and external employee names. An employee's email address consists of their username and company domain name.

The username format is the first two characters of the employee first name, followed by their last name. For example, an employee named "Robert Bavin" would have the username "robavin". The domain for internal employees is "contoso.com".

In this challenge, you're given some starting code. You must decide how to create and call a method to display email addresses.
# Code challenge: Add a method to display email addresses
In the code you start with, there are two arrays for internal and external employees. Remember, the domain for internal employees is "contoso.com" and the username for all employees is the first two characters of their first name, followed by their full last name.

Your challenge is to create a method that will display the email address of internal and external employees. The method should include an optional parameter for the domain name of external employees.

1. Ensure that you have an empty Program.cs file open in Visual Studio Code.

   If necessary, open Visual Studio Code, and then complete the following steps to prepare a Program.cs file in the Editor:
   - On the File menu, select Open Folder.
   - Use the Open Folder dialog to navigate to, and then open, the CsharpProjects folder.
   - In the Visual Studio Code EXPLORER panel, select Program.cs.
   - On the Visual Studio Code Selection menu, select Select All, and then press the Delete key.
2. Copy and paste the following code into the Visual Studio Code Editor.
  ```csharp
string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    // display internal email addresses
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    // display external email addresses
}
```
3. Update the code to use a method to display the email addresses according to the challenge specifications.

   Use what you've learned about using parameters and optional arguments to complete the update.
4. Verify that your code produces the following output:
```
robavin@contoso.com
sibright@contoso.com
kisinclair@contoso.com
aakamath@contoso.com
sadelucchi@contoso.com
siali@contoso.com
viashton@hayworth.com
codysart@hayworth.com
shlawrence@hayworth.com
davaldes@hayworth.com
```
## Solution
```csharp
using System;

string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{	
    // display internal email addresses
	DisplayEmailAddress(firstName: corporate[i, 0], lastName: corporate[i, 1]);
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    // display external email addresses
	DisplayEmailAddress(firstName: external[i, 0], lastName: external[i, 1], domain: externalDomain);
}

void DisplayEmailAddress(string firstName, string lastName, string domain = "contoso.com")
{
	string firstTwoLettersOfName = firstName.ToLower().Substring(0,2);
	lastName = lastName.ToLower();
	
	// email address: first two characters of their first name, followed by their full last name
	Console.WriteLine($"{firstTwoLettersOfName}{lastName}@{domain}");
}
```
