# Prepare for challenge
Use Visual Studio Code to develop update the Contoso Pets adoption C# console application. 
The application already creates sample data on pets available for adoption, and is able to display the pet's description information. 
The application provides searching with a single term within the description data for each dog. 
The main feature addition is search with multiple terms. 
The secondary improvement is to the "search status" animation and includes adding a search countdown in the animation.
## Project specification overview
Update the existing Contoso Pets starter application to include multiple term search and improved "search status" animation features:
### Add dog attribute multi-term search
Gather user input for the pet characteristic multiple term search

- Users need to provide search terms separated by commas
- Store the search terms in an array and sort the terms alphabetically

Within the animals array loop that identifies "dogs":

- Iterate through the search terms to search each dog's description
- Search the combined description for a term match
- Output each dog's description where there's one or more terms matched

After exiting the "search Animals" array loop that identifies dogs:

- If no dogs were a match for any of the users provided search terms, output a no dogs matched message.
### Add "search status" improvements
Update the animation

- Adjust the searchingIcons array to resemble a spinning dial
- Adjust the animation loop so the animation shows a numeric countdown from two to zero (`2.., 1.., 0..`)
### Starter code
The starter code project for this challenge project module includes a Program.cs file that provides the following code features:

- The code declares variables used to collect and process pet data and menu item selections

- The code declares the ourAnimals array

- The code uses a for loop around an if-elseif-else construct to populate the ourAnimals array with a sample dataset

- The code displays the following main menu options for user selection:
```
1. List all of our current pet information
2. Display all dogs with a specified characteristic

Enter menu item selection or type "Exit" to exit the program
```
- The application menu code reads the user's menu item selection and displays a message echoing their selection

- Case 1: "List all of our current pet information" displays the sample data for all animals (two dogs and two cats)

- Case 2: "2. Display all dogs with a specified characteristic" is the primary area where new functionality code is added
  - Under Case 2, the starter code identifies dogs and searches for a single user input term
  - Before you search each dog, the console shows a simple "animation" that simulates a status for searching occurring
 
Your goal is to update the existing code to develop key features requested by your team:

- Add dog multiple attribute search
- Update search animation

Use Visual Studio Code as your development environment, and test your application at each stage of your development process.
