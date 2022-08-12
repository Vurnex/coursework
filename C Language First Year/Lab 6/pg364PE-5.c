/* 
  Laquon Hamilton
  Lab 6 pg 364 PE 5
  2020-02-28
*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
#include <math.h>
//begin our main function
//b.
int main()
{
	printf("\nProgram that accepts a date in yyyymmdd format and displays the value in the form yyyy/mm/dd as separate values\n");
	//printf("\ndollars, quarters, dimes, nickels, and pennies that make up the amount.\n");

	void yrCalc(int, int*, int*, int*);//function prototype
	int totalDays, year, month, day;
  
	printf("\nEnter the number of days since 1/1/1900: ");
	scanf("%d", &totalDays);

	yrCalc(totalDays, &year, &month, &day);//call function and pass by reference


	printf("\nThe date is %d/%d/%d", year + 1900, month, day + 1);
	return 0;

}

//a.
void yrCalc(int totalDays, int *year, int *month, int *day)//function using some referenced variables
{
	//convert days to yyyy/mm/dd format
	*year = (totalDays / 365);
	*month = (totalDays - *year * 365) / 30;
	*day = totalDays - (*month * 30 + *year * 365);

	return;

}
