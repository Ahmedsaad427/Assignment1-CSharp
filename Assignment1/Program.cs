namespace Assignment_1_solution
{
    internal class Program
    {
        // For Question 6
        class Person
        {
            public string Name;
        }

        static void Main(string[] args)
        {
            /*
            #region Question-1
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("You entered: " + number);
            #endregion*/

            /*
            #region Question_2
            string str = "123abc";
            try
            {
                int number = Convert.ToInt32(str);
                Console.WriteLine("Converted number: " + number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: The string contains non-numeric characters.");
            }
            // If the string contains non-numeric characters, it will throw a FormatException because the Convert.ToInt32 method expects a valid numeric string.
            #endregion
            */

            /*
            #region Question_3
            double num1 = 10.5, num2 = 5.5;
            double result = num1 / num2;
            Console.WriteLine("Result: " + result);
            #endregion

            // The result will be a floating-point value. For example, 10.5 / 5.5 = 1.9090909090909092 as floating-point division is performed.
            */

            /*
            #region Qustion_4
            string str = "Hello, world!";
            string subStr = str.Substring(7, 5); 
            Console.WriteLine(subStr);
            #endregion
            */

            /*
            #region Qustion_5
            int x = 10;
            int y = x; 
            y = 20; 
            Console.WriteLine("x: " + x);
            Console.WriteLine("y: " + y);
            #endregion
            // In the case of value types (e.g., int), assigning one variable to another creates a copy, so modifying one variable doesn't affect the other.
            */

            /*
            #region Question_6
            Person p1 = new Person();
            p1.Name = "Ahmed";

            Person p2 = p1;
            p2.Name = "Saad";

            Console.WriteLine("p1 Name: " + p1.Name);
            Console.WriteLine("p2 Name: " + p2.Name);

            // In the case of reference types (e.g., Person), assigning one variable to another makes both variables point to the same object. Modifying one affects the other.
            #endregion
            */

            /*
            #region Question_7
            string str1 = "Ahmed";
            string str2 = "Saad";
            string result = str1 + " " + str2;
            Console.WriteLine(result); 
            #endregion
            */

            /*
            #region Question_8
            double principal = 1000;
            double rate = 100;
            double time = 3;

            double interest = (principal * rate * time) / 100;
            Console.WriteLine("Simple Interest: " + interest);
            #endregion
            */

            /*
            #region Question_9
            double weight = 77; 
            double height = 1.83; 

            double bmi = weight / (height * height);
            Console.WriteLine("BMI: " + bmi);
            #endregion
            */

            /*
            #region Question_10
            int temperature = 25;
            string result = (temperature < 10) ? "Just Cold" :
                            (temperature > 30) ? "Just Hot" :
                            "Just Good";
            Console.WriteLine(result);
            #endregion
            */

            /*
            #region Question_11
            DateTime date = new DateTime(2024, 12, 12);

            Console.WriteLine($"Today's date: {date:dd, MM, yyyy}");
            Console.WriteLine($"Today's date: {date:dd/MM/yyyy}");
            Console.WriteLine($"Today's date: {date:dd-MM-yyyy}");
            #endregion
            */

            /*
            #region Question_12
            DateTime date = new DateTime(2024, 6, 14);
            Console.WriteLine($"The event is on {date:MM/dd/yyyy}");
            // Output is C
            #endregion 
            */

            /*
            #region Question_13
            int d;
            d = Convert.ToInt32(!(30 < 20));
            // Output is : F
            // 30 < 20 is false, and !false is true, which is equivalent to 1 when converted to an integer.
            #endregion
            */

            /*
            #region Question_14
            Console.WriteLine(13 / 2 + " " + 13 % 2);
            // Output is : D 
            // the division (13 / 2) results in 6 (integer division), and the modulus (13 % 2) gives the remainder, which is 1.
            #endregion
            */

            /*
            #region Question_15
            int num = 1, z = 5;

            if (!(num <= 0))
                Console.WriteLine(++num + z++ + " " + ++z);
            else
                Console.WriteLine(--num + z-- + " " + --z);

            // Output is : D
            // Explanation:

            // ++num increments num first, changing it to 2.
            // z++ uses the current value of z(which is 5), then increments z to 6.
            // ++z increments z(now 6) to 7, so the output is 2 + 5 + 7 = 6 6.
            #endregion
            */
        }
    }
}
