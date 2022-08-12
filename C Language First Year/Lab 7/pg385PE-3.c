/* 
	Laquon Hamilton
	Lab 5 pg 286 PE 4
	In-Class
	2020-03-05
*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
//Include a symbolic constant to hold the number
//For testing, we will only include 5
#define NUMELS 6
//begin our main function
int main()
{
	printf("\nProgram that inputs grades into an array \n");
	//function prototype
	float calcVariance(int devs[NUMELS]);
	//declare the variable to hold our grades
	int grades[NUMELS];
	int i; //holds our incrementer
	int total = 0; //holds the total of our grades
	float average = 0.0; //holds the calculated mean of our grades
	int deviations[NUMELS];
	//loop through to gather our data and populate the array
	for (i = 1; i < NUMELS; i++)
	{
		//prompt
		printf("\nPlease input grade %d: ", i);
		scanf("%d", &grades[i]);
		//add our grades to our total
		total+= grades[i];
	}
	//display our total grades
	printf("\nThe total of our grades is %d\n", total);
	//calculate our mean
	average = (float)total/(NUMELS - 1);
	printf("\nThe average is %.2f\n", average);
	//calculate our deviations
	for (i = 1; i < NUMELS; i++)
	{
		//print the contents of the array
		//printf("Grade %d-%d\n: ", i, grades[i]);
		deviations[i] = grades [i] - average;
	}
	//new loop to print results
	for (i = 0; i < NUMELS; i++)
	{
		//print the contents of the array and deviations
		printf("\nGrade %d-%d Deviation %d:\n ", i, grades[i], deviations[i]);
	}
	
	printf("\nThe variance is %.2f\n", calcVariance(deviations));
	return 0;
}

float calcVariance(int devs[NUMELS])
{
	float totVar = 0;
	float avVar = 0;
	int i;//number of our counter
	for (i = 0; i < NUMELS; i++)
	{
		totVar+= devs[i] * devs[i];//square our deviations and add to total
	}
	avVar = totVar/(NUMELS - 1);
	return avVar;
}