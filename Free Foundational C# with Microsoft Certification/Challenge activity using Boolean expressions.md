# Decision logic challenge
In this challenge, I implement decision logic based on a series of business rules.
The business rules specify the access that is granted to users based on their role-based permissions and their career level.
Code branches display a different message to the user depending on their permissions and level.

Starting code
```csharp
string permission = "Admin|Manager";
int level = 55;
```
Business Rules my solution must satisfy:
- If the user is an Admin with a level greater than 55, output the message: `Welcome, Super Admin user.`
- If the user is an Admin with a level less than or equal to 55, output the message: `Welcome, Admin user.`
- If the user is a Manager with a level 20 or greater, output the message: `Contact an Admin for access.`
- If the user is a Manager with a level less than 20, output the message: `You do not have sufficient privileges.`
- If the user isn't an Admin or a Manager, output the message: `You do not have sufficient privileges.`
## Solution
```csharp
string permission = "Admin|Manager";
int level = 55;

string messageNoPrivileges = "You do not have sufficient privileges.";

if (!permission.Contains("Admin") && !permission.Contains("Manager"))
{
    Console.WriteLine(messageNoPrivileges);
}
else if (!permission.Contains("Admin") && permission.Contains("Manager"))
{
    Console.WriteLine(level < 20 ? messageNoPrivileges : "Contact an Admin for access.");
}
else if (permission.Contains("Admin"))
{
    Console.WriteLine(level <= 55 ? "Welcome, Admin user." : "Welcome, Super Admin user");
}
```
