/* 

	Laquon Hamilton
	Lab 11 pg 583 PE 1
	2020-04-08

*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
#include <stdlib.h>//for conversions
#include <time.h>//for current time

struct Date//new structure
{
	int newMonth;
	int newDay;
	int newYear;
	//b.
	int newHours;
	int newMinutes;
	int newSeconds;

};

int main()
{ 
	printf("\nProgram that prompts user to enter the date and time, where the data is stored in a structure.\n");
	
	//this is mostly for getting the current seconds
	time_t now;//for storing current system time value
	time(&now);//current time since Jan 1st 1970 in seconds

	printf("\nToday is: %s", ctime(&now));//returns the string representing the localtime

	struct Date newDate;//lets main function read from the structure
	
	printf("\nPlease enter the current month: ");//month
	scanf("%d", &newDate.newMonth);
	printf("\nPlease enter the current day: ");//day
	scanf("%d", &newDate.newDay);
	printf("\nPlease enter the current year: ");//year
	scanf("%d", &newDate.newYear);
	
	//b.
	printf("\nPlease enter the current hour: ");//current hour
	scanf("%d", &newDate.newHours);
	printf("\nPlease enter the current minute: ");//current minute
	scanf("%d", &newDate.newMinutes);
	printf("\nPlease enter the current seconds: ");//current seconds
	scanf("%d", &newDate.newSeconds);

	printf("\nThe current date is %d/%d/%d", newDate.newMonth, newDate.newDay, newDate.newYear);

	if (newDate.newMinutes < 10)
	{//print zero if less than 10
		printf("\nThe current time is %d:0%d:0%d", newDate.newHours, newDate.newMinutes, newDate.newSeconds);
	}
	else
	{
		printf("\nThe current time is %d:%d:0%d", newDate.newHours, newDate.newMinutes, newDate.newSeconds);
	}

	return 0;

}
