/* 
	Laquon Hamilton
	Lab 5 pg 286 PE 8
	2020-02-15
*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
//begin our main function
//b.
int main()
{
	printf("\nProgram that determines whether the integer entered is even or odd\n");
	void intType(int);//function prototype
	int newValue;//inputted value

	printf("\nEnter a number: ");
	scanf("%d", &newValue);

	intType(newValue);//calls the function and sends the entered value to the function
	
  	return 0;
}

//a.
void intType(int newValue)//function header
{
	if (newValue % 2 == 0)//determine if entered value is perfectly divisible by 2
	{
	printf("\nThe integer %d is even", newValue);
	}
	else
	printf("\nThe integer %d is odd", newValue);

}