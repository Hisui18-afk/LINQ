using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    public class Crud
    {
        List<Employee> employees = new List<Employee>();
        public int id, Choice;
        public string name, position, newSalary;
        public double salary;

        public void Introduce()
        {

            while (true)
            {
                Program.Option();
                Console.Write("Enter your choice: ");
                Choice = int.Parse(Console.ReadLine());

                switch (Choice)
                {
                    case 1:
                        ADD();
                        break;
                    case 2:
                        READ();
                        break;
                    case 3:
                        UPDATE();
                        break;
                    case 4:
                        DELETE();
                        break;
                    case 5:
                        Console.WriteLine("Exit");
                        return;
                    default:
                        Console.WriteLine("Please choose from 1 to 5");
                        break;


                }
            }

        }
        public void ADD()
        {
            Console.WriteLine("Add Employee");
            Console.Write("Enter ID: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Enter Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Position: ");
            position = Console.ReadLine();
            Console.Write("Enter Salary: ");
            salary = double.Parse(Console.ReadLine());
            if (!employees.Any(e => e.Id == id))
            {
                employees.Add(new Employee { Id = id, Name = name, Position = position, Salary = salary });
                Console.WriteLine("Employees Added Succesfully");
            }
        }
        public void READ()
        {
            Console.WriteLine("\n READ EMPLOYEE");
            Program.viewallorReadone();
            Console.Write("Enter your Choice: ");
            Choice = int.Parse(Console.ReadLine());
            if (Choice == 1)
            {
                Console.WriteLine("\n LIST OF EMPLOYEES");
                Console.WriteLine("\tID \tNAME \tPOSITION \tSALARY");
                foreach (var em in employees)
                {
                    Console.WriteLine($"\t{em.Id}. \t{em.Name}. \t{em.Position}. \t\t{em.Salary} ");
                }
            }
            else if (Choice == 2)
            {

                Console.Write("Search ID: ");
                id = int.Parse(Console.ReadLine());
                var employee = employees.FirstOrDefault(e => e.Id == id);
                if (employee != null)
                {
                    Console.WriteLine("EMPLOYEE");
                    Console.WriteLine("\tID \tNAME \tPOSITION \tSALARY");
                    Console.WriteLine($"\t{employee.Id} \t{employee.Name} \t{employee.Position} \t\t{employee.Salary}");
                }
            }

        }
        public void UPDATE()
        {
            Console.WriteLine("UPDATE");
            Console.Write("Enter ID to Delete: ");
            id = int.Parse(Console.ReadLine());

            var employee = employees.FirstOrDefault(e => e.Id == id);

            if (employee != null)
            {
                Console.Write("Enter new Name (Leave it blank if you'renot going to update): ");
                if (!string.IsNullOrEmpty(name)) employee.Name = name;
                Console.Write("Enter new Position (Leave it blank if you'renot going to update): ");
                position = Console.ReadLine();
                if (!string.IsNullOrEmpty(position)) employee.Position = position;

                Console.Write("Enter new Salary (Leave it blank if you'renot going to update): ");
                newSalary = Console.ReadLine();
                if (double.TryParse(newSalary, out double salary)) employee.Salary = salary;

                Console.WriteLine("Employee Updated Successfully");
            }
            else
            {
                Console.WriteLine("ID not found");
            }

        }
        public void DELETE()
        {
            Console.WriteLine("\n DELETE");
            Console.Write("Enter ID to Delete: ");
            id = int.Parse(Console.ReadLine());

            var employee = employees.FirstOrDefault(e => e.Id == id);

            if (employee != null)
            {

                employees.Remove(employee);
                Console.WriteLine("Employee Deleted Successfully");
            }
            else
            {
                Console.WriteLine("ID not found");
            }
        }
    }
}
