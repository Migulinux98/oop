// first n Fibonacci Numbers
//exercise 5
using System;
 
class Test {
    // Method to print
    // first n Fibonacci Numbers
    static void printFibonacciNumbers(int n)
    {
        int f1 = 0, f2 = 1, i;
 
        if (n < 1)
            return;
        Console.Write(f1 + " ");
        for (i = 1; i < n; i++) {
            Console.Write(f2 + " ");
            int next = f1 + f2;
            f1 = f2;
            f2 = next;
        }
    }
 
    // Driver Code
    public static void Main()
    {
         printFibonacciNumbers(7);
    }
}