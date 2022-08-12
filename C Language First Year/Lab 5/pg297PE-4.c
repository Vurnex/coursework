/* 
	Laquon Hamilton
	Lab 5 pg 297 PE 4
	2020-02-15
*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
//begin our main function
//b.
int main()
{
	printf("\nProgram that converts gallons to liters\n");
	float gallonsToLiters(float); //function prototype
	int newGallons;//inputted value

	printf("\nEnter the gallons: ");
	scanf("%d", &newGallons);

	float convLiters = 0;

	convLiters = gallonsToLiters(newGallons);//calls the function and sends the entered value to the function

	printf("\nThe converted value is %.4f liters", convLiters);
	
  return 0;
}

//a.
float gallonsToLiters(float newGallons)//function header
{

	float convLiters = 0;

	convLiters = newGallons * 3.7854;//convert to liters

	return (convLiters);//returns value to main

}