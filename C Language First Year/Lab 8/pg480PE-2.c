/* 

	Laquon Hamilton
	Lab 8 pg 480 PE 2
	2020-03-16

*/

//include the stdio file for user input and output
//preprocessor directive

#include <stdio.h> 
#include <string.h>
#define SIZE 100//constant global value
//begin our main function
int main()
{ 
	printf("\nProgram that accepts a string and passes it to a function that determines how many vowels are in it.\n");

	void cvowels(char*, int*);//function prototype

	char newLine[SIZE];
	int totalVowels = 0;

	printf("\nEnter a string: ");
	fgets(newLine, sizeof(newLine), stdin);//accepts a string

	cvowels(newLine, &totalVowels);//passes newLine by value and totalVowels by reference

	return 0;
}

void cvowels(char *newLine, int *totalVowels)
{
	for (int i = 0; newLine[i] != '\0'; i++)//reads the string
	{
		if (newLine[i] == 'a' || newLine[i] == 'e' || newLine[i] == 'i' ||
				newLine[i] == 'o' || newLine[i] == 'u' || newLine[i] == 'A' ||
				newLine[i] == 'E' || newLine[i] == 'I' || newLine[i] == 'O' ||
				newLine[i] == 'U')//determines if any of these vowels are in the string
		{
			++*totalVowels;//adds up total vowels
		}
	}

	printf("\nThe string entered contains %d Vowels", *totalVowels);

	return;

}