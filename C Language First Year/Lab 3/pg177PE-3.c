/*
	Laquon Hamilton
	Lab 3 pg 177 PE 3
	2020-01-29
*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
//begin our main function
int main()
{
	float weeklySalary = 0.0;
	float hoursWorked = 0.0;
	float perhourRate = 0.0;
	float overtimePay = 0.0;
	printf("\nEnter the hours worked: ");
	scanf("%f",&hoursWorked);
	//determine salary from hours worked
	if(hoursWorked <= 40)
	{
		perhourRate = 8.00;
	}
	else if(hoursWorked > 40)
	{
		perhourRate = 320.00;
		overtimePay = ((hoursWorked - 40) * 12);
	}
	else
	{
		perhourRate = 8.00;
	}
	//calculate weekly salary
	if(hoursWorked > 40)
	{
		weeklySalary = overtimePay + perhourRate;
	}
	else
	{
	weeklySalary = hoursWorked * perhourRate;
	}
	//display results to our user
	printf("\nThe per hour rate is $%2.2f", perhourRate);
	printf("\nThe weekly salary is $%7.2f", weeklySalary);
	
	return 0;
}

//b. Make enough runs to verify that the math is correct. The data that should be inputted is the hours worked. 