using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Warmups.BLL
{
    public class Conditionals
    {
        /* We have two children, a and b, and the parameters aSmile and 
           bSmile indicate if each is smiling. We are in trouble if they 
           are both smiling or if neither of them is smiling. Return true 
           if we are in trouble. 
        */

        public bool AreWeInTrouble(bool aSmile, bool bSmile)
        {
            if (aSmile && bSmile)
                return true;

            if (!aSmile && !bSmile)
                return true;

            return false;
        }

        /* The parameter weekday is true if it is a weekday, and the parameter vacation is true if we are on vacation. 
        We sleep in if it is not a weekday or we're on vacation. Return true if we sleep in. */

        public bool CanSleepIn(bool isWeekday, bool isVacation)
        {
            if (isWeekday || isVacation)
                return false;

            return true;
        }

        // Given two int values, return their sum. However, if the two values are the same, then return double their sum. 

        public int SumDouble(int a, int b)
        {
            if (a == b)
                return (a + b)*2;

            return a + b;
        }

        /* Given an int n, return the absolute value of the difference between n and 21, except return double the 
        absolute value of the difference if n is over 21. */

        public int Diff21(int n)
        {
            int absoluteValue = Math.Abs(n - 21);
            if (n > 21)
                return absoluteValue*2;

            return absoluteValue;
        }

        /* 5. We have a loud talking parrot. The "hour" parameter is the current hour time in the range 0..23. 
        We are in trouble if the parrot is talking and the hour is before 7 or after 20. Return true if we are in trouble. */

        public bool ParrotTrouble(bool isTalking, int hour)
        {
            if (isTalking && (hour < 7 || hour > 20))
            {
                return true;
            }
            return false;
        }

        // Given two ints, a and b, return true if one if them is 10 or if their sum is 10.
        public bool Makes10(int a, int b)
        {
            if (a == 10 || b == 10 || a + b == 10)
            {
                return true;
            }
            return false;
        }

        /* Given an int n, return true if it is within 10 of 100 or 200.
        Hint: Check out the C# Math class for absolute value */

        public bool NearHundred(int n)
        {
            if (n > 89 && n < 111 || n > 189 && n < 211)
            {
                return true;
            }
            return false;
        }

        /* Given two int values, return true if one is negative and one is positive. Except if the parameter 
        "negative" is true, then return true only if both are negative. */

        public bool PosNeg(int a, int b, bool negative)
        {
            if (a >= 0 && b < 0 || a < 0 && b >= 0)
            {
                return true;
            }
            else if (negative && a < 0 && b < 0)
            {
                return true;
            }
            return false;
        }

        /* Given a string, return a new string where "not " has been added to the front. 
        However, if the string already begins with "not", return the string unchanged.
        Hint: Look up how to use "SubString" in c# */

        public string NotString(string s)
        {
            if (s.Length > 2 && s.Substring(0, 3) == "not")
            {
                return s;
            }
            return "not " + s;
        }

        /* 10. Given a non-empty string and an int n, return a new string where the char at index n has been removed. 
        The value of n will be a valid index of a char in the original string (Don't check for bad index). */

        public string MissingChar(string str, int n)
        {
            str = str.Remove(n, 1);
            return str;
        }

        // Given a string, return a new string where the first and last chars have been exchanged.

        public string FrontBack(string str)
        {
            string firstLetter = str.Substring(0, 1);
            string lastLetter = str.Substring(str.Length - 1, 1);
            
            if (str.Length < 2)
            {
                return str;
            }
            else if (str.Length == 2)
            {
                return lastLetter + firstLetter;
            }

            string middle = str.Substring(1, str.Length - 2);

            return lastLetter + middle + firstLetter;
        }

        /* Given a string, we'll say that the front is the first 3 chars of the string. If the string length is 
        less than 3, the front is whatever is there. Return a new string which is 3 copies of the front. */
        
        public string Front3(string str)
        {
            string frontChars = str.Substring(0, str.Length);

            if (str.Length < 3)
            {
                return frontChars + frontChars + frontChars;
            }

            string front3Chars = str.Substring(0, 3);

            return front3Chars + front3Chars + front3Chars;
        }

        /* Given a string, take the last char and return a new string with the last char added at 
        the front and back, so "cat" yields "tcatt". The original string will be length 1 or more. */

        public string BackAround(string str)
        {
            string lastChar = str.Substring(str.Length - 1, 1);

            return lastChar + str + lastChar;
        }

        // Return true if the given non-negative number is a multiple of 3 or a multiple of 5. Use the % "mod" operator

        public bool Multiple3or5(int number)
        {
            if (number%3 == 0 || number%5 == 0)
            {
                return true;
            }
            return false;
        }

        // 15. Given a string, return true if the string starts with "hi" and false otherwise.

        public bool StartHi(string str)
        {
            if (str.Length < 3 && str.Substring(0, 2) == "hi")
            {
                return true;
            }
            else if (str.Substring(0, 3) == "hi ")
            {
                return true;
            }
            return false;
        }

        // Given two temperatures, return true if one is less than 0 and the other is greater than 100.

        public bool IcyHot(int temp1, int temp2)
        {
            if (temp1 < 0 || temp2 > 100 && temp2 < 0 || temp1 > 100)
            {
                return true;
            }
            return false;
        }

        // Given 2 int values, return true if either of them is in the range 10..20 inclusive.

        public bool Between10and20(int a, int b)
        {
            if (a > 9 && a < 21 || b > 9 && b < 21)
            {
                return true;
            }
            return false;
        }

        /* We'll say that a number is "teen" if it is in the range 13..19 inclusive. Given 3 int values, 
        return true if 1 or more of them are teen. */

        public bool HasTeen(int a, int b, int c)
        {
            if (a > 12 && a < 20 || b > 12 && b < 20 || c > 12 && c < 20)
            {
                return true;
            }
            return false;
        }

        /* We'll say that a number is "teen" if it is in the range 13..19 inclusive. 
        Given 2 int values, return true if one or the other is teen, but not both. */

        public bool SoAlone(int a, int b)
        {
            if (a > 12 && a < 20 && b > 12 && b < 20)
            {
                return false;
            }
            else if (a > 12 && a < 20)
            {
                return true;
            }
            else if (b > 12 && b < 20)
            {
                return true;
            }
            return false;
        }

        /* 20. Given a string, if the string "del" appears starting at index 1, return a string where that "del" has been deleted.
        Otherwise, return the string unchanged. */

        public string RemoveDel(string str)
        {
            //string strDel == "del";

            if (str.Substring(1, 3) == "del")
            {
                return str.Remove(1, 3);
            }
            return str;
        }

        // Return true if the given string begins with "*ix", the '*' can be anything, so "pix", "9ix" .. all count.

        public bool IxStart(string str)
        {
            if (str.Substring(1, 2) == "ix")
            {
                return true;
            }
            return false;
        }

        /* Given a string, return a string made of the first 2 chars (if present), however include first char only 
        if it is 'o' and include the second only if it is 'z', so "ozymandias" yields "oz". */

        public string StartOz(string str)
        {
            if (str.Substring(0, 2) == "oz")
            {
                return "oz";
            }

            else if (str.Substring(0, 1) == "o")
            {
                return "o";
            }
            else if (str.Substring(1, 1) == "z")
            {
                return "z";
            }
            return str;
        }

        // Given three int values, a b c, return the largest. 

        public int Max(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > a && b > c)
            {
                return b;
            }
            return c;
        }

        // Given 2 int values, return whichever value is nearest to the value 10, or return 0 in the event of a tie.

        public int Closer(int a, int b)
        {
            if (Math.Abs(a - 10) < Math.Abs(b - 10))
            {
                return a;
            }
            else if (Math.Abs(b - 10) < Math.Abs(a - 10))
            {
                return b;
            }
            else if (Math.Abs(b - 10) == Math.Abs(a - 10))
            {
                return 0;
            }
            return 1;
        }

        // 25. Return true if the given string contains between 1 and 3 'e' chars.

        public bool GotE(string str)
        {
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str.Substring(i, 1) == "e")
                {
                    counter++;
                }
            }
            if (counter < 4 && counter > 0)
            {
                return true;
            }
            return false;
        }

        /* Given a string, return a new string where the last 3 chars are now in upper case. 
        If the string has less than 3 chars, uppercase whatever is there. */

        public string EndUp(string str)
        {
            if (str.Length < 4)
            {
                return str.ToUpper();
            }
            else if (str.Length > 3)
            {
                return str.Substring(0, str.Length - 3) + str.Substring(str.Length - 3, 3).ToUpper();
            }
            return str;
        }

        /* Given a non-empty string and an int N, return the string made starting with char 0, and then every 
        Nth char of the string. So if N is 3, use char 0, 3, 6, ... and so on. N is 1 or more. */

        public string EveryNth(string str, int n)
        {
            string result = "";

            for (int i = 0; i < str.Length; i += n)
            {
                result += str.Substring(i, 1);
            }
            return result;
        }
    }
}
