/* 

	Laquon Hamilton
	Lab 10 pg 552 PE 3
	2020-04-02

*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
//begin our main function
int main()
{ 
	printf("\nProgram that stores a string in an array and uses a while and for loop to display it.\n");

	char strng[] = "Hooray for All of Us" ;
	char *messPtr;//pointer variable where the address of the array will be stored
	int i = 0;

	messPtr = strng;//stores the address of strng[0] in messPtr

	printf("\nUsing the for statement\n\n");//a.

	for (i = 11; /* c. Start display with All */ i < 20; i++)
	{
		printf("%c", *(messPtr + i));//i increments the array index
	}

	printf("\n_________________________\n");
	printf("\nUsing the while statement\n\n");//b.

	i = 0;//reset i for index 0

	while (*(messPtr + i) != '\0')//until end of string is reached
	{
		printf("%c", *(messPtr + i));
		i++;//increment i for array index
	}

	return 0;

}
