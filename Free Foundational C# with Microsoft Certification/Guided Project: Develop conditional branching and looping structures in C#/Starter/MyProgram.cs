				// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables to store numeric values for each entry in ourAnimals array
int numAnimalID = 0;
int numAnimalSpecies = 1;
int numAnimalAge = 2;
int numAnimalNickname = 3;
int numAnimalPhysicalDescription = 4;
int numAnimalPersonalityDescription = 5;

// variable supporting modifying data 
int animalToModify = 0;


// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "?";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

do
{
    // display the top-level menu options

    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

	Console.WriteLine("");
    Console.WriteLine($"You selected menu option {menuSelection}.");
    Console.WriteLine("Press the Enter key to continue");

    // pause code execution
    readResult = Console.ReadLine();

    switch (menuSelection)
    {
        case "1":
            // List all of our current pet information
            Console.WriteLine("List of our animals:");
			Console.WriteLine("");
			
            for (int i = 0; i < maxPets; i++)
            {
				if (ourAnimals[i,0] != "ID #: ")
				{
					Console.Write(i+1);
					Console.WriteLine(".");
					for (int j = 0; j < 6; j++)
					{
						Console.WriteLine($"\t{ourAnimals[i,j]}");
					}
					Console.WriteLine("\n\n");
				}
            }
            break;

        case "2":
            // Add a new animal friend to the ourAnimals array
            string anotherPet = "y";
			int petCount = 0;

            // count animal number
			for (int i = 0; i < maxPets; i++)
			{
				if (ourAnimals[i, 0] != "ID #: ")
				{
					petCount += 1;
				}
			}

			if (petCount < maxPets)
			{
				Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");

                bool newValidEntry = false;
                // get species (cat or dog) - string animalSpecies is a required field 
                do
                {
                    Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalSpecies = readResult.ToLower();
                        if (animalSpecies != "dog" && animalSpecies != "cat")
                        {
                            //Console.WriteLine($"You entered: {animalSpecies}.");
                            newValidEntry = false;
                        }
                        else
                        {
                            newValidEntry = true;
                        }
                    }
                } while (newValidEntry == false);

                // build the animal the ID number - for example C1, C2, D3 (for Cat 1, Cat 2, Dog 3)
				animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

                // get the pet's age. can be ? at initial entry.
				do
				{
					int petAge;
					Console.WriteLine("Enter the pet's age or enter ? if unknown");
					readResult = Console.ReadLine();
					if (readResult != null)
					{
						animalAge = readResult;
						if (animalAge != "?")
						{
							newValidEntry = int.TryParse(animalAge, out petAge);
						}
						else
						{
							newValidEntry = true;
						}
					}
				} while (newValidEntry == false);

                // get the pet's nickname. animalNickname can be blank.
                do
                {
                    Console.WriteLine("Enter a nickname for the pet");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalNickname = readResult.ToLower();
                        if (animalNickname == "")
                        {
                            animalNickname = "tbd";
                        }
                    }
                } while (animalNickname == "");

                // get a description of the pet's physical appearance/condition - animalPhysicalDescription can be blank.
                do
                {
                    Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPhysicalDescription = readResult.ToLower();
                        if (animalPhysicalDescription == "")
                        {
                            animalPhysicalDescription = "tbd";
                        }
                    }
                } while (animalPhysicalDescription == "");

                // get a description of the pet's personality - animalPersonalityDescription can be blank.
                do
                {
                    Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPersonalityDescription = readResult.ToLower();
                        if (animalPersonalityDescription == "")
                        {
                            animalPersonalityDescription = "tbd";
                        }
                    }
                } while (animalPersonalityDescription == "");

                // store the pet information in the ourAnimals array (zero based)
                ourAnimals[petCount, 0] = "ID #: " + animalID;
                ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                ourAnimals[petCount, 2] = "Age: " + animalAge;
                ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

				while (anotherPet == "y" && petCount < maxPets)
                {
                    // increment petCount (the array is zero-based, so we increment the counter after adding to the array)
                    petCount = petCount + 1;

                    // check maxPet limit
                    if (petCount < maxPets)
                    {
                        // another pet?
                        Console.WriteLine("Do you want to enter info for another pet (y/n)");
                        do
                        {
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                anotherPet = readResult.ToLower();
                            }

                        } while (anotherPet != "y" && anotherPet != "n");
                    }
                }
			}

			if (petCount >= maxPets)
            {
                Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                Console.WriteLine("Press the Enter key to continue.");
			    readResult = Console.ReadLine();
            }           
			break;

        case "3":
			// Ensure animal ages and physical descriptions are complete
			
            //Console.WriteLine("Challenge Project - please check back soon to see progress.");
            //Console.WriteLine("Press the Enter key to continue.");
            //readResult = Console.ReadLine();

            for (int i = 0; i < maxPets; i++)
            {
				int petAge = 0;
				bool newValidEntry = false;
				
                if (ourAnimals[i,0] != "ID #: ")
                {
					// checking if age entry is incomplete
					if ( !(int.TryParse(ourAnimals[i,2].Substring(5), out petAge)) )
					{
						// display animal ID and age
						Console.WriteLine();
						Console.WriteLine(ourAnimals[i,0]);
						Console.WriteLine(ourAnimals[i,2]);
						
						// prompt user to update age entry
						Console.WriteLine();
						Console.WriteLine("Enter pet's age or \"?\" if unknown.");
						do
						{						
							readResult = Console.ReadLine();
							
							// checking if entry is not empty
							if (readResult != null)
							{
								// check if entry is a number
								newValidEntry = int.TryParse(readResult, out petAge);
							}
						} while (readResult != "?" && newValidEntry == false);
						
						ourAnimals[i,2] = "Age: " + readResult;
						
						Console.WriteLine();
						Console.WriteLine("Updated:\n" + ourAnimals[i,2]);
						
						Console.WriteLine("Press Enter to continue...");
                    	readResult = Console.ReadLine();
					}
					
					// check for missing physical description

					// a reminder line of code to locate a char
					// periodLocation = myString.IndexOf('.');
					
					if (ourAnimals[i,4] == "Physical description: ")
					{
                        newValidEntry = false;

                        Console.WriteLine();
						Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");

                        do
                        {
                            readResult = Console.ReadLine();

                            if (readResult != null)
                            {
                                if (readResult != "")
                                {
                                    ourAnimals[i,4] = "Physical description: " + readResult.TrimStart(' ').ToLower();
                                    newValidEntry = true;
                                }
                            }
                        } while (newValidEntry == false);
					}
                }
            }

            Console.WriteLine();
            Console.WriteLine("Age and physical description fields are complete for all of our friends.");
            Console.WriteLine();
            Console.WriteLine("Press the Enter key to continue.");
			readResult = Console.ReadLine();
			
            break;

       case "4":
            // 4. Ensure animal nicknames and personality descriptions are complete

            // main loop for checking each pet
            for (int i = 0; i < maxPets; i++)
            {
                bool newValidEntry = false;
				
				if (ourAnimals[i, 0] != "ID #: ")
				{
					// checking for empty Nickname entry
					if (ourAnimals[i, 3] == "Nickname: ")
					{
						Console.WriteLine("Add Nickname for the pet");
						Console.WriteLine(ourAnimals[i,0]);
						readResult = Console.ReadLine();
						// checking if entry is valid
						do
						{
							if (readResult != null)
							{
								if (readResult != "")
								{
									ourAnimals[i,3] = "Nickname: " + readResult.TrimStart(' ').ToLower();
									newValidEntry = true;
								}
							}
						} while (newValidEntry == false);
					}

					newValidEntry = false;

					// checking for empty Personality entry
					if (ourAnimals[i, 5] == "Personality: ")
					{
						Console.WriteLine("Add Personality description for the pet");
						Console.WriteLine(ourAnimals[i,5]);
						readResult = Console.ReadLine();
						// checking if entry is valid
						do
						{
							if (readResult != null)
							{
								if (readResult != "")
								{
									ourAnimals[i,5] = "Personality: " + readResult.TrimStart(' ').ToLower();
									newValidEntry = true;
								}
							}
						} while (newValidEntry == false);
					}
				}
            }

            // Summary message after all entries are complete
            Console.WriteLine();
            Console.WriteLine("Nickname and personality description fields are complete for all of our friends.");
            Console.WriteLine();
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "5":
            // 5. Edit an animal’s age
            //Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");

            bool foundAnimal = false;
            bool validEntry = false;
            
            //find all registered animals
            Console.Write("Animal ID:\t");
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i,numAnimalID] != "ID #: ")
                {
                    foundAnimal = true;
                    // display all registered animals' ID
                    Console.Write($"{ourAnimals[i,numAnimalID].Substring(6)}\t\t");
                }
            }

            Console.WriteLine();
            Console.Write("Animal age:\t");

            if (foundAnimal)
            {
                // display all registered animals' age
                for (int i = 0; i < maxPets; i++)
                {
                    if (ourAnimals[i,numAnimalID] != "ID #: ")
                    { 
                        Console.Write($"{ourAnimals[i,numAnimalAge].Substring(5)}\t\t");
                    }
                }

                // ask which animal ID user wants to edit
				Console.WriteLine();
                Console.WriteLine("Enter ID of an animal to change its age, then confirm choice by pressing Enter:");
				string comparison;
                do
                {
                    readResult = Console.ReadLine();
					comparison = readResult.ToLower();
                    if (readResult != null)
                    {
                        for (int i = 0; i < maxPets; i++)
                        {
                            // if input ID matches an ID of any animal, save that ID into variable
                            if (comparison == ourAnimals[i,numAnimalID].Substring(6))
                            {
                                animalToModify = i;
                                validEntry = true;
                                break;
                            }
                        }
                    }
                } while (validEntry == false);

                // ask user for age update

                int intAnimalAge = 0;
                validEntry = false;
                Console.WriteLine($"Enter new age for {ourAnimals[animalToModify,numAnimalID].Substring(6)}:");
                do
                {
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        if (int.TryParse(readResult, out intAnimalAge) && intAnimalAge >= 0)
                        {
                            validEntry = true;
							ourAnimals[animalToModify,numAnimalAge] = "Age: " + intAnimalAge.ToString();
                        }
                    }
                } while (validEntry == false);

                // Display updated age
				Console.WriteLine();
				Console.WriteLine($"New age for {ourAnimals[animalToModify,numAnimalID].Substring(6)} is {intAnimalAge}");
            }
            else
            {
                Console.WriteLine("No animals.");
            }


            Console.WriteLine("End of the section. Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "6":
            // 6. Edit an animal’s personality description
            //Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");



            Console.WriteLine("End of the section. Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "7":
            // 7. Display all cats with a specified characteristic
            //Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");



            Console.WriteLine("End of the section. Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "8":
            // 7. Display all dogs with a specified characteristic
            //Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");



            Console.WriteLine("End of the section. Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        default:
            break;
    }
} while (menuSelection != "exit");

