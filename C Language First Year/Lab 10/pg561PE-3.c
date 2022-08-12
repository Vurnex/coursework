/* 

	Laquon Hamilton
	Lab 10 pg 561 PE 3
	2020-04-03

*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
#define NUMELS 18
//begin our main function
int main()
{ 
	printf("\nProgram that stores a string in an array and sends it to a function to be displayed by incrementing the array and incrementing the string\n");

	void display(char[]);

	char message[] = "\nVacation is near\n";
	char *strng;//pointer variable

	strng = message;//store message array in pointer variable strng

	display(strng);

	return 0;

}

void display(char *strng)
{

	printf("\nIncrementing the array\n");
	for (int i = 0; i < NUMELS; i++)
	{
		printf("%c", *(strng + i));//i increments the array index
	}

	printf("_______________________\n");

	printf("\nIncrementing the string\n");

	//b.
	while (*strng != '\0')
	{
		printf("%c", *strng);
		strng++;//moves pointer to the next character
	}

	printf(" \n");

}
