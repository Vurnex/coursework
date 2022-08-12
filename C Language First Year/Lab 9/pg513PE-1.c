/* 

	Laquon Hamilton
	Lab 9 pg 513 PE 1
	2020-03-29

*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h> 
//begin our main function
int main()
{ 
	printf("\nProgram that checks whether or not a file exists.\n");

	int fcheck(FILE *);//function prototype

	FILE *inFile;

	fcheck(inFile);

	return 0;
}

int fcheck(FILE *inFile)
{
	inFile = fopen("info.txt", "r");//opens the file and reads from it
	
	if (inFile == NULL)//check if file exists
	{
		printf("\nFile does not exist (0)");
		return 0;
	}
	else
	{
		printf("\nFile exists (1)");
		return 1;
	}

	fclose(inFile);

}
