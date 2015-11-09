using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.BLL
{
    public class Strings
    {
        // Given a string name, e.g. "Bob", return a greeting of the form "Hello Bob!". 
        public string SayHi(string name)
        {
            return string.Format("Hello {0}!", name);
        }

        /* Given two strings, a and b, return the result of putting them together in the order abba, e.g. 
        "Hi" and "Bye" returns "HiByeByeHi". */ 
        public string ABBA(string a, string b)
        {
            return string.Format("{0}{1}{1}{0}", a, b);
        }

        /* The web is built with HTML strings like "<i>Yay</i>" which draws Yay as italic text. In this example, 
        the "i" tag makes<i> and</i> which surround the word "Yay". Given tag and word strings,
        create the HTML string with tags around the word, e.g. "<i>Yay</i>". */
        public string MakeTags(string tag, string content)
        {
            return string.Format("<{0}>{1}</{0}>", tag, content);
        }

        /* Given an "out" string length 4, such as "<<>>", and a word, return a new string where the word is in the 
        middle of the out string, e.g. "<<word>>". Hint: Substrings are your friend here */
        public string InsertWord(string container, string word)
        {
            string open = container.Substring(0, 2);
            string close = container.Substring(2, 2);
            return string.Format("{0}{1}{2}", open, word, close);
        }

        /* 5. Given a string, return a new string made of 3 copies of the last 2 chars of the original string. 
        The string length will be at least 2. */
        public string MultipleEndings(string str)
        {
            string lastTwoLetters = str.Substring((str.Length - 2), 2);
            return string.Format("{0}{0}{0}", lastTwoLetters);
        }

        //Given a string of even length, return the first half. So the string "WooHoo" yields "Woo". 
        public string FirstHalf(string str)
        {
            string firstPart = str.Substring(0, (str.Length/2));
            return string.Format(firstPart);
        }

        /* Given a string, return a version without the first and last char, so "Hello" yields "ell". 
        The string length will be at least 2. */
        public string TrimOne(string str)
        {
            string trimming = str.Substring(1, (str.Length - 2));
            return string.Format(trimming);
        }

        /* Given 2 strings, a and b, return a string of the form short+long+short, with the shorter string on the outside 
        and the longer string on the inside. The strings will not be the same length, but they may be empty (length 0). */
        public string LongInMiddle(string a, string b)
        {
            if (a.Length > b.Length)
            {
                return string.Concat(b + a + b);
            }
            else
            {
                return string.Concat(a + b + a);
            }
        }

        /* Given a string, return a "rotated left 2" version where the first 2 chars are moved to the end. 
        The string length will be at least 2. */
        public string Rotateleft2(string str)
        {
            string first2 = str.Substring(0, 2);
            string theRest = str.Substring(2, str.Length - 2);
            return string.Format(theRest + first2);
        }

        /* 10. Given a string, return a "rotated right 2" version where the last 2 chars are moved to the start. 
        The string length will be at least 2. */
        public string RotateRight2(string str)
        {
            string last2 = str.Substring((str.Length - 2), 2);
            string firstPart = str.Substring(0, str.Length - 2);
            return string.Format(last2 + firstPart);
        }

        /* Given a string, return a string length 1 from its front, unless front is false,
        in which case return a string length 1 from its back.The string will be non-empty. */
        public string TakeOne(string str, bool fromFront)
        {
            if (fromFront == true)
            {
                return (str.Substring(0, 1));
            }
            else
            {
                return (str.Substring((str.Length - 1), 1));
            }
        }

        /* Given a string of even length, return a string made of the middle two chars, so the string "string" yields "ri". 
        The string length will be at least 2. */

        public string MiddleTwo(string str)
        {
            return (str.Substring((str.Length/2-1), 2));
        }

        /* Given a string, return true if it ends in "ly". */

        public bool EndsWithLy(string str)
        {
            string lastTwoLetters = "ly";
            if (str.Length >= 2 && lastTwoLetters == (str.Substring((str.Length - 2), 2)))
            {
                return true;
            } 
            return false;
        }

        /* Given a string and an int n, return a string made of the first and last n chars from the string. 
        The string length will be at least n. */

        public string FrontAndBack(string str, int n)
        {
            return (str.Substring(0, n) + (str.Substring(str.Length - n, n)));
        }

        /* 15. Given a string and an index, return a string length 2 starting at the given index. 
        If the index is too big or too small to define a string length 2, use the first 2 chars. 
        The string length will be at least 2. */

        public string TakeTwoFromPosition(string str, int n)
        {
            if (n <= 2) {
                return (str.Substring(n, 2));
            }
            return (str.Substring(0, 2));
        }

        /* Given a string, return true if "bad" appears starting at index 0 or 1 in the string, such as with "badxxx" 
        or "xbadxx" but not "xxbadxx". The string may be any length, including 0. */

        public bool HasBad(string str)
        {
            string bad = "bad";
            if (str.Substring(0, 3) == bad)
            {
                return true;
            } 
            else if (str.Substring(1, 3) == bad)
            {
                return true;
            }
            return false;
        }

        /* Given a string, return a string length 2 made of its first 2 chars. If the string length is less than 2, 
        use '@' for the missing chars. */

        public string AtFirst(string str)
        {
            if (str.Length >= 2)
            {
                return str.Substring(0, 2);
            }
            else if (str.Length == 1)
            {
                return (str.Substring(0, 1)) + "@";
            }
            return "@@";
        }

        /* Given 2 strings, a and b, return a new string made of the first char of a and the last char of b, so "yo" 
        and "java" yields "ya". If either string is length 0, use '@' for its missing char. */

        public string LastChars(string a, string b)
        {
            if (a.Length == 0)
            {
                return "@" + b.Substring(0, 1);
            }
            else if (b.Length == 0)
            {
                return a.Substring(0, 1) + "@";
            }
            else if (a.Length > 0 || b.Length > 0)
            {
                return a.Substring(0, 1) + b.Substring(b.Length - 1, 1);
            }
            else
            {
                return a + b;
            }
        }

        /* Given two strings, append them together (known as "concatenation") and return the result. However, 
        if the concatenation creates a double-char, then omit one of the chars, so "abc" and "cat" yields "abcat". */

        public string ConCat(string a, string b)
        {
            string lastChar = a.Substring(a.Length - 1, 1);
            string firstChar = b.Substring(b.Length - 1, 1);
            if (lastChar == firstChar)
            {
                return a.Substring(0, a.Length - 1) + b;
            }
            return a + b;
        }

        /* 20. Given a string of any length, return a new string where the last 2 chars, if present, are swapped, 
        so "coding" yields "codign". */

        public string SwapLast(string str)
        {
            string lastLetter = str.Substring(str.Length - 1, 1);
            string secondToLastLetter = str.Substring(str.Length - 2, 1);
            return str.Substring(0, str.Length - 2) + lastLetter + secondToLastLetter;
        }

        /* Given a string, return true if the first 2 chars in the string also appear at the end of the string, 
        such as with "edited". */

        public bool FrontAgain(string str)
        {
            string firstTwo = str.Substring(0, 2);
            string lastTwo = str.Substring(str.Length - 2, 2);
            if (firstTwo == lastTwo)
            {
                return true;
            }
            return false;
        }

        /* Given two strings, append them together (known as "concatenation") and return the result. However, 
        if the strings are different lengths, omit chars from the longer string so it is the same length as the 
        shorter string. So "Hello" and "Hi" yield "loHi". The strings may be any length. */

        public string MinCat(string a, string b)
        {
            if (a.Length > b.Length)
            {
                return a.Remove(0, (a.Length - b.Length)) + b;
            }
            else if (b.Length > a.Length)
            {
                return a + b.Remove(0, (b.Length - a.Length));
            }
            return a + b;
        }

        /* Given a string, return a version without the first 2 chars. Except keep the first char if it is 
        'a' and keep the second char if it is 'b'. The string may be any length. */

        public string TweakFront(string str)
        {
            if (str.Substring(0, 1) == "a" && str.Substring(1, 1) == "b")
            {
                return str;
            }
            else if (str.Substring(0, 1) == "a")
            {
                return (str.Substring(0, 1) + str.Substring(2, str.Length - 2));
            }
            else if (str.Substring(1, 1) == "b")
            {
                return (str.Substring(1, 1) + str.Substring(2, str.Length - 2));
            }
            return str.Substring(2, str.Length - 2);
        }

        /* Given a string, if the first or last chars are 'x', return the string without those 'x' 
        chars, and otherwise return the string unchanged.  */

        public string StripX(string str)
        {
            if (str.Substring(0, 1) == "x" && str.Substring(str.Length - 1, 1) == "x")
            {
                return (str.Substring(1, str.Length - 2));
            }
            else if (str.Substring(0, 1) == "x")
            {
                return str.Substring(1, str.Length - 1);
            }
            else if (str.Substring(str.Length - 1, 1) == "x")
            {
                return str.Substring(0, str.Length - 1);
            }
            return str;
        }
    }
}
