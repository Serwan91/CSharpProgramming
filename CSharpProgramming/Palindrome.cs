using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    public class Palindrome
    {
        static Palindrome()
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
                    if (value == new String(charArr))
                        Console.WriteLine("Is Palindrome");
                    else
                        Console.WriteLine("Is not Palindrome");
                    break;
                case 2:
                    char[] charArr1 = value.ToCharArray();
                    bool IsPalindrome = true;
                    for (int i = 0, j = charArr1.Length - 1; i < (charArr1.Length / 2); i++,j--)
                    {
                        if(charArr1[i] != charArr1[j])
                        {
                            IsPalindrome = false;
                            break;
                        }
                    }
                    if(!IsPalindrome)
                        Console.WriteLine("Is Not Palindrome");
                    else
                        Console.WriteLine("Is Palindrome");
                    break;
                case 3: 

                default:
                    break;
            }
        }
    }

}
