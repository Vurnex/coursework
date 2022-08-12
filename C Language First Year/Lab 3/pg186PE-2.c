/*
	Laquon Hamilton
	Lab 3 pg 186 PE 2
	2020-02-01
*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
//begin our main function
int main()
{

	int timeDeposited = 0.0;
	double interestRate = 0.0;


	printf("\nProgram to determine interest rate based on how long they have \nbeen deposited in a bank\n");

	printf("\nEnter the amount of time funds have been left on deposit: ");
	scanf("%d", &timeDeposited);

	//decide interest rate based on input
	if(timeDeposited >= 5)
	{
		interestRate = .045;
	}
	else if((timeDeposited < 5) && (timeDeposited >= 4))
	{
		interestRate = .04;
	}
	else if((timeDeposited < 4) && (timeDeposited >= 3))
	{
		interestRate = .035;
	}
	else if((timeDeposited < 3) && (timeDeposited >= 2))
	{
		interestRate = .03;
	}
	else if((timeDeposited < 2) && (timeDeposited >= 1))
	{
		interestRate = .025;
	}
	else if(timeDeposited < 1)
	{
		interestRate = .02;
	}

	//display interest rate
	printf("\nThe Interest Rate is %.3f", interestRate);
	return 0;

}