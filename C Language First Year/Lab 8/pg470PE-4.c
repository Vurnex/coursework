/* 

	Laquon Hamilton
	Lab 8 pg 470 PE 4
	2020-03-15

*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h> 
#include <string.h>
#define SIZE 100//constant global value
//begin our main function
int main()
{ 
	printf("\nProgram that accepts a name as first name last name then displays it as last name first name.\n");

	char fullName[SIZE];

	printf("\nEnter the full name: ");
	gets(fullName);//stores inputted value

    int length = strlen(fullName);//returns length of the string
  
    
    int i; 
    for (i = length - 1; i >= 0; i--)//read string from beginning to end
	{ 
		if (fullName[i] == ' ') 
		{         
            fullName[i] = '\0'; 
            printf("\nThe reversed full name is %s", &(fullName[i]) + 1); 
        } 
    } 
  
    printf(", %s", fullName);//print the remaining word
} 
