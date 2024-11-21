using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Management System");
            var crud = new Crud();
            crud.Introduce();
        }
        public static void Option()
        {
            Console.WriteLine("\n==============Option===============");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Read Employee");
            Console.WriteLine("3. update Employee");
            Console.WriteLine("4. Delete Employee");
            Console.WriteLine("5. Exit");


        }
        public static void viewallorReadone()
        {
            Console.WriteLine("1. List of all Employee");
            Console.WriteLine("2. Find Employee By ID");
        }
    }
}
