/* 
	Laquon Hamilton
	Lab 5 pg 286 PE 4
	2020-02-12
*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
#include <math.h>
//begin our main function
//b.
int main()
{
	printf("\nProgram that computes the square of a value passed to the function squareIt\n");
	void squareIt(float); //function prototype
	float newValue;//inputted value

	printf("\nEnter a number: ");
	scanf("%f", &newValue);

	squareIt(newValue);//calls the function and sends the entered value to the function
	
  return 0;
}

//a.
void squareIt(float newValue)//function header
{
	float sqValue = 0;
	sqValue = pow(newValue, 2);//computes the square of the value entered
	printf("\nThe squared number is %.2f", sqValue);

}

