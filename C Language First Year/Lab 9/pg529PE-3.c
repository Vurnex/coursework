/* 

	Laquon Hamilton
	Lab 9 pg 529 PE 3
	2020-03-30

*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
#include <stdlib.h>
//begin our main function
int main()
{ 
	printf("\nProgram that writes double-precision numbers into a bin file, reads them from the file, and finds the average of the numbers.\n");

	//given numbers
	double binNum1 = 92.65;
	double binNum2 = 88.72;
	double binNum3 = 77.46;
	double binNum4 = 82.93;

	double newbinNum1, newbinNum2, newbinNum3, newbinNum4;

	float totalbinCount = 0;
	float averagebinNum = 0;

	FILE *inFile;

	inFile = fopen("results.bin", "wb");

	//write numbers to the binary file
	fwrite(&binNum1, sizeof(binNum1), 1, inFile);
	fwrite(&binNum2, sizeof(binNum2), 1, inFile);
	fwrite(&binNum3, sizeof(binNum3), 1, inFile);
	fwrite(&binNum4, sizeof(binNum4), 1, inFile);

	fclose(inFile);

	inFile = fopen("results.bin", "rb");

	//read binary data from the file and place them into new variables
	fread(&newbinNum1, sizeof(newbinNum1), 1, inFile);
	fread(&newbinNum2, sizeof(newbinNum2), 1, inFile);
	fread(&newbinNum3, sizeof(newbinNum3), 1, inFile);
	fread(&newbinNum4, sizeof(newbinNum4), 1, inFile);

	fclose(inFile);

	printf("\nNumbers read from bin file: %.2f %.2f %.2f %.2f\n", newbinNum1, newbinNum2, newbinNum3, newbinNum4);

	totalbinCount = newbinNum1 + newbinNum2 + newbinNum3 + newbinNum4;

	printf("\nSum of the numbers: %.2f\n", totalbinCount);
	
	averagebinNum = totalbinCount / 4;

	printf("\nAverage: %.2f", averagebinNum);

	return 0;
}
