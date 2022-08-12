/* 
	Laquon Hamilton
	Lab 4 pg 238 PE 10
	2020-02-09
*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
//begin our main function
int main()
{
	printf("\n-Program that calculates miles-per-gallon given mileage and gallons value\n");
	
	float mileage = 0;
	float count = 0;
	float gallons = 0;
	float milesPerGallon = 0;
	float previousMileage = 22495;
	float cumulativeMPG = 0;
	float previousMPG = 0;

	while (mileage < 25276)
	{
	printf("\nEnter the mileage ");
	scanf("%f", &mileage);
	printf("\nEnter the gallons value ");
	scanf("%f", &gallons);

	//calculate MPG
  	milesPerGallon = (mileage - previousMileage) / gallons;
	//calculate cumulative MPG for Part B
	cumulativeMPG = previousMPG + milesPerGallon;
	printf("\n---The miles per gallon is: %.2f miles---\n", milesPerGallon);
	previousMileage = mileage;
	previousMPG += milesPerGallon;

	//Part B.

	printf("\n---The cumulative miles per gallon is: %.2f miles---\n", cumulativeMPG);

	}

	return 0;

}