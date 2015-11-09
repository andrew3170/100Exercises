using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.BLL
{
    public class Logic
    {
        /* When squirrels get together for a party, they like to have cigars. 
           A squirrel party is successful when the number of cigars is between 
           40 and 60, inclusive. Unless it is the weekend, in which case there is 
           no upper bound on the number of cigars. Return true if the party with 
           the given values is successful, or false otherwise. 
        */
        public bool GreatParty(int cigars, bool isWeekend)
        {
            if (isWeekend)
                return cigars > 40;
            else
                return (cigars >= 40 && cigars <= 60);
        }

        /* You and your date are trying to get a table at a restaurant. The parameter "you" is 
        the stylishness of your clothes, in the range 0..10, and "date" is the stylishness 
        of your date's clothes. The result getting the table is encoded as an int value with 
        0=no, 1=maybe, 2=yes. If either of you is very stylish, 8 or more, then the result is 
        2 (yes). With the exception that if either of you has style of 2 or less, then the 
        result is 0 (no). Otherwise the result is 1 (maybe). */

        public int CanHazTable(int yourStyle, int dateStyle)
        {
            if (yourStyle >= 8 || dateStyle >= 8)
            {
                return 2;
            }
            else if (yourStyle <= 2 || dateStyle <= 2)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        /* The children in Cleveland spend most of the day playing outside. In particular, they play if the 
        temperature is between 60 and 90 (inclusive). Unless it is summer, then the upper limit is 100 
        instead of 90. Given an int temperature and a bool isSummer, return true if the children play 
        and false otherwise. */

        public bool PlayOutside(int temp, bool isSummer)
        {
            if (!isSummer)
            {
                return (temp < 90 && temp > 60);
            }
            return (isSummer);
        }

        /* You are driving a little too fast, and a police officer stops you. Write code to 
        compute the result, encoded as an int value: 0=no ticket, 1=small ticket, 2=big ticket. I
        f speed is 60 or less, the result is 0. If speed is between 61 and 80 inclusive, the result 
        is 1. If speed is 81 or more, the result is 2. Unless it is your birthday -- on that day, 
        your speed can be 5 higher in all cases. */

        public int CaughtSpeeding(int speed, bool isBirthday)
        {
            if (isBirthday && speed > 80)
            {
                return 0;
            }
            else if (isBirthday && speed > 60 && speed < 81)
            {
                return 0;
            }
            else if (speed > 80)
            {
                return 2;
            }
            else if (speed > 60 && speed < 81)
            {
                return 1;
            }
            return 0;
        }

        /* 5. Given 2 ints, a and b, return their sum. However, sums in the range 10..19 
        inclusive are forbidden, so in that case just return 20. */

        public int SkipSum(int a, int b)
        {
            int sum = a + b;
            if (sum >= 10 && sum <= 19)
            {
                return 20;
            }
            return sum;
        }

        /* Given a day of the week encoded as 0=Sun, 1=Mon, 2=Tue, ...6=Sat, and a boolean 
        indicating if we are on vacation, return a string of the form "7:00" indicating 
        when the alarm clock should ring. Weekdays, the alarm should be "7:00" and on the 
        weekend it should be "10:00". Unless we are on vacation -- then on weekdays it 
        should be "10:00" and weekends it should be "off". */

        public string AlarmClock(int day, bool vacation)
        {
            if (day >= 1 && day <= 5 && !vacation)
            {
                return("7:00");
            }
            else if (day == 0 || day == 6 && !vacation)
            {
                return("10:00");
            }
            else if (day >= 1 && day <= 5 && vacation)
            {
                return("10:00");
            }
        return ("off");
        }

        /* The number 6 is a truly great number. Given two int values, a and b, return true if either one 
        is 6. Or if their sum or difference is 6. */

        public bool LoveSix(int a, int b)
        {
            if (a == 6 || b == 6)
            {
                return true;
            }
            else if (a + b == 6 || a - b == 6 || b - a == 6)
            {
                return true;
            }
            return false;
        }

        /*Given a number n, return true if n is in the range 1..10, inclusive. 
        Unless "outsideMode" is true, in which case return true if the number 
        is less or equal to 1, or greater or equal to 10. */

        public bool InRange(int n, bool outsideMode)
        {
            if (n <= 10 && n >= 1)
            {
                return true;
            }
            else if (outsideMode == true && n <= 1 || outsideMode == true && n >= 10)
            {
                return true;
            }
            else if (outsideMode != true)
            {
                return false;
            }
            return false;
        }

        /* We'll say a number is special if it is a multiple of 11 or if it is one more than a multiple of 11. 
        Return true if the given non-negative number is special. Use the % "mod" operator */

        public bool SpecialEleven(int n)
        {
            if (n % 11 == 0 || n % 11 == 1)
            {
                return true;
            }
            return false;
        }

        // 10. Return true if the given non-negative number is 1 or 2 more than a multiple of 20. See also: Introduction to Mod

        public bool Mod20(int n)
        {
            if (n % 20 == 1 || n % 20 == 2)
            {
                return true;
            }
            return false;
        }

        // Return true if the given non-negative number is a multiple of 3 or 5, but not both.Use the % "mod" operator

        public bool Mod35(int n)
        {
            if (n % 3 == 0 && n % 5 == 0)
            {
                return false;
            }
            else if (n % 3 == 0 || n % 5 == 0)
            {
                return true;
            }
            return false;
        }

        /* Your cell phone rings. Return true if you should answer it. Normally you answer, 
        except in the morning you only answer if it is your mom calling. In all cases, 
        f you are asleep, you do not answer. */

        public bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
        {
            if (isMorning)
            {
                return false;
            }
            if (isMom)
            {
                return true;
            }
            else if (isAsleep)
            {
                return false;
            }
            return true;
        }

        // Given three ints, a b c, return true if it is possible to add two of the ints to get the third. 

        public bool TwoIsOne(int a, int b, int c)
        {
            if (a + b == c || b + c == a || a + c == b)
            {
                return true;
            }
            return false;
        }

        /* Given three ints, a b c, return true if b is greater than a, and c is greater than b. 
        However, with the exception that if "bOk" is true, b does not need to be greater than a. */

        public bool AreInOrder(int a, int b, int c, bool bOk)
        {
            if (b > a && c > b)
            {
                return true;
            }
            else if (bOk == true && b <= a)
            {
                return true;
            }
            return false;
        }

        /* 15. Given three ints, a b c, return true if they are in strict increasing order, 
        such as 2 5 11, or 5 6 7, but not 6 5 7 or 5 5 7. However, with the exception 
        that if "equalOk" is true, equality is allowed, such as 5 5 7 or 5 5 5. */

        public bool InOrderEqual(int a, int b, int c, bool equalOk)
        {
            if (a < b && b < c)
            {
                return true;
            }
            else if (equalOk == true && a == b || b == c || a == c)
            {
                return true;
            }
            return false;
        }

        /* Given three ints, a b c, return true if two or more of them have the 
        same rightmost digit. The ints are non-negative. */

        public bool LastDigit(int a, int b, int c)
        {
            if (a % 10 == b % 10 || b % 10 == c % 10 || a % 10 == c % 10)
            {
                return true;
            }
            return false;
        }

        /* Return the sum of two 6-sided dice rolls, each in the range 1..6. However, if noDoubles is true, 
        if the two dice show the same value, increment one die to the next value, wrapping around to 1 
        if its value was 6. */

        public int RollDice(int die1, int die2, bool noDoubles)
        {
            if (noDoubles == true && die1 == die2)
            {
                die1++;
            }
            else if (die1 > 0 && die1 < 7 && die2 > 0 && die2 < 7)
            {
                return die1 + die2;
            }
            return die1 + die2;
        }
    }
}
