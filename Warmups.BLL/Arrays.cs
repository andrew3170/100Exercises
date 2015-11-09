using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.BLL
{
    public class Arrays
    {
        /* Given an array of ints, return true if 6 appears 
           as either the first or last element in the array. 
           The array will be length 1 or more. 
        */
        public bool FirstLast6(int[] numbers)
        {
            // 0 is always the first index and 
            // Length - 1 of an array is always the last index
            return (numbers[0] == 6 || numbers[numbers.Length - 1] == 6);
        }

        /* Given an array of ints, return true if the array is length 1 or more, and the first element and the last 
        element are equal. */

        public bool SameFirstLast(int[] numbers)
        {
            return (numbers.Length - 1 >= 1 && numbers[0] == numbers[numbers.Length - 1]);
        }

        // Return an int array length n containing the first n digits of pi.

        public int[] MakePi(int n)
        {
            double pi = Math.PI;
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = (int) Math.Floor(pi);
                pi -= result[i];
                pi *= 10;
            }
            return result;
        }

        /* Given 2 arrays of ints, a and b, return true if they have the same first element 
        or they have the same last element. Both arrays will be length 1 or more. */

        public bool commonEnd(int[] a, int[] b)
        {
            return (a[0] == b[0] || a[a.Length - 1] == b[b.Length - 1]);
        }

        // 5. Given an array of ints, return the sum of all the elements.

        public int Sum(int[] numbers)
        {
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                counter += numbers[i];
            }
            return counter;
        }

        // Given an array of ints, return an array with the elements "rotated left" so {1, 2, 3} yields {2, 3, 1}.

        public int[] RotateLeft(int[] numbers)
        {
            int[] result = new int[numbers.Length];

            for (int i = 1; i < numbers.Length; i++)
            {
                result[i-1] = numbers[i];
            }
            result[numbers.Length - 1] = numbers[0];
            return result;
        }

        /* Given an array of ints length 3, return a new array with the elements in 
        reverse order, so for example {1, 2, 3} becomes {3, 2, 1}. */

        public int[] Reverse(int[] numbers)
        {
            int[] result = new int[numbers.Length];

            for (int i = numbers.Length - 1; i > -1; i--)
            {
                result[numbers.Length - 1 - i] = numbers[i];
            }
            return result;
        }

        /* Given an array of ints, figure out which is larger between the first and last elements in the array,
        and set all the other elements to be that value. Return the changed array. */

        public int[] HigherWins(int[] numbers)
        {
            int[] result = new int[numbers.Length];
             
            if (numbers[0] > numbers[numbers.Length - 1])
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    result[i] = numbers[0];
                }   
            }
            else if (numbers[numbers.Length - 1] > numbers[0])
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    result[i] = numbers[numbers.Length - 1];
                }            
            }
            return result;
        }

        // Given 2 int arrays, a and b, each length 3, return a new array length 2 containing their middle elements.

        public int[] GetMiddle(int[] a, int[] b)
        {
            int[] result = new int[2];

            result[0] = a[1];
            result[1] = b[1];

            return result;
        }

        // 10. Given an int array , return true if it contains an even number (HINT: Use Mod (%)).

        public bool HasEven(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        /* Given an int array, return a new array with double the length where its last element is 
        the same as the original array, and all the other elements are 0. The original array will 
        be length 1 or more. Note: by default, a new int array contains all 0's. */

        public int[] KeepLast(int[] numbers)
        {
            int[] result = new int[numbers.Length * 2];

            result[result.Length - 1] = numbers[numbers.Length - 1];

            return result;
        }

        // Given an int array, return true if the array contains 2 twice, or 3 twice.

        public bool Double23(int[] numbers)
        {
            int counterFor2s = 0;
            int counterFor3s = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == 2)
                {
                    counterFor2s++;
                }
                else if (numbers[i] == 3)
                {
                    counterFor3s++;
                }
            }
            if (counterFor2s == 0 || counterFor3s == 0)
            {
                return true;
            }
            return false;
        }

        /* Given an int array length 3, if there is a 2 in the array immediately followed by a 3,
        set the 3 element to 0. Return the changed array. */

        public int[] Fix23(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == 2 && numbers[i + 1] == 3)
                {
                    numbers[i + 1] = 0;
                }
            }
            return numbers;
        }

        /* We'll say that a 1 immediately followed by a 3 in an array is an "unlucky" 1. 
        Return true if the given array contains an unlucky 1 in the first 2 or last 2 positions in the array. */

        public bool Unlucky1(int[] numbers)
        {

            if (numbers[0] == 1 && numbers[1] == 3)
            {
                return true;
            }
            else if (numbers[1] == 1 && numbers[2] == 3)
            {
                return true;
            }
            else if (numbers[numbers.Length - 2] == 1 && numbers[numbers.Length - 1] == 3)
            {
                return true;
            }
            return false;
        }

        /* Given 2 int arrays, a and b, return a new array length 2 containing, as much as will fit, 
        the elements from a followed by the elements from b. The arrays may be any length, including 0, 
        but there will be 2 or more elements available between the 2 arrays. */

        public int[] make2(int[] a, int[] b)
        {
            int[] result = new int[2];

                if (a.Length == 2)
                {
                    result = a;
                }
                else if (a.Length == 1 && b.Length > 0)
                {
                    result[0] = a[0];
                    result[1] = b[0];
                }
                else if (a.Length < 1 && b.Length > 0)
                {
                    result = b;
            }
            return result;
        }
    }
}
