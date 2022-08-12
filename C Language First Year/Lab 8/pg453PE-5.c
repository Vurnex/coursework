/* 

	Laquon Hamilton
	Lab 8 pg 453 PE 5
	2020-03-09

*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
//begin our main function
int main()
{
	printf("\nProgram that accepts a string of characters and displays the string one word per line.\n");

	char message;

	printf("\nEnter a string: ");

	message = getchar();//accepts a string of characters
	printf("\nResult:\n\n");
	while (message != '\0')//check for end of string
	{
		if (message == ' ')//check for spaces
		{
				putchar('\n');//creates newline escape
		}
		else 
		{
			putchar(message);//prints individual word
		}
		message = getchar();//keeps loop in check and holds the string
	}

	message = '\0';//ends the loop

	return 0;
}
