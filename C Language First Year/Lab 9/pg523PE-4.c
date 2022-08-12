/* 

	Laquon Hamilton
	Lab 9 pg 523 PE 4
	2020-03-29

*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
#include <stdlib.h>
//begin our main function
int main()
{ 
	printf("\nProgram that updates a file containing pollen counts.\n\n");

	int oldestCount;
	int newestCount = 0;
	int totalCount = 0;
	int numberArray[10];
	int numberArray2[10];
	float oldAverage, newAverage;

	FILE *inFile;	
	FILE *outFile;	
	
	printf("Enter the next count: ");
	scanf("%d", &newestCount);

	inFile = fopen("oldpollens.txt", "r");//opens the file for reading
	
	if (inFile == NULL)//check if file exists
	{
		printf("\nFailed to open the file.\n");
		exit(1);
	}

	int i;
	for (i = 0; i < 10; i++)
	{
		fscanf(inFile, "%d", &numberArray[i]);//reads integers from the file and stores them in an array
	}

	printf("\nOld pollen count\n");

	//display old pollen count
	for (int i = 0; i < 10; i++)//display old count
	{
		printf("\n%d\n", numberArray[i]);
	}

	//sum up the numbers
	for (int i = 0; i < 10; i++)
	{
		totalCount+= (numberArray[i]);
	}

	printf("\nOld sum: %d\n", totalCount);

	oldAverage = totalCount / 10;//calculate old pollen count average
	printf("\nOld pollen average: %.0f\n", oldAverage);

	fclose(inFile);

	totalCount = 0;//reset sum to 0 for the new pollen sum

	outFile = fopen("newpollens.txt", "w");//create the new pollens file

	if (inFile == NULL)//check if file exists
	{
		printf("\nFailed to open the file.\n");
		exit(1);
	}


	for (int i = 1; i < 10; i++)//print the numbers in the array to the newpollens file starting from the second number
	{
		fprintf(outFile, "\n%d", numberArray[i]);
	}

	fprintf(outFile, "\n%d", newestCount);//print the user entered pollen count

	fclose(outFile);

	outFile = fopen("newpollens.txt", "r");

	if (inFile == NULL)//check if file exists
	{
		printf("\nFailed to open the file.\n");
		exit(1);
	}

	printf("\nNew pollen count\n");

	for (i = 0; i < 10; i++)//print the new numbers from the file into a new array
	{
		fscanf(outFile, "%d", &numberArray2[i]);
	}
	for (int i = 0; i < 10; i++)//display the new count
	{
		printf("\n%d\n", numberArray2[i]);
	}

	for (int i = 0; i < 10; i++)//sum up the new pollen count
	{
		totalCount+= (numberArray2[i]);
	}
	
	printf("\nNew sum: %d", totalCount);
	
	newAverage = totalCount / 10;
	printf("\nNew pollen average: %.0f\n", newAverage);

	fclose(outFile);

	return 0;
}
