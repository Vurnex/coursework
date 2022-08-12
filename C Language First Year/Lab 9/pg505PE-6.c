/* 

	Laquon Hamilton
	Lab 9 pg 505 PE 6
	2020-03-30

*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
#include <stdlib.h>
//begin our main function
int main()
{ 
	printf("\nProgram that reads data from a file and displays a payroll schedule.\n");

	char name[20];
	char ssNum[20];
	float hourlyRate;
	int hoursWorked;
	float grossPay = 0;

	FILE *inFile;//file declaration

	inFile = fopen("info.txt", "r");//opens the file and reads from it
	
	if (inFile == NULL)//check if file exists
	{
		printf("\nFailed to open the file.\n");
		exit(1);//passes argument directly to operating system and then terminates program operation
	}

	while (fscanf(inFile, "%s %s %f %d", name, ssNum, &hourlyRate, &hoursWorked) != EOF)//reads values from the file for the listed arguments until end of file is reached
	{
		grossPay = hourlyRate * hoursWorked;
		printf("\nSocial Security Number: %s\n", ssNum);
		printf("\nName: %s\n", name);
		printf("\nGross Pay: $%.2f\n", grossPay);
		printf("\n-------------------------------------\n");
	}

	return 0;
}
