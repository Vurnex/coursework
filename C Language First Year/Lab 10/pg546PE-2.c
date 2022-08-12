/* 

	Laquon Hamilton
	Lab 10 pg 546 PE 2
	2020-04-01

*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
//begin our main function
int main()
{ 
	printf("\nProgram that stores seven values in an array and displays them directly from the array using a pointer\n");

	float rates[] = {12.9, 19.6, 11.4, 13.7, 9.5, 15.2, 17.6};
	int i;

	for (i = 0; i < 7; i++)//loop to increment the pointer in the array
	{
		printf("\nValue %d is %.1f", i, *(rates + i));
	}

	return 0;

}
