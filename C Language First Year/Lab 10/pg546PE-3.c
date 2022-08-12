/* 

	Laquon Hamilton
	Lab 10 pg 546 PE 3
	2020-04-02

*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
#define NUMELS 30
//begin our main function
int main()
{ 
	printf("\nProgram that stores three strings in three different arrays and uses pointers to access the elements in the arrays.\n");

	char messag1[] = "\nInput the Following Data";
	char messag2[] = "\n------------------------\n";
	char messag3[NUMELS] = "\nEnter the Date: \n";
	char messag4[] = "\nEnter the Account Number:\n\n";
	int i;

	//print the array elements character by character
	for (i = 0; i < NUMELS; i++)
	{
		printf("%c", *(messag1 + i));
	}
	for (i = 0; i < NUMELS; i++)
	{
		printf("%c", *(messag2 + i));
	}
	for (i = 0; i < NUMELS; i++)
	{
		printf("%c", *(messag3 + i));
	}
	for (i = 0; i < NUMELS; i++)
	{
		printf("%c", *(messag4 + i));
	}

	return 0;

}
