/* 
	Laquon Hamilton
	Lab 4 pg 248 PE 7
	2020-02-09
*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
//begin our main function
int main()
{
	printf("\n- Program to display a depreciation schedule table\n");
	printf(" \n");
	printf("              DEPRECIATION SCHEDULE\n");
	printf("              ---------------------\n");
	printf("  \n");
	printf("                       END-OF-YEAR     ACCUMULATED\n");
	printf("YEAR    DEPRECIATION      VALUE        DEPRECIATION\n");
	printf("----    ------------   -----------     ------------  \n");
	

	int year = 0;//number of years
	int depreValue = 0;//depreciation value
	int depreRate = 28000;//end of year value
	int depreAccu = 0;//accumulated depreciation
	int count = 0;

	for (year+= 1; year < 8; year++)//
	{
	printf("%3d         %d          %5d           %5d\n", year, depreValue = 4000, depreRate = depreRate - 4000, depreAccu+= 4000);
	}
	
	return 0;

}