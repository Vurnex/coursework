/* 
  Laquon Hamilton
  Lab 6 pg 369 PE 4
  2020-02-29
*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
#include <math.h>
//begin our main function
//b.
int main()
{
	printf("\nProgram that determines the next term in a geometric sequence for five terms where a = 2 and r = 3\n");

	void geoSeq(int, int, int, int, int, int*);
	
	int a = 2;//first term
	int r = 3;//common ratio
	int n = 1;//value of n
	int nextTerm = 0;//number of terms
	int result;//calculated value
	int termSum = 0;//sum of all n terms

	geoSeq(a, r, n, nextTerm, result, &termSum);

	//printf("\nThe next term is %d", result);

	printf("\nThe sum of the terms is %d", termSum);
	return 0;
	
}

//a.
void geoSeq(int a, int r, int n, int nextTerm, int result, int *termSum)
{	
	//recursive call while n less than 6
	if (n < 6)
	{
		
		result = (a * (pow(r, n - 1)));//calculate the value
		n+= 1;//continue sequence
		nextTerm+= 1;//count up terms
		printf("\nTerm %d is %d\n", nextTerm, result);
		*termSum = *termSum + result;//add the values of the terms
		geoSeq(a, r, n, nextTerm, result, termSum);//recursive call
			
		return;
	}

}
