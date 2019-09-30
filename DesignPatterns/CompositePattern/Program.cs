using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{

    #region IComponent interface

    public interface IEmployee
    {
        int EmployeeID { get; set; }
        string Name { get; set; }
        int Rating { get; set; }
        void PerformanceSummary();
    }
    #endregion

    #region Leaf class- will be leaf in tree structure

    public class Employee : IEmployee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public void PerformanceSummary()
        {
            Console.WriteLine($"\nPerformance summary of employee: {Name} is {Rating} out of 5");
        }

    }
    #endregion

    #region Composite class- will be branch node in tree structure

    public class Supervisor : IEmployee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }

        public List<IEmployee> ListSubordinates = new List<IEmployee>();
        public void PerformanceSummary()
        {
            Console.WriteLine($"Performance summary of supervisor: {Name} is {Rating} out of 5");
        }

        public void AddSubordinate(IEmployee employee)
        {
            ListSubordinates.Add(employee);
        }
    }
    #endregion

   

    #region  Client
    class Program
    {
       

        static void Main(string[] args)
        {


            Employee emp1 = new Employee { EmployeeID = 1, Name = "A", Rating = 1 };
            Employee emp2 = new Employee { EmployeeID = 2, Name = "B", Rating = 2 };
            Employee emp3 = new Employee { EmployeeID = 3, Name = "C", Rating = 3 };
            Employee emp4 = new Employee { EmployeeID = 4, Name = "D", Rating = 4 };
            Employee emp5 = new Employee { EmployeeID = 5, Name = "E", Rating = 5 };
            Employee emp6 = new Employee { EmployeeID = 6, Name = "F", Rating = 6 };

            Supervisor sup1 = new Supervisor { EmployeeID = 7, Name = "G", Rating = 3 };
            Supervisor sup2 = new Supervisor { EmployeeID = 8, Name = "H", Rating = 3 };

            sup1.AddSubordinate(emp1);
            sup1.AddSubordinate(emp2);
            sup1.AddSubordinate(emp3);

            sup2.AddSubordinate(emp4);
            sup2.AddSubordinate(emp5);
            sup2.AddSubordinate(emp6);

            Console.WriteLine("\n Employee can see their performance");
            emp1.PerformanceSummary();

            Console.WriteLine("Supervisor can also see their subordinates performance summary");
            sup1.PerformanceSummary();

            foreach (var employee in sup1.ListSubordinates)
            {
                employee.PerformanceSummary();
            }



            Console.ReadLine();
        }
    }

 
    #endregion


}
