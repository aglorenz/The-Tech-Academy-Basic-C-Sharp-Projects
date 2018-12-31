/*
 * Author:  Andrew Lorenz
 * Date:    12/30/2018
 * Purpose: Demonstrate use of lambda expressions
 * Req'ts:  In the Main() method, create a list of at least 10 employees. Each employee should have a first 
 *          and last name, as well as an Id. At least two employees should have the first name "Joe". 
 *          Using a foreach loop, create a new list of all employees with the first name "Joe".
 *          Do the same thing again, but this time with a lambda expression.
 *          Using a lambda expression, make a list of all employees with an Id number greater than 5.
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressionsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of at least 10 employees.  At least 2 emps should have first name Joe
            List<Employee> Employees = new List<Employee>
            {
                new Employee { firstName = "Joe", lastName = "Lorenz", id = 1 },
                new Employee { firstName = "Joe", lastName = "Dauk", id = 2 },
                new Employee { firstName = "Joe", lastName = "Branson", id = 3 },
                new Employee { firstName = "Joline", lastName = "Davis", id = 4 },
                new Employee { firstName = "Devin", lastName = "Vaughn", id = 5 },
                new Employee { firstName = "Mark", lastName = "Orvis", id = 6 },
                new Employee { firstName = "David", lastName = "Lang", id = 7 },
                new Employee { firstName = "Susan", lastName = "Chaney", id = 8 },
                new Employee { firstName = "Britney", lastName = "Hendricks", id = 9 },
                new Employee { firstName = "Mary", lastName = "Morrison", id = 10 },
                new Employee { firstName = "Michelle", lastName = "Yamhill", id = 11 }
            };

            Console.WriteLine("\nEmployee List:\n");
            foreach (Employee emp in Employees)
            {
                Console.WriteLine("{0} {1} ID = {2}", emp.firstName.PadRight(10), emp.lastName.PadRight(12), emp.id);
            }

            // Using a foreach loop, create a new list of all employees with the first name "Joe"
            List<Employee> foreachJoes = new List<Employee>();
            foreach (Employee emp in Employees)
            {
                if (emp.firstName == "Joe")
                {
                    foreachJoes.Add(new Employee { firstName = emp.firstName, lastName = emp.lastName, id = emp.id });
                }
            }
            Console.WriteLine("\n\nPrinting foreachJoe list:\n");
            foreach (Employee emp in foreachJoes)
            {
                Console.WriteLine("{0} {1}", emp.firstName, emp.lastName);
            }

            // Using a lambda expression, create a new list of all employees with the first name "Joe"
            List<Employee> lambdaJoes = Employees.Where(x => x.firstName == "Joe").ToList();
            Console.WriteLine("\n\nPrinting lambdaJoe list:\n");
            foreach (Employee emp in lambdaJoes)
            {
                Console.WriteLine("{0} {1}", emp.firstName, emp.lastName);
            }

            // Using a lambda expression, create a list of all employees with id > 5
            List<Employee> idsGreaterThanFive = Employees.Where(x => x.id > 5).ToList();
            Console.WriteLine("\n\nPrinting Employees where ID > 5:\n");
            foreach (Employee emp in idsGreaterThanFive)
            {
                Console.WriteLine("{0} {1}", emp.firstName, emp.lastName);
            }

            Console.ReadLine();
        }
    }
}
