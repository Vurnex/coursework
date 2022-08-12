/* 

	Laquon Hamilton
	Lab 11 pg 588 PE 3
	In-Class
	2020-04-08

*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
#define NUMELS 15
//define structure
struct EmpRec//new structure
{
	int num;//employee number
	char name[NUMELS];
	float rate;
	float hours;
};

int main()
{

	struct EmpRec payroll[3];//array of 3 structures
	float totalGrossPay = 0.0;
	float employeeGrossPay = 0.0;

	for (int i = 0; i < 3; i++)
	{
		printf("\nPlease enter the employee number: ");
		scanf("%d", &payroll[i].num);
		printf("\nPlease enter the employee name: ");
		scanf("%s", payroll[i].name);
		printf("\nPlease enter the employee pay rate: ");
		scanf("%f", &payroll[i].rate);
		printf("\nPlease enter the employee hours worked: ");
		scanf("%f", &payroll[i].hours);
	}

	for (int i = 0; i < 3; i++)
	{
		//calculate employee gross pay
		employeeGrossPay = payroll[i].rate * payroll[i].hours;
		totalGrossPay += employeeGrossPay;
		//print our data to the screen
		printf("\n%d\t%-10s\t%6.2f\t%6.2f\t%6.2f\n", payroll[i].num, payroll[i].name, payroll[i].rate, payroll[i].hours, employeeGrossPay);
	}

	printf("\nThe total payroll expense for this period is $%.2f",totalGrossPay);

	return 0;

}

