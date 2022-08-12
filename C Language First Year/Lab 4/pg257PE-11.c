/* 
	Laquon Hamilton
	Lab 4 pg 257 PE 10
	2020-02-10
*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
#include <math.h>
//begin our main function
int main()
{
	printf("\nProgram to display a table of x and y values for a projectile fired with an initial velocity\n");
	printf(" \n");
	printf("       Projectile Fired with Initial Velocity\n");
	printf("         ---------------------------------\n");
	printf("                            \n");
	printf("          Time      X Value       Y Value          \n");
	printf("          ----     ---------     ---------    \n");
	

	float time = 0;//time interval
	float initVelocity = 500;//initial velocity
	float angle = 22.8;//given angle
	int count = 0;
	float x = 0;
	float y = 0;


	for (x = cos(22.8) * initVelocity; x > -7000; x = x - 345.16)
	{		
		time = time + 0.5;
		y = y - 361.75;
		printf("         %5.2fs     %5.2f     %8.2f\n", time, x, y);
	}

	return 0;

}