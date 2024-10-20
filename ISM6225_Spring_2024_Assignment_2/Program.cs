using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Find Missing Numbers in Array
            Console.WriteLine("Question 1:");
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> missingNumbers = FindMissingNumbers(nums1);
            Console.WriteLine(string.Join(",", missingNumbers));

            // Question 2: Sort Array by Parity
            Console.WriteLine("Question 2:");
            int[] nums2 = { 3, 1, 2, 4 };
            int[] sortedArray = SortArrayByParity(nums2);
            Console.WriteLine(string.Join(",", sortedArray));

            // Question 3: Two Sum
            Console.WriteLine("Question 3:");
            int[] nums3 = { 2, 7, 11, 15 };
            int target = 9;
            int[] indices = TwoSum(nums3, target);
            Console.WriteLine(string.Join(",", indices));

            // Question 4: Find Maximum Product of Three Numbers
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 2, 3, 4 };
            int maxProduct = MaximumProduct(nums4);
            Console.WriteLine(maxProduct);

            // Question 5: Decimal to Binary Conversion
            Console.WriteLine("Question 5:");
            int decimalNumber = 42;
            string binary = DecimalToBinary(decimalNumber);
            Console.WriteLine(binary);

            // Question 6: Find Minimum in Rotated Sorted Array
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 4, 5, 1, 2 };
            int minElement = FindMin(nums5);
            Console.WriteLine(minElement);

            // Question 7: Palindrome Number
            Console.WriteLine("Question 7:");
            int palindromeNumber = 121;
            bool isPalindrome = IsPalindrome(palindromeNumber);
            Console.WriteLine(isPalindrome);

            // Question 8: Fibonacci Number
            Console.WriteLine("Question 8:");
            int n = 4;
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine(fibonacciNumber);
        }

        // Question 1: Find Missing Numbers in Array
        public static IList<int> FindMissingNumbers(int[] nums)
        {
            try
            {
                List<int> result = new List<int>();
                int n = nums.Length;

                // Iterate through the array and mark the index of the corresponding number as negative
                for (int i = 0; i < n; i++)
                {
                    int val = Math.Abs(nums[i]) - 1;
                    if (nums[val] > 0)
                    {
                        nums[val] = -nums[val]; // Mark the number as seen
                    }
                }

                // After marking, the positive numbers' indices correspond to missing numbers
                for (int i = 0; i < n; i++)
                {
                    if (nums[i] > 0)
                    {
                        result.Add(i + 1); // Add the missing number
                    }
                }

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 2: Sort Array by Parity
        public static int[] SortArrayByParity(int[] nums)
        {
            try
            {
                // Create a new array to store sorted results
                int[] sortedArray = new int[nums.Length];
                int index = 0;

                // First, add all even numbers to the sorted array
                for (int i = 0; i < nums.Length; i++)
                {
                    // Check if the number is even
                    if (nums[i] % 2 == 0)
                    {
                        // Place the even number in the current position of sortedArray
                        sortedArray[index] = nums[i];
                        index++;
                    }
                }

                // Then, add all odd numbers to the sorted array
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] % 2 != 0)
                    {
                        // Place the odd number in the next position of sortedArray
                        sortedArray[index] = nums[i];
                        index++;
                    }
                }

                return sortedArray;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 3: Two Sum
        public static int[] TwoSum(int[] nums, int target)
        {
            try
            {
                // Write your code here
                // Create a dictionary to store numbers and their corresponding indices
                Dictionary<int, int> map = new Dictionary<int, int>();

                for (int i = 0; i < nums.Length; i++)
                {
                    // This is the value needed to reach the target when added to nums[i]
                    int complement = target - nums[i];

                    // Check if the complement exists in the dictionary
                    // If it does, we have found the two numbers that sum to the target
                    if (map.ContainsKey(complement))
                    {
                        // map[complement] gives us the index of the first number
                        // i is the index of the second number (current number)
                        return new int[] { map[complement], i }; // Return the indices of the two numbers
                    }

                    // Store the number and its index in the dictionary
                    if (!map.ContainsKey(nums[i]))
                    {
                        // Only store the number if it is not already present to maintain the last occurrence
                        map[nums[i]] = i;
                    }
                }

                return new int[] { -1, -1 }; // If no solution is found
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 4: Find Maximum Product of Three Numbers
        public static int MaximumProduct(int[] nums)
        {
            try
            {
                // Write your code here
                Array.Sort(nums); // Sort the array
                int n = nums.Length;

                // Return the maximum product of three numbers
                return Math.Max(nums[0] * nums[1] * nums[n - 1], nums[n - 1] * nums[n - 2] * nums[n - 3]);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 5: Decimal to Binary Conversion
        public static string DecimalToBinary(int decimalNumber)
        {
            try
            {
                // Write your code here
                return Convert.ToString(decimalNumber, 2); // Convert decimal to binary
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 6: Find Minimum in Rotated Sorted Array
        public static int FindMin(int[] nums)
        {
            try
            {
                Array.Sort(nums);
                return nums[0];
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 7: Palindrome Number
        public static bool IsPalindrome(int x)
        {
            try
            {
                // Write your code here
                if (x < 0) return false; // Negative numbers are not palindromes

                int rev = 0, ori = x;

                // Reverse the number
                while (x != 0)
                {
                    rev = rev * 10 + x % 10;
                    x /= 10;
                }

                return ori == rev; // Check if original and reversed numbers are the same
                
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 8: Fibonacci Number
        public static int Fibonacci(int n)
        {
            try
            {
                // Write your code here
                if (n <= 1) return n;

                int fib1 = 0, fib2 = 1;

                for (int i = 2; i <= n; i++)
                {
                    int temp = fib1 + fib2;
                    fib1 = fib2;
                    fib2 = temp;
                }

                return fib2;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
