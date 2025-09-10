using System;

Console.WriteLine("Enter integer 'n' for 'n > 0'");
string readResult = Console.ReadLine();
int arraySize = Int32.Parse(readResult) + 1;

// program here
int[] outputArray = CreateArray(arraySize);
int[,] solutions = FindAB(outputArray);
PrintSolutions(solutions);


// functions here				 
int[] CreateArray(int n)
{
	int[] outputArray = new int[arraySize];
	
	for (int i=0; arraySize > i; i++)
	{
		outputArray[i] = i;
	}
	return outputArray;
}

int Sum(int[] inputArray)
{
	int sum = 0;
	foreach (int number in inputArray) sum += number;
	return sum;
}

int[,] FindAB(int[] inputArray)
{
	int product = 0;	
	int amountOfSolutions = 0;

	int[,] combinations = new int[inputArray.Length, 2];
	for (int i=0; i<inputArray.Length; i++)
	{
		combinations[i,0] = 0;
		combinations[i,1] = 0;
	}
	
	foreach (int a in inputArray)
	{
		if (a != 0)
		{
			int arraySum = Sum(inputArray);
			arraySum -= a;
			int originalSum = arraySum;

			for (int i=0; i < inputArray.Length; i++)
			{
				if (i != 0 && i != a)
				{
					arraySum -= i;
					product = a*i;

					if (arraySum == product)
					{
						combinations[amountOfSolutions,0] = a;
						combinations[amountOfSolutions,1] = i;
						amountOfSolutions += 1;
					}
					arraySum = originalSum;
				}
			}
		}
	}
	
	int[,] solutions = new int[amountOfSolutions,2];
	for (int i=0; i<(amountOfSolutions); i++)
	{
		solutions[i, 0] = combinations[i, 0];
		solutions[i, 1] = combinations[i, 1];
	}
	
	return solutions;
}

void PrintSolutions(int[,] solutions)
{
	int solutionsWidth = solutions.GetLength(0);
	for (int i=0; i<solutionsWidth; i++)
	{
		Console.WriteLine($"[{solutions[i, 0]}, {solutions[i, 1]}]");
	}
}
