using System;

namespace Delegate
{
    delegate void MyDelegate(int number1, int number2);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegateAddition = new MyDelegate(Addition);
            myDelegateAddition.Invoke(1, 2);
            MyDelegate myDelegateSubtraction = new MyDelegate(Subtraction);
            myDelegateSubtraction.Invoke(3, 9);
            MyDelegate myDelegateMultiplication = new MyDelegate(Multiplication);
            myDelegateMultiplication.Invoke(9, 7);
            MyDelegate myDelegateDivision = new MyDelegate(Division);
            myDelegateDivision.Invoke(8, 4);

            Console.WriteLine("\nBasic Math Calculator!");
        }

        static void Addition(int number1, int number2)
        {
            Console.WriteLine(number1 + number2);
        }
        static void Subtraction(int number1, int number2)
        {
            Console.WriteLine(number1 - number2);
        }
        static void Multiplication(int number1, int number2)
        {
            Console.WriteLine(number1 * number2);
        }
        static void Division(int number1, int number2)
        {
            Console.WriteLine(number1 / number2);
        }

    }
}
