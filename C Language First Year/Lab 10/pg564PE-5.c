/* 

	Laquon Hamilton
	Lab 10 pg 564 PE 5
	2020-04-04

*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
#define NUMELS 12
//begin our main function
int main()
{ 
	printf("\nProgram that deletes all occurences of a specified character in a string.\n\n");

	void removeIt(char*, char);

	char message[] = "HappyHolidays";
	char removeChar;

	removeIt(message, 'H');//sends the string and character to be removed to the function

	for (int i = 0; i < NUMELS; i++)//
	{
		printf("%c", *(message + i));//i increments the array index
	}

	return 0;

}

void removeIt(char* message, char removeChar)
{

	char *readChar = message;//for reading through the string
	char *printChar = message;//for printing characters in the string

	while (*readChar != '\0')//loops through the string
	{
		*printChar = *readChar++;//for printing the individual characters
		printChar += (*printChar != removeChar);//prints all characters not specified in removeChar
	}

	*printChar = '\0';//ensures end of string

}
