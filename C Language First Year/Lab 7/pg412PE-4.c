/* 
	Laquon Hamilton
	Lab 7 pg 412 PE 4
	2020-03-09
*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
//Include a symbolic constant to hold the number
#define ROWS 3
#define COLS 4
//begin our main function
int main()
{
	printf("\nProgram that finds and displays the maximum value in a two dimensional array.\n");

	void findMax(int[ROWS][COLS]);//function prototype

	int newValues[ROWS][COLS] = {8, 16, 9, 52,
								3, 15, 27, 6,
								14, 25, 2, 10,};//declare the 2D array


	findMax(newValues);//call function


	return 0;

}

void findMax(int newValues[ROWS][COLS])//a.
{
	int i, j;//incrementors
	int maxHigh;//holds highest value
	maxHigh = newValues[0][0];//sets highest value
	int rowNum = 0;
	int colNum = 0;

	for (i = 0; i < ROWS; i++)//loops through each row
	{
		for (j = 0; j < COLS; j++)//loops through each column
		{
			if (newValues[i][j] > maxHigh)//determines highest value
				maxHigh = newValues[i][j];
				rowNum = i;
				colNum = j;
		}
	}


	printf("\nThe highest value is %.2d\n", maxHigh);
	//b.
	printf("\nThe Row Number is %d and the Column Number is %d", rowNum - 2,colNum);

}
