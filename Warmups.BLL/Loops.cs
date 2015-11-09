using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.BLL
{
    public class Loops
    {
        /* Given a string and a non-negative int n, return a 
           larger string that is n copies of the original string. 
        */
        public string StringTimes(string str, int n)
        {
            string result = "";

            for (int i = 1; i <= n; i++)
            {
                result += str;
            }

            return result;
        }

        /* Given a string and a non-negative int n, we'll say that the front of the string is the first 3 chars, 
        or whatever is there if the string is less than length 3. Return n copies of the front; */

        public string FrontTimes(string str, int n)
        {
            string result = "";

            for (int i = 1; i <= n; i++)
            {
                result += str.Substring(0, 3);
            }
            return result;
        }

        //Count the number of "xx" in the given string. We'll say that overlapping is allowed, so "xxx" contains 2 "xx".

        public int CountXX(string str)
        {
            //declare a variable to count instances found
            //loop through the string looking at each index if the "xx" sequence exists
                // In the loop if it exists increment the variable
                // if(str.substring(i, 2) == "xx")
            // return the count
            int xCounter = 0;

            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str.Substring(i, 2) == "xx")
                {
                    xCounter++;
                }
            }
            return xCounter;
        }

        // Given a string, return true if the first instance of "x" in the string is immediately followed by another "x".

        public bool DoubleX(string str)
        {
            for (int i = 0; i <= str.Length; i++)
            {
                if (str[i] == 'x')
                {
                    if (i + 1 < str.Length && str[i + 1] == 'x')
                    {
                        return true;
                    }
                    return false;
                }

            }
            return false;
        }

        // 5. Given a string, return a new string made of every other char starting with the first, so "Hello" yields "Hlo". 

        public string EveryOther(string str)
        {
            string result = "";

            for (int i = 0; i < str.Length; i+=2)
            {
                result += str[i];
            }
            return result;
        }

        // Given a non-empty string like "Code" return a string like "CCoCodCode".  (first char, first two, first 3, etc)

        public string StringSplosion(string str)
        {
            string x = "";

            for (int i = 0; i < str.Length; i++)
            {
                    x += str.Substring(0, i + 1);
            }
            return x;
        }

        /* Given a string, return the count of the number of times that a substring length 2 appears 
        in the string and also as the last 2 chars of the string, so "hixxxhi" yields 1 
        (we won't count the end substring). */

        public int CountLast2(string str)
        {
            int counter = 0;
            string last2 = str.Substring(str.Length - 2, 2);

            for (int i = 0; i < str.Length - 2; i++)
            {
                if (str.Substring(i, 2) == last2)
                {
                    counter++;
                }
            }
            return counter;
        }

        // Given an array of ints, return the number of 9's in the array. 
        public int Count9(int[] numbers)
        {
            int counter = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i + 1] == 9)
                {
                    counter++;
                }
            }
            return counter;
        }

        /* Given an array of ints, return true if one of the first 
        4 elements in the array is a 9. The array length may be less than 4. */

        public bool ArrayFront9(int[] numbers)
        {
            for (int i = 0; i < 4; i++)
            {
                if (numbers[i] == 9)
                {
                    return true;
                }
            }
            return false;
        }

        // 10. Given an array of ints, return true if .. 1, 2, 3, .. appears in the array somewhere. 

        public bool Array123(int[] numbers)
        {
            int[] x = { 123 };

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 1 && i+1<numbers.Length && numbers[i+1] == 2 && i + 2 < numbers.Length && numbers[i+2] == 3)
                {
                    return true;
                }
            }
            return false;
        }

        /* Given 2 strings, a and b, return the number of the positions where they contain the 
        same length 2 substring. So "xxcaazz" and "xxbaaz" yields 3, since the "xx", "aa", 
        and "az" substrings appear in the same place in both strings. */

        public int SubStringMatch(string a, string b)
        {
            int counter = 0;

            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < b.Length - 1; j++)
                {
                    if (a.Substring(i, 2) == b.Substring(j, 2))
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        /* Given a string, return a version where all the "x" have been removed. Except an "x" at the 
        very start or end should not be removed. */

        public string StringX(string str)
        {
            string letterX = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (i == 0 && str[i] == 'x' || i == str.Length - 1 && str[i] == 'x')
                {
                    letterX += 'x';
                }
                else if (str[i] != 'x')
                {
                    letterX += str[i];
                }
            }
            return letterX;
        }

        // Given a string, return a string made of the chars at indexes 0,1, 4,5, 8,9 ... so "kittens" yields "kien". 

        public string AltPairs(string str)
        {
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                switch (i)
                {
                    case 0:
                    case 1:
                    case 4:
                    case 5:
                    case 8:
                    case 9:
                        result += str[i];
                        break;
                }
            }
            return result;
        }

        /* Suppose the string "yak" is unlucky. Given a string, return a version where all the "yak" 
        are removed, but the "a" can be any char. The "yak" strings will not overlap. */

        public string DoNotYak(string str)
        {
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str.Substring(i, 3) == "yak")
                {
                    return str.Replace("yak", "");
                }
            }
            return str;
        }

        /* 15. Given an array of ints, return the number of times that two 6's are next to each other in the array. 
        Also count instances where the second "6" is actually a 7. */

        public int Array667(int[] numbers)
        {
            int counter = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == 6 && numbers[i + 1] == 6)
                {
                    counter++;
                }
                else if (numbers[i] == 6 && numbers[i + 1] == 7)
                {
                    counter++;
                }
            }
            return counter;
        }

        /* Given an array of ints, we'll say that a triple is a value appearing 3 times in a row in the array. 
        Return true if the array does not contain any triples. */

        public bool NoTriples(int[] numbers)
        { 
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if (numbers[i] == numbers[i + 2] && numbers[i] == numbers[i + 2] && numbers[i + 1] == numbers[i + 2])
                {
                    return false;
                }
            }
            return true;
        }

        /* Given an array of ints, return true if it contains a 2, 7, 1 pattern -- a value, 
        followed by the value plus 5, followed by the value minus 1. */

        public bool Pattern51(int[] numbers)
        {
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i] + 5 == numbers[i + 1] && numbers[i] - 1 == numbers[i + 2])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
