/* 

	Laquon Hamilton
	Lab 11 pg 596 PE 1
	2020-04-10

*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
#include <stdlib.h>//for conversions

struct Date//new structure
{
	int month;
	int day;
	int year;

};

int main()
{ 
	printf("\nProgram that accepts a date \n");
	
	int newDate;

	struct Date dates;//lets main function read from the structure

	void days(struct Date, int totalDays);//function prototype

	int totalDays;

	printf("\nPlease enter the current month: ");//month
	scanf("%d", &dates.month);
	printf("\nPlease enter the current day: ");//day
	scanf("%d", &dates.day);
	printf("\nPlease enter the current year: ");//year
	scanf("%d", &dates.year);

	days(dates, totalDays);

	return 0;

}

void days(struct Date dates, int totalDays)
{

 	int newDays1, newDays2;

	//convert to total days
	newDays1 = ((dates.year * 1461) / 4) + ((dates.month * 153) / 5) + dates.day;

	newDays2 = ((1900 * 1461) / 4) + ((1 * 153) / 5) + 1;

	totalDays = (newDays1 - newDays2) - 2;

	printf("\nThe number of days since 1/1/1900 is: %d", totalDays);

	return;

}
