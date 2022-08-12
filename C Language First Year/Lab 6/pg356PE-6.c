/* 
  Laquon Hamilton
  Lab 6 pg 356 PE 6
  2020-02-27
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

	void date(int, int*, int*, int*);//function prototype
	int newDate, year, month, day;
  
	printf("\nEnter the Date in the format yyyymmdd: ");
	scanf("%d", &newDate);

	date(newDate, &year, &month, &day);


	printf("\nThe date is %d/%d/%d", year, month, day);
	return 0;

}

//a.
void date(int newDate, int *year, int *month, int *day)
{
	//convert to year/month/day format
	*year = newDate / 10000;
	*month = (newDate - *year * 10000) / 100;
	*day = newDate - (*year * 10000 + *month * 100);

	return;

}
