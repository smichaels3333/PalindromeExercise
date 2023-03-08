using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
           var reversedWord = word.Reverse();
           return word.ToLower().SequenceEqual(reversedWord);
        }
        
    }
}
