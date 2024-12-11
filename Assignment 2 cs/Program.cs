using System;

namespace Assignment_2_cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //   انا اختارت اعملها ب باقي القسمه عشان لو عدد صحيح هتبقي  بتقبل القسمه و لو عدد عشري تبقي مبتقبلش
            Console.Write("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            if (num1 % 3 == 0 && num1 % 4 == 0)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            #endregion

            //--------------------------------------------------------------------------------------------------------------------------

            #region 2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
                //لو اكبر من 0 يبقي موجب لو اصغر يبقي سالب  
            Console.Write("Enter a number: ");
            int num2 = int.Parse(Console.ReadLine());
            if (num2 < 0)
                Console.WriteLine("negative");
            else
                Console.WriteLine("positive");
            #endregion

            //--------------------------------------------------------------------------------------------------------------------------

            #region 3- Write a program that takes 3 integers from the user then prints the max element and the min element.
            
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            int c = int.Parse(Console.ReadLine());
            //هنعمل مقارنه بقي عشان نشوف مين اكبر من التاني 
            int maxNum = a;
            if (b > maxNum) maxNum = b;
            if (c > maxNum) maxNum = c;

            int minNum = a;
            if (b < minNum) minNum = b;
            if (c < minNum) minNum = c;

            Console.WriteLine("Max element = " + maxNum);
            Console.WriteLine("Min element = " + minNum);

            #endregion

            //--------------------------------------------------------------------------------------------------------------------------

            #region 4- Write a program that allows the user to insert an integer number then check If a number is even or odd.
            
            Console.Write("Enter a number: ");
            int num3 = int.Parse(Console.ReadLine());
            //لو باقي القسمه يساوي صفر يبقي موجب و لو اكتر يبقي سالب
            if (num3 % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
            #endregion

            //--------------------------------------------------------------------------------------------------------------------------

            #region 5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            
            Console.Write("Enter a character: ");
            char ch = char.Parse(Console.ReadLine().ToLower());
         
            if ("aeiou".Contains(ch))
                Console.WriteLine("Vowel");
            else
                Console.WriteLine("Consonant");
            #endregion

            //--------------------------------------------------------------------------------------------------------------------------

            #region 6- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            
            Console.Write("Enter a number: ");
            int num4 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num4; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(); 
            #endregion

            //--------------------------------------------------------------------------------------------------------------------------

            #region 7- Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            // دا عشان ندخل الرقم اللس عايزين نضربه 
            Console.Write("Enter a number: ");
            int num5 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                Console.Write(num5 * i + " ");
            }
            Console.WriteLine(); 
            #endregion

            //--------------------------------------------------------------------------------------------------------------------------

            #region 8- Write a program that allows to user to insert number then print all even numbers between 1 to this number.
            
            Console.Write("Enter a number: ");
            int num6 = int.Parse(Console.ReadLine());

            for (int i = 2; i <= num6; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(); 
            #endregion

            //--------------------------------------------------------------------------------------------------------------------------

            #region 9- Write a program that takes two integers then prints the power.
            // Program to calculate the power of two integers
            Console.Write("Enter base number: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.Write("Enter exponent: ");
            int exponent = int.Parse(Console.ReadLine());

            int result = (int)Math.Pow(baseNum, exponent);
            Console.WriteLine("Result: " + result);
            #endregion

            //--------------------------------------------------------------------------------------------------------------------------

            #region 10- Write a program to enter marks of five subjects and calculate total, average and percentage.
            // Program to calculate total, average, and percentage of five subjects
            Console.WriteLine("Enter marks of five subjects:");
            int[] marks = new int[5];
            int total = 0;

            for (int i = 0; i < 5; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
                total += marks[i];
            }

            double average = total / 5.0;
            double percentage = (total / 500.0) * 100;

            Console.WriteLine("Total marks = " + total);
            Console.WriteLine("Average Marks = " + average);
            Console.WriteLine("Percentage = " + percentage);
            #endregion

            //--------------------------------------------------------------------------------------------------------------------------

            #region 11- Write a program to input the month number and print the number of days in that month.
            
            Console.Write("Enter month number: ");
            int month = int.Parse(Console.ReadLine());

            switch (month)
            {
                //الشهور اللي فيها 31 يوم 
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Days in Month: 31");
                    break;
                    //الشهور اللي فيها 30 يوم 
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Days in Month: 30");
                    break;
                    //شهر فبراير 
                case 2:
                    Console.WriteLine("Days in Month: 28 or 29");
                    break;
                    //اي قيمه تانيه مش صح 
                default:
                    Console.WriteLine("Invalid month number");
                    break;
            }
            #endregion

            //--------------------------------------------------------------------------------------------------------------------------

            #region 12- Write a program to create a Simple Calculator.
           
            Console.WriteLine("Enter first number: ");
            double num7 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            double num8 = double.Parse(Console.ReadLine());
            //نكتب العمليات اللي هنشتغل عليها 
            Console.WriteLine("Select an operation (+, -, *, /): ");
            char operation = char.Parse(Console.ReadLine());

            double resultCalc = 0;

            switch (operation)
            {
                case '+':
                    resultCalc = num7 + num8;
                    break;
                case '-':
                    resultCalc = num7 - num8;
                    break;
                case '*':
                    resultCalc = num7 * num8;
                    break;
                case '/':
                    if (num8 != 0)
                        resultCalc = num7 / num8;
                    else
                        Console.WriteLine("Error it's Division by zero.");
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }

            Console.WriteLine("Result: " + resultCalc);
            #endregion
        }
    }
}
