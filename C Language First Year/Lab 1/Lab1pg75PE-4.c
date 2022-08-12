/*
	Laquon Hamilton
	Lab 1 pg 75 PE 4
	2020-01-15
*/
//include preprocessor directives
//stdio for input and output
#include <stdio.h>
int main()
{
	//Declare variables
	int fNum, sNum;
	float numOne, numTwo, numThree, numFour, answer;
	//assign values
	fNum = 15;
	sNum = 4;
	
	//calculate 15/4
	printf("15/4 = %f\n",15.0/4.0);
	//determine remainder of 15/4
	printf("Remainder of 15/4 = %d\n",fNum%sNum);
	//assign values to our variables
	numOne = 5.0;
	numTwo = 3.0;
	numThree = 6.0;
	numFour = 4.0;
	//calculate our answer
	answer = numOne * numTwo - numThree * numFour;
	printf("The answer is %f", answer);
	return 0;

}//end main