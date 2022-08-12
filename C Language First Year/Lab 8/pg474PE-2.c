/* 

	Laquon Hamilton
	Lab 8 pg 474 PE 2
	2020-03-16

*/

//include the stdio file for user input and output
//preprocessor directive

#include <stdio.h> 
#include <string.h>
#define SIZE 100//constant global value
//PE 1
//begin our main function
int main()
{ 
	printf("\nProgram that accepts 3 numbers as one string, then passes it to a function to be separated.\n");

	void separate(char*, float*, float*, float*);//function prototype
	char allNumbers[SIZE];
	float num1, num2, num3;
	int i = 1;//current number input

	printf("\nEnter number %d: ", i);
	scanf("%f", &num1);
	i+= 1;//increment current number input
	printf("\nEnter number %d: ", i);
	scanf("%f", &num2);
	i+= 1;
	printf("\nEnter number %d: ", i);
	scanf("%f", &num3);

	sprintf(allNumbers, "%.0f/%.0f/%.0f", num1, num2, num3);//stores the variables as one string in allNumbers

	printf("\nAssembled String: %s\n", allNumbers);//displays combined string

	separate(allNumbers, &num1, &num2,&num3);

	return 0;

}

//PE 2
void separate(char *allNumbers, float *num1, float *num2, float *num3)
{

	sscanf(allNumbers, "%f %f %f", &*num1, &*num2, &*num3);//separates the values again

	printf("\nDisassembled String:");
	printf("%6.2f %6.2f %6.2f", *num1, *num2, *num3);//displadisassembled string as separate 

}
