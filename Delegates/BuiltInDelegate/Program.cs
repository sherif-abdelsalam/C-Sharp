using System;
using System.Collections.Generic;

namespace DelegateExamples
{
    // Step 1: Declare a custom delegate for operations on two integers
    public delegate int Operation(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Using Delegate (Add and Multiply)
            Console.WriteLine("=== Delegate Example ===");
            Operation operation = Add; // Assign Add method
            Console.WriteLine("Add: " + operation(10, 20));  // Output: 30

            operation = Multiply; // Reassign to Multiply method
            Console.WriteLine("Multiply: " + operation(10, 20));  // Output: 200


            // Example 2: Using Func (Addition and String Length)
            Console.WriteLine("\n=== Func Example ===");
            Func<int, int, int> addFunc = (x, y) => x + y;
            Console.WriteLine("Func Add: " + addFunc(15, 25));  // Output: 40

            Func<string, int> lengthFunc = str => str.Length;
            Console.WriteLine("Func String Length: " + lengthFunc("Hello, World!"));  // Output: 13

            // Example 3: Using Action (Print messages)
            Console.WriteLine("\n=== Action Example ===");
            Action<string> printAction = message => Console.WriteLine("Action Print: " + message);
            printAction("This is an Action delegate!");  // Output: Action Print: This is an Action delegate!

            Action greetAction = () => Console.WriteLine("Action: Greetings from Action delegate!");
            greetAction();  // Output: Action: Greetings from Action delegate!

            // Example 4: Using Predicate (Check Even and String Null or Empty)
            Console.WriteLine("\n=== Predicate Example ===");
            Predicate<int> isEven = num => num % 2 == 0;
            Console.WriteLine("Is 10 even? " + isEven(10));  // Output: True
            Console.WriteLine("Is 11 even? " + isEven(11));  // Output: False

            Predicate<string> isNullOrEmpty = str => string.IsNullOrEmpty(str);
            Console.WriteLine("Is empty string null or empty? " + isNullOrEmpty(""));  // Output: True
            Console.WriteLine("Is 'Hello' null or empty? " + isNullOrEmpty("Hello"));  // Output: False

            // Real-world example: Using all in combination
            Console.WriteLine("\n=== Real-world Example ===");

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // Use Predicate to find all even numbers
            List<int> evenNumbers = numbers.FindAll(n => n % 2 == 0);

            Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));  // Output: 2, 4, 6, 8, 10

            // Use Func to calculate squares
            List<int> squaredNumbers = numbers.ConvertAll(n => n * n);

            Console.WriteLine("Squared numbers: " + string.Join(", ", squaredNumbers));  // Output: 1, 4, 9, 16, ...

            // Use Action to print each squared number
            squaredNumbers.ForEach(n => Console.WriteLine("Squared number: " + n));

        }

        // Delegate method examples
        static int Add(int a, int b) => a + b;
        static int Multiply(int a, int b) => a * b;
    }
}
