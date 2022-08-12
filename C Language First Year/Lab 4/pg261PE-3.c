/* 
	Laquon Hamilton
	Lab 4 pg 261 PE 3
	2020-02-09
*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
//begin our main function
int main()
{
	int bCounter, gCounter = 0;
	int bGame, bTotal, bAvg = 0;
	int tTotal = 0;
	int tAvg = 0;
	//loop through each bowler
	for(bCounter = 1; bCounter < 6; bCounter++)
	{
		//games for each bowler
		for(gCounter = 1; gCounter < 4; gCounter++)
		{
			//prompt user to enter game info
			printf("\nInput score for bowler %d, game %d --> ",bCounter,gCounter);
			scanf("%d",&bGame);
			bTotal = bTotal + bGame;
		}
		//calculate the player average
		bAvg = bTotal/3;
		//display results
		printf("\nThe average for bowler %d is %d\n",bCounter,bAvg);
		//add player total to team total
		tTotal = tTotal + bTotal;
		//reset player game counter to zero
		bTotal = 0;
	}//outer loop for players
	//calculate our team average
	tAvg = tTotal/15;
	printf("\nThe total score for the team is %d\n", tTotal);
	printf("\nThe team average is %d\n", tAvg);
}