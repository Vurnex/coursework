/* 
	Laquon Hamilton
	Lab 5 pg 307 PE 5
	2020-02-15
*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
#include <math.h>
//begin our main function
int main()
{
	printf("\nProgram that determines monthly payment based on finance amount.\n");
	float payment(float); //function prototype

	float newPayment;

	float monthlyPayment = 0;

	monthlyPayment = payment(newPayment);//calls the function and sends the entered value to the function

	printf("\nThe monthly payment is %.2f", monthlyPayment);
	
  return 0;
}

float payment(float newPayment)//function header
{
	
	float principal;//amount financed
	float intRate = (0.10 / 12);//monthly interest rate over a finance period of 12 months
	float months = 12;//number of months the loan is for

	printf("\nEnter the amount financed: ");
	scanf("%f", &principal);

	//calculate monthly payment
	newPayment = (principal / (1 / intRate) - (1 / intRate * (intRate + 1))*pow(intRate, months));
	newPayment = newPayment * 10;

	return(newPayment);//returns value to main

	//only decimal and integer values should be input

}