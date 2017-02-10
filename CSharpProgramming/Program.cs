using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Enter the string to check palindrome");
                Palindrome.CheckPalindromeString(Console.ReadLine(), 2);
                Console.WriteLine("Do you want to continue.. Yes/No ?");
            } while (Console.ReadLine().ToLower() != "no");
            
        }
    }
}
