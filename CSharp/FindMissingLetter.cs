/**
* Level: 6kyu
* Description:
* Write a method that takes an array of consecutive (increasing) letters as input and that returns the missing letter in the array.
* You will always get an valid array. And it will be always exactly one letter be missing. The length of the array will always be at least 2.
* The array will always contain letters in only one case.

* Example:
* ['a','b','c','d','f'] -> 'e'
* ['O','Q','R','S'] -> 'P'
* Use the English alphabet with 26 letters!
*/
using System.Text;

public class Kata
{
    public static char FindMissingLetter(char[] array)
    {
        var missingAsciiCode = 32; //space

        for (var i = 1; i < array.Length; i++)
        {
            var previousAsciiCodeWrong = (int)array[i - 1] != (int)array[i] - 1;
            if (previousAsciiCodeWrong)
            {
                missingAsciiCode = (int)array[i]-1;
            }
        }

        return (char)missingAsciiCode;
    }
}