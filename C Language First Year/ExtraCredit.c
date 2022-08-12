/*

	Laquon Hamilton
	Extra Credit
	5/3/20

*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int newBinary(); 	//convert to base 2
int newOctal(); 	//convert to base 8
int newHex();			//convert to base 16

int main()
{
  long int newValue;
	char tryAgain[5];
	
	printf("\nPlease input a positive integer: ");
  scanf("%ld", &newValue);

	newBinary(newValue);
	newOctal(newValue);
	newHex(newValue);

	printf("\n\nDo you want to try another number? (Y/N): ");
	scanf("%s", tryAgain);

	if (strcmp(tryAgain, "Y") == 0) 
	{
		system("clear"); 
		main();
	}
	else if (strcmp(tryAgain, "N") == 0)
	{
		exit(1);
	}


  return 0;
}

int newBinary(long int newValue)	//convert to base 2
{
	int binaryNums, printNum;
	
	printf("\n%ld in Base 2: ", newValue);
  
	for (binaryNums = 7; binaryNums >= 0; binaryNums--)
  {
    printNum = newValue >> binaryNums;

    if (printNum & 1)
		{
      printf("1");
		}
    else
		{
      printf("0");
		}
  }

	return (newValue);
}

int newOctal(long int newValue)	//convert to base 8
{
	int newQuotient;
	int octalNum[100], i = 1, j;

	newQuotient = newValue;
	
	while (newQuotient != 0)
	{
		octalNum[i++] = newQuotient % 8;
		newQuotient = newQuotient / 8;
	}
	
	printf("\n\n%ld in Base 8: ", newValue);
	
	for (j = i - 1; j > 0; j--)
	{
		printf("%d", octalNum[j]);
	}

	return (newValue);
}

int newHex(long int newValue)	//convert to base 16
{
		int newQuotient, newRemainder;
    int i, j = 0;
    char hexadecNum[100];
 
    newQuotient = newValue;
 
    while (newQuotient != 0)
    {
			newRemainder = newQuotient % 16;
			
			if (newRemainder < 10)
			{
				hexadecNum[j++] = 48 + newRemainder;
			}
			else
			{
				hexadecNum[j++] = 55 + newRemainder;
			}		
			
			newQuotient = newQuotient / 16;
    }
 
		printf("\n\n%ld in Base 16: ", newValue);
    
		for (i = j; i >= 0; i--)
		{
      printf("%c", hexadecNum[i]);
		}

    return (newValue);
}
