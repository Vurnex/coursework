/* 

	Laquon Hamilton
	Lab 9 pg 510 PE 5
	2020-03-28

*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h> 
#include <stdlib.h>//for the exit() function
//begin our main function
int main()
{ 
	printf("\nProgram that reads and displays n characters starting from the beginning of a file.\n\n");

	void readBytes(char storeChar[], FILE *, long int offset, int);//function prototype

	FILE *inFile;
	int ch;
	long int offset;
	char storeChar[10];
	offset = 0L;//first character in the file

	readBytes(storeChar, inFile, offset, ch);

	return 0;
}

void readBytes(char storeChar[10], FILE *inFile, long int offset, int ch)
{
	long int last;
	int i;
	inFile = fopen("info.txt", "r");//opens and the file and reads from it
	
	if (inFile == NULL)//check if file exists
	{
		printf("\nFailed to open the file.\n");
		exit(1);//passes argument directly to operating system and then terminates program operation
	}

	fseek(inFile, 0L, SEEK_END);//move to the end of the file
	last = ftell(inFile);//saves the offset of the last character

	for (offset = 0; offset <= last; offset++)
	{
		fseek(inFile, -offset, SEEK_SET);//moves to the next character

		ch = getc(inFile);//gets the character
		
		switch(ch)
		{
			case '\n': printf("\n");
				break;
			case EOF : printf(" :EOF");
				break;
			default  : printf("%c", ch);
				break;
		}

		//b. stores the characters into an array
		storeChar[i] = ch;
		storeChar[i]++;
		
	}

	fclose(inFile);

}
