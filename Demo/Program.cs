using System;
using System.Drawing;

namespace Demo
{
    internal class Program
    {
        static void Main()
        {
            #region Variables
            // Variable Declaration
            // DataType + Variable Name;
            // int Number = 5; // Declare Variable and initialize it
            // int number1 = 2, number2 = 4, number3 = 6; // Declare and initialize multiple variables
            // number1 = 7;
            // Console.WriteLine(number1);

            // Variable Information:
            // Name: number1
            // DataType: int
            // Size: 4 bytes
            // Value: Initially 2, then reassigned to 7

            // Allocate Uninitialized 4 bytes in memory
            // Console.WriteLine(Number);
            #endregion

            #region DataTypes_with_values
            // DataTypes
            // int num1; // Allocate uninitialized 4 bytes at stack
            // num1 = 13;
            // Console.WriteLine(num1);

            // Int32 num4; // Int32 is equivalent to int
            // num4 = 25;
            // Console.WriteLine(num4);
            #endregion

            #region DataTypes_with_References
            // Reference Types
            // Point p1; // Declare reference from type Point (allocated at stack, no memory in heap yet)
            // p1 = new Point(); // Allocate memory at heap and initialize
            // Console.WriteLine(p1.X);
            // Console.WriteLine(p1.Y);

            // Point p2 = new Point { X = 12 }; // Initialize Point with X value
            // Console.WriteLine(p2.X);

            // Assign references
            // p1 = p2; // Both p1 and p2 now refer to the same object
            // Console.WriteLine(p1.X);
            // Console.WriteLine(p2.X);
            #endregion

            #region Objects
            // object h1; // Declare a reference from type 'object'
            // h1 = new object();
            // h1 = 1;
            // h1 = 'A';
            // h1 = 1.2;
            // h1 = true;
            // h1 = new Point();
            // Console.WriteLine(h1);
            // Console.WriteLine(h1.GetHashCode()); // ID: indicates the address of the object

            // Point p3 = new Point();
            // Console.WriteLine(p3.GetType());
            // Console.WriteLine(p3.ToString());
            // Console.WriteLine(p3.GetHashCode());
            // Console.WriteLine(p3.Equals(new Point()));
            #endregion

            #region Casting
            // Implicit Casting (Safe)
            // int x = 5;
            // double y = x;
            // Console.WriteLine(y);

            // Explicit Casting (Unsafe)
            // double x1 = 2.5;
            // int y1 = (int)x1;
            // Console.WriteLine(y1);

            // long x2 = 111111111111111111;
            // int y2 = (int)x2; // Data loss may occur
            // Console.WriteLine(y2);
            // Console.WriteLine(int.MaxValue);
            #endregion

            #region Parse_try_catch
            // Parse: Function
            //Console.WriteLine("Enter Your Age: ");
            //int Age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Your GPA: ");
            //double GPA = double.Parse(Console.ReadLine());
            //Console.WriteLine("Age: M Age);
            //Console.WriteLine("GPA: + GPA);

            // Convert: Class
            // Console.WriteLine(value: "Enter Your Age: ");
            // int Age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Your GPA: ");
            //double GPA = double.Parse(Console.ReadLine());
            //Console.WriteLine("Age: " + Age);
            //Console.WriteLine("GPA: " + GPA);

            // TryParse
            // Console.WriteLine(value: "Enter Your Age: ");
            // int Age;
            // bool Flag int.TryParse(Console.ReadLine(), out Age);
            //Console.WriteLine("Enter Your GPA: ");
            //double GPA = double. Parse(Console.ReadLine());
            //Console.WriteLine("Age " + Age);
            //Console.WriteLine("Flag:" + Flag);
            #endregion


            #region FarctionAndDiscard
            //double X = 1.5;
            //float Y = 1.5F;
            //decimal Z = 1.5m;
            // int X = 1_000_000_000; // Discard
            // Console.WriteLine(X);
            #endregion


            #region Operators
            // 1. Unary Operators -> Works On One Operand (Variable) ++
            //int X = 10; I
            // ++
            ///// PreFix [Increment then print] //Console.WriteLine(++X); // 11
            ///// PostFix [Print then Increment]
            //Console.WriteLine(X++); // 10
            //Console.WriteLine(X); // 11

            ///// PreFix [decrement then print]
            //Console.WriteLine(--X); // 9 //// PostFix [Print then decrement]
            //Console.WriteLine(); // 10
            //Console.WriteLine(X); // 9


            //=============================================
            // 2. Binary Operators Works on Two Operands (Variables
            // + = /* %
            //int Sum, Mul, Sub, Mod;
            //int Number01 = 2, Number02 = 6;
            //Sum = Number01 + Number02; // 8
            //Mul = Number01 * Number02; // 12
            //Sub = Number01 - Number02; // -4
            //Mod = Number01 % Number02; // 2
            // 23 % 3 = 2
            //====================================================

            // 3. Assignment Operators
            //int X;
            //X = 4;
            //X += 2; // X = X + 2 // 6
            //X -= 2;
            // X = X - 2
            //X *= 2; // X = X * 2
            //X /= 2; // X = X / 2
            //X %= 2; // X = X % 2
            //====================================================
            // 4. Relational Operators [Comparsion」
            //int X = 6, Y = 5;
            //Console.WriteLine(X == Y);
            //Console.WriteLine(X != Y);
            //Console.WriteLine(X > Y);
            //Console.WriteLine(X < Y);
            //Console.WriteLine(X >= Y);
            //Console.WriteLine(X <= Y);
            //==========================================
            // 5. Logical Operators [AND OR, NOT]
            // Console.WriteLine(!false); // ! -> Not
            //Console.WriteLine(false && true); // && -> AND Short Circuit
            //Console.WriteLine(true || false); // || -> OR Short Circuit
            //========================================
            //6. BitWise Operators
            //Console.WriteLine(!false); // ! -> Not
            //Console.WriteLine(false & true); // && -> AND Long Circuit
            //Console.WriteLine(false | true); // || -> OR Long Circuit
            //=====================================================
            // 7. Ternary Operator [Conditional Operator]
            //bool flag = 4 > 2;
            //Console.WriteLine(flag);

            //string flag = 4 < 2 ? "Correct" : "Not Correct";
            //Console.WriteLine(flag);
            #endregion


            #region Operator_Piriority

            /*
            1. Unary Operator (PreFix)
            2. Round Braces
            3. * / %
            4. +
            */
            //int a = 20;
            //int b = 10;
            //int c = 15;
            //int d = 5;
            //int e;
            //e = (a + b) * c / d;
            // (3015) / 5
            //e = ((a + b) * c) / d;
            // (3015) / 5
            //e = (a + b) * (c/d);
            // (30) * (15/5)
            //e = a + (b + c) / d;
            // 20+ (150/5)
            #endregion
        }
    }
}
