
namespace project;

using System;
internal class Program
{
    static void Main(string[] args)
    {
        #region task 1
        //Employee employee = new Employee(1, "ahmed", 600.5, new DateTime(2025, 12, 25), Gender.M, SecurityLevel.developer);

        //Console.WriteLine(employee.ToString());

        #endregion

        #region task 2
        //Console.WriteLine(employee.GetHiringDateRemaining());
        #endregion

        #region task 3

        Company company = new Company(3);

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Enter Id For Employee Number {i + 1}");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid Id. Please enter a valid integer.");
            }

            Console.WriteLine($"Enter Name For Employee Number {i + 1}");
            string name;
            while (true)
            {
                name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name))
                    break;

                Console.WriteLine("Invalid Name. Please enter a valid name.");
            }

            Console.WriteLine($"Enter Salary For Employee Number {i + 1}");
            double salary;
            while (!double.TryParse(Console.ReadLine(), out salary) || salary < 0)
            {
                Console.WriteLine("Invalid Salary. Please enter a valid positive number.");
            }

            Console.WriteLine($"Enter Hiring Date For Employee Number {i + 1} (format: yyyy-mm-dd)");
            DateTime hiringDate;
            while (!DateTime.TryParse(Console.ReadLine(), out hiringDate))
            {
                Console.WriteLine("Invalid Hiring Date. Please enter a valid date in the format yyyy-mm-dd.");
            }

            Console.WriteLine($"Enter gender for Employee {i + 1}: 'M' for Male, 'F' for Female");
            char inputGender;
            Gender gender;
            while (true)
            {
                if (char.TryParse(Console.ReadLine(), out inputGender))
                {
                    Console.WriteLine(inputGender);
                    switch (char.ToUpper(inputGender))
                    {
                        case 'M':
                            gender = Gender.M;
                            break;
                        case 'F':
                            gender = Gender.F;
                            break;
                        default:
                            Console.WriteLine("Invalid Gender. Please enter 'M' or 'F'.");
                            continue;
                    }
                    break;
                }

            }
            Console.WriteLine($"Enter Security Level for Employee {i + 1}:");
            Console.WriteLine("0 - Guest\n1 - Developer\n2 - Secretary\n3 - DBA");
            int levelInput;
            SecurityLevel securityLevel;

            while (true)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out levelInput) &&
                    Enum.IsDefined(typeof(SecurityLevel), levelInput))
                {
                    securityLevel = (SecurityLevel)levelInput;
                    break;
                }

                Console.WriteLine("Invalid Security Level. Please enter a number from 0 to 3.");
                Console.WriteLine("0 - Guest\n1 - Developer\n2 - Secretary\n3 - DBA");
            }
            company.employees[i] = new Employee(id, name, salary, hiringDate, gender, securityLevel);
        }

        Console.WriteLine(company.ToString());
    }
}


#endregion

