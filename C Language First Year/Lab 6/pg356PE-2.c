/* 
  Laquon Hamilton
  Lab 6 pg 356 PE 2
  2020-02-26
*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
//begin our main function
int main()
{
	printf("\nProgram that accepts a dollar amount and determines the amount of");
	printf("\ndollars, quarters, dimes, nickels, and pennies that make up the amount.\n");

	void change(float, int*, int*, int*, int*, int*);//function prototype
	//display 0 rather than the address if not true
	int dollars = 0;
	int quarters = 0;
	int dimes = 0;
	int nickels = 0;
	int pennies = 0;
	float newAmount;//inputted value
	

	printf("\nEnter a dollar amount: ");
	scanf("%f", &newAmount);

	newAmount = newAmount * 100;//convert amount to cents

	change(newAmount, &dollars, &quarters, &dimes, &nickels, &pennies);

	printf("\nThe value entered amounts to %d Dollar(s), %d Quarter(s), %d Dime(s), %d Nickel(s), and %d Penny(s)", dollars, quarters, dimes, nickels, pennies);

	return 0;

}

void change(float newAmount, int *dollars, int *quarters, int *dimes, int *nickels, int *pennies)

//determine the values
{
	if(newAmount >= 100)
	{
		*dollars = newAmount / 100;
		newAmount = newAmount - (100 * *dollars);
	}
	if(newAmount >= 25)
	{
		*quarters = newAmount / 25;
		newAmount = newAmount - (25 * *quarters);
	}
	if(newAmount >= 10)
	{
		*dimes = newAmount / 10;
		newAmount = newAmount - (10 * *dimes);
	}
	if(newAmount >= 5)
	{
		*nickels = newAmount / 5;
		newAmount = newAmount - (5 * *nickels);
	}

	*pennies = newAmount;//leftover amount

	return;//returns to calling function

}

