using System;

public class Palindrome
{
	public Palindrome()
	{
        Console.WriteLine("Palindrome is something which is reads the same backwards as forwards");
	}

    public static void CheckPalindromeString(string value, int algorithimType)
    {
        switch (algorithimType)
        {
            case 1:
                char[] charArr = value.ToCharArray();
                System.Array.Reverse(charArr);
                if (value == charArr.ToString())
                    Console.WriteLine("Is Palindrome");
                else
                    Console.WriteLine("Is not Palindrome");
                break;
            default:
                break;
        }
    }
}
