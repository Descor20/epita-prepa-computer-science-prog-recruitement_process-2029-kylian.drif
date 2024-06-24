using System;


namespace My_TP
{
    public class Lists
    {
        // In this function you will search all of the Even numbers in the array passed in argument.
        // It will return a List of the numbers that are Even.
        // For this function, the use of iterators is recommended.
        public static List<int> Search_Even_Numbers(int[] array)
        {
            throw new NotImplementedException("not yet implemented");
        }
        
        // The function will sort the array pased in argument.
        // To do it properly for this function you will implement the insertion sort.
        // Because the function has no return type, you should modify the array in argument.
        // For this function, you should use the indexes.
        public static void Insert_Sort(int[] array)
        {
            throw new NotImplementedException("not yet implemented");
        }
        
        // The function iterates threw the array to check if the array respects the Fibonacci Sequence.
        // To remember the sequence, the first number is 0, then the second is 1, then for each number, the number
        // equals the number from one step before plus the number from two steps before.
        // If the array doesn't contain any number, the function should return true.
        // For this function it will be easier with the use of iterators.
        public static bool Is_Fibonacci(int[] array)
        {
            throw new NotImplementedException("not yet implemented");
        }
        
        // This function verify if the array passed in argument forms a Hill.
        // An array is a Hill if it respect multiples rules.
        // First a high limit is the highest number of the array.
        // Then an array which represent a hill should have for all the numbers at the left of the limit, the number at
        // it left, lower and the number at his right, higher.
        // For the numbers at the right of the hill limit, the number at their left should be higher and to their right
        // you will find a lower number.
        // The function will only return true if the array is representing a hill, else it will return false.
        // For this function the use of indexes will simplify your life.
        public static bool Is_Hill(int[] array)
        {
            throw new NotImplementedException("not yet implemented");
        }
        
        // Use the method of the Eratosthenes Sieve to look for prime numbers.
        // If you don't know how the Sieve works, look at : https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes
        // In this function you will look for all of the prime number lower than n passed in argument.
        // The function will return a list of primes numbers.
        // Remember that the 1 an 0 are not prime numbers.
        // For this function you should use a method with indexes.
        public static List<int> Eratosthenes_Sieve(int n)
        {
            throw new NotImplementedException("not yet implemented");
        }
    }
}