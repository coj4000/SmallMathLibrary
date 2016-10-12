using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class MathLib
    {
        // This method must return the "faculty" of n, also written n!,
        // where n! = n x (n-1) x (n-2) x ... x 2 x 1
        // Example: the "faculty" of 4 is 4! = 4 x 3 x 2 x 1 = 24
        // NB: If n < 1, then the faculty is 1
        //
        public int Faculty(int n)
        {
            // The variable result will hold the final result (i.e. the "faculty" of n)
            int result = 1;

            // For all values from n down to (and including) 1, do this:
            for (int i = n; i >= 1; i--)
            {
                result = result * i; // Result will be multiplied by n, then (n-1), etc.
            }

            return result;
        }

        // This method must return the sum of the numbers between
        // "start" and "end"
        // Example: If start = 3 and end = 7, the interval sum will
        // be 3 + 4 + 5 + 6 + 7 = 25;
        // NB: If start > end, the sum is 0 (zero)
        public int IntervalSum(int start, int end)
        {
            // The variable result will hold the final result 
            // (i.e. the interval sum from start to end)
            int result = 0;

            // For all values from start up to (and including) end, do this:
            for (int i = start; i <= end; i++)
            {
                result = result + i; // Will add start, then (start+1), etc.
            }

            return result;
        }

        // This method must return the highest square number
        // below the given limit limit
        // Example: If the limit is 20, the highest square below the
        // limit is 16 (the square of 4), since the next square 
        // (the square of 5) is 25.
        // NB: If the limit is zero or negative, return zero
        public int HighestSquareBelowLimit(int limit)
        {
            // First check that limit is positive
            if (limit > 0)
            {
                // This is the number we will square repeatedly
                int value = 0;

                // See if the next value (i.e. value + 1) will keep us
                // under the limit
                while ((value + 1) * (value + 1) < limit)
                {
                    // Still under limit, so increase to next value
                    value++;
                }

                // Since we have broken out of the loop, the next value
                // would make us go over the limit, so return the below.
                return (value * value);
            }
            else
            {
                // Return zero if limit is negative or zero
                return 0;
            }
        }


        // [DIFFICULT]
        // This method must return true if the given number is
        // a prime number, otherwise it should return false.
        // Tip: A prime number can only be divded by 1 and itself, so
        // dividing it with any other number will leave a remainder
        // NB: Negative numbers are not prime numbers
        public bool IsPrime(int n)
        {
            // All numbers below 2 are NOT primes
            if (n < 2)
            {
                return false;
            }
            else
            {
                // Assume that n is a prime, and try to disprove it
                bool isPrime = true;
                int value = 2;

                // Do this for all values from 2 up to (but not including) n
                while (value < n)
                {
                    if ((n % value) == 0) // In other words; n is divisable by value...
                    {
                        isPrime = false;  // ...then it follows that n is not a prime
                    }
                    value++;
                }

                return isPrime;
            }
        }
    }
}
