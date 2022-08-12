/* 

	Laquon Hamilton
	Lab 8 pg 463 PE 5
	2020-03-13

*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
#include <ctype.h>
#include <stdlib.h>
#include <time.h>
#define SIZE 21
//begin our main function
//b.
int main()
{
	printf("\nProgram that generates 20 random integers and determines their ASCII type.\n");

	void charType(int);
	int randNum;

	srand(time(NULL));//randomize values
	for (int i = 1; i < 21; i++)//generates numbers in range and calls the charType function via recursion
	{
		randNum = rand() % 127 + 1;
		charType(randNum);
	}

	return 0;

}

//a.
void charType(int randNum)
{
	for (int i = 0; i < 1; i++)//determines what type of the integer
	{
		char C = randNum;
		if (islower(C))
			printf("\n%c has a value of %d and is a lower case\n", C, C);
		else if (isupper(C))
			printf("\n%c has a value of %d and is a upper case\n", C, C);
		else if (isdigit(C))
			printf("\n%c has a value of %d and is a digit\n", C, C);
		else if (ispunct(C))
			printf("\n%c has a value of %d and is a punctuation\n", C, C);
		else if (isspace(C))
			printf("\nYou entered a space that has a value of %d\n", C);
		else if (!isprint(C))
			printf("\nYou entered a nonprintable character that has a value of %d\n", C);
		
	}

}
