/* 
	
	Laquon Hamilton
	ITS-245
	9/20/20
	Lab 4
	Task 1

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS_245_Lab_4
{
    class ClassifiedAd
    {				
			private string usedBooks;
			private int numWords;
			private int price;

			public string UsedBooks { get => usedBooks; set => usedBooks = value; }
			public int NumWords { get => numWords; set => numWords = value; }
			public double Price { get => numWords*0.09;  }

			public void displayBookInfo()
			{
				Console.WriteLine("\nBook Title: {0}", usedBooks);
				Console.WriteLine("\nBook Words: {0}", numWords);
				Console.WriteLine("\nBook Price: ${0, 6:F2}", Price);
			}

    }
}
