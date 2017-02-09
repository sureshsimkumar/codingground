/* Read input from STDIN. Print your output to STDOUT*/
using System;
namespace CandidateCode {
	class CandidateCode {
		static void Main(string[] args) {
		//Write code here
		int lnInput,lnCnt;
		string lsArray;
		lnInput = Int32.Parse(Console.ReadLine());
		lsArray = Console.ReadLine();
		string[] laArray = lsArray.Split(' ');
		int[] laResult = new int[lnInput];
		for (lnCnt = 0; lnCnt<lnInput; lnCnt++)
		{
		    laResult[lnCnt] = Int32.Parse(laArray[lnCnt]);
		}
		Array.Sort(laResult);
		Array.Reverse(laResult);
		Console.WriteLine(laResult[1]);
		}
	}
}
