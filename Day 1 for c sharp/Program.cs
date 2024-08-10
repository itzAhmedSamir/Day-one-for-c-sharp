namespace Day_1_for_c_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task 1
            // Task 1 :

            Console.Write("Please enter your name: ");
            String name = Console.ReadLine();

            Console.Write("Please enter your id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Please enter your department: ");
            String department = Console.ReadLine();

            Console.WriteLine("--------------");

            Console.WriteLine($"""
                Student name is {name}
                Student id is {id}
                Student age is {age}
                Student department is {department}
                """);

            #endregion

            Console.WriteLine("--------------");

            #region Task 2
            // Task 2 :

            Console.Write("Please enter your name: ");
            String emp_name = Console.ReadLine();

            Console.Write("Please enter your ssn: ");
            int emp_ssn = int.Parse(Console.ReadLine());

            int emp_age;
            do
            {
                Console.Write("Please enter your age: ");
                emp_age = int.Parse(Console.ReadLine());
            } while (emp_age <= 0);

            int emp_salary;
            do
            {
                Console.Write("Please enter your salary: ");
                emp_salary = int.Parse(Console.ReadLine());
            } while (emp_salary < 20000);

            Console.WriteLine("--------------");

            Console.WriteLine($"""
            Employee name is {emp_name}
            Employee ssn is {emp_ssn}
            Employee age is {emp_age}
            Employee salary is {emp_salary}
            """);

            #endregion

            Console.WriteLine("--------------");

            #region Check if entered number by user is positive or negative
            // Task 3:

            Console.Write("Please enter a number to test if it is positive or negative: ");
            int number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine($"Number {number} is POSITIVE");
            }
            else if (number < 0)
            {
                Console.WriteLine($"Number {number} is NEGATIVE");
            }
            else
                Console.WriteLine("Number is ZERO");
            #endregion

            Console.WriteLine("--------------");

            #region Check if entered number by user is even or odd
            // Task 4:

            Console.Write("Please enter a number to check if it is even or odd: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"Number {num} is Even");
            }
            else
                Console.WriteLine($"Number {num} is Odd");
            #endregion

            Console.WriteLine("--------------");

            #region Checks if a rectangle with given length and width is a square
            // Task 5:

            Console.Write("Please enter a rectangle length: ");
            float length = float.Parse(Console.ReadLine());
            Console.Write("Please enter a rectangle width: ");
            float width = float.Parse(Console.ReadLine());
            if (length == width)
            {
                Console.WriteLine("The rectangle is a square");
            }
            else
                Console.WriteLine("The rectangle is NOT a square");
            #endregion
        }
    }
}
