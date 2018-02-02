/**
* Level: 6kyu
* Description:
* Bob is preparing to pass IQ test. The most frequent task in this test is to find out which one of the given numbers differs
* from the others. Bob observed that one number usually differs from the others in evenness. Help Bob — to check his
* answers, he needs a program that among the given numbers finds one that is different in evenness, and return a position of this number.
* Keep in mind that your task is to help Bob solve a real IQ test, which means indexes of the elements start from 1 (not 0)
*
* ##Examples :
* IQ.Test("2 4 7 8 10") => 3 // Third number is odd, while the rest of the numbers are even
* IQ.Test("1 2 1 1") => 2 // Second number is even, while the rest of the numbers are odd
*/
using System;

namespace CSharp
{
    class IQTest
    {
	    public static int Test(string numbers)
	    {
	        var numbersArray = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);
	        var evenNumbersCount = 0;
	        var oddNumbersCount = 0;
	        var lastEvenNumberIndex = 0;
	        var lastOddNumberIndex = 0;
	        var lastElementIndex = numbersArray.Length - 1;

	        for (var i = 0; i < numbersArray.Length; i++)
	        {
	            var conversionSuccessful = Int32.TryParse(numbersArray[i], out var number);
	            if (conversionSuccessful)
	            {
	                if (number % 2 == 0)
	                {
	                    evenNumbersCount++;
	                    var evenNumbersPatternFound = evenNumbersCount > 1 && oddNumbersCount > 0;
	                    if (evenNumbersPatternFound)
	                    {
	                        return lastOddNumberIndex;
	                    }

	                    lastEvenNumberIndex = i + 1;
	                }
	                else
	                {
	                    oddNumbersCount++;
	                    var oddNumbersPatternFound = oddNumbersCount > 1 && evenNumbersCount > 0;
	                    if (oddNumbersPatternFound)
	                    {
	                        return lastEvenNumberIndex;
	                    }

	                    lastOddNumberIndex = i + 1;
	                }
	            }
	        }

	        return lastElementIndex + 1;
	    }
    }
}
