using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Text;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.WriteLine("enter your integer");
            //int.TryParse(Console.ReadLine(), out int a);
            //for (int i = 1; i <= a; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region 2- Write a program that allows the user to insert an integer then print a multiplication table up to 12.

            //Console.WriteLine("enter your integer");
            //int.TryParse(Console.ReadLine(), out int b);
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine($"{i}*{b} ={i*b}");
            //}
            #endregion

            #region 3- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Console.WriteLine("enter your integer");
            //int.TryParse(Console.ReadLine(), out int c);

            //for (int i = 1; i <= c; i++)
            //{
            //    if((i % 2) == 0)    
            //    Console.WriteLine(i);
            //}
            #endregion

            #region 4- Write a program that takes two integers then prints the power.
            //Console.WriteLine("enter your integer");
            //int.TryParse(Console.ReadLine(), out int d);

            //Console.WriteLine("enter your 2nd integer");
            //int.TryParse(Console.ReadLine(), out int f);

            //Console.WriteLine(Math.Pow(d,f));
            #endregion

            #region 5- Write a program to enter marks of five subjects and calculate total, average and percentage.
            //Console.Write("Enter the first : ");
            //int num7 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the second : ");
            //int num8 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the third : ");
            //int num9 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the fourth: ");
            //int num10 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the fifth : ");
            //int num11 = Convert.ToInt32(Console.ReadLine());

            //int a = (num7 + num8 + num9 + num10 + num11) / 5;
            //Console.WriteLine($"average is {a}");

            //int t = (num7 + num8 + num9 + num10 + num11);
            //Console.WriteLine($"total marks is {t}");

            //int p = ((num7 + num8 + num9 + num10 + num11)*100)/t;
            //Console.WriteLine($"percentage marks is {p}");
            #endregion

            #region 6- Write a program to input the month number and print the number of days in that month.

            //Console.WriteLine("enter your month number :");
            //int.TryParse(Console.ReadLine(), out int chars);
            //switch (chars)
            //{
            //    case 1:
            //        Console.WriteLine("31");
            //        break;

            //    case 2:
            //        Console.WriteLine("28");
            //        break;


            //    case 3:
            //        Console.WriteLine("31");
            //        break;

            //    case 4:
            //        Console.WriteLine("30");
            //        break;

            //    case 5:
            //        Console.WriteLine("31");
            //        break;
            //    case 6:
            //        Console.WriteLine("30");
            //        break;

            //    case 7:
            //        Console.WriteLine("31");
            //        break;


            //    case 8:
            //        Console.WriteLine("31");
            //        break;

            //    case 9:
            //        Console.WriteLine("30");
            //        break;

            //    case 10:
            //        Console.WriteLine("31"); break;
            //    case 11:
            //        Console.WriteLine("30");
            //        break;

            //    case 12:
            //        Console.WriteLine("31"); break;
            //    default:
            //        Console.WriteLine("not found");
            //        break;

            #endregion

            #region 7- Write a program to create a Simple Calculator.

            //int num1, num2;
            //string operation;
            //    Console.Write("Enter the first number: ");
            //    num1 = int.Parse(Console.ReadLine());


            //    Console.Write("Enter the second number: ");
            //    num2 = int.Parse(Console.ReadLine());


            //    Console.Write("Enter an operation (+, -, *, /): ");
            //    operation = Console.ReadLine();


            //    switch (operation)
            //    {
            //        case "+":
            //            Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
            //            break;
            //        case "-":
            //            Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
            //            break;
            //        case "*":
            //            Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
            //            break;
            //        case "/":
            //            if (num2 != 0)
            //            {
            //                Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Error: Division by zero is not allowed.");
            //            }
            //            break;
            //        default:
            //            Console.WriteLine("Invalid operation. Please enter one of the following: +, -, *, /");
            //            break;
            //}
            #endregion
            #region 8- Write a program to allow the user to enter int and print the REVERSED of it.

            //Console.Write("Enter an integer: ");
            //int.TryParse(Console.ReadLine(), out int result);   
            //int reversedNumber = 0;
            //for (int temp = result; temp != 0; temp /= 10)
            //{
            //    int digit = temp % 10;
            //    reversedNumber = reversedNumber * 10 + digit;
            //}              
            //Console.WriteLine($"Reversed integer: {reversedNumber}");


            #endregion

            #region 9- Write a program in C# Sharp to find prime numbers within a range of numbers.
            //Console.WriteLine("enter your integer");
            //int.TryParse(Console.ReadLine(), out int l);

            //if (l%l==0 && (l/1)==l)
            //{
            //    Console.WriteLine(" is prime number");

            //}
            //else
            //    Console.WriteLine("not prime number");
            #endregion

            #region 10- . Write a program in C# Sharp to convert a decimal number into binary without using an array.

                //Console.Write("Enter a decimal number: ");
                //int decimalNumber = Convert.ToInt32(Console.ReadLine());

                //if (decimalNumber == 0)
                //{
                //    Console.WriteLine("Binary: 0");
                //    return;
                //}

                
                //StringBuilder binary = new StringBuilder();

                
                //while (decimalNumber > 0)
                //{
                //    int remainder = decimalNumber % 2;
                //    binary.Insert(0, remainder); 
                //    decimalNumber /= 2;
                //}

               
                //Console.WriteLine($"Binary: {binary.ToString()}");
          
        #endregion
    }
}
}
