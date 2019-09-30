using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
   
    #region Adaptee

    public class ThirdPartyEmployee
    {
        public List<string> GetEmployeeList()
        {
            List<string> employeeList= new List<string>();
            employeeList.Add("Peter");
            employeeList.Add("A");
            employeeList.Add("Poor");
            employeeList.Add("Leter");
            return employeeList;
        }
    }

    #endregion

    #region ITarget

    public interface ITarget
    {
        List<string> GetEmployees();
    }
    #endregion

    #region Target or adapter

    public class EmployeeAdapter : ThirdPartyEmployee, ITarget
    {
       
        public List<string> GetEmployees()
        {
            return GetEmployeeList();
        }
    }

    #endregion

    #region Client
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee list from 3rd party organization");
            Console.WriteLine("-----------------------");

                // Client will use Itarget interface to call functionality of adaptee class i.e.
                //ThirdPartyEmployee
                ITarget adapter= new EmployeeAdapter();

                foreach (var employee in adapter.GetEmployees())
                {
                    Console.WriteLine(employee);
                }

                Console.ReadLine();
        }
    }

    #endregion

}
