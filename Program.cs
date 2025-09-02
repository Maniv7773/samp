using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetailsAt
{
    class Employee
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public int Eage { get; set; }
        public double Esalary;
        static string Ecompany;
        static long Enumber;

        internal Employee(int eid, string ename, int eage)
        {
            Eid = eid;
            Ename = ename;
            Eage = eage;
        }
        static void EmployeeCompany(string ecompany,long enumber)
        {
            Ecompany = ecompany;
            Enumber = enumber;
            Console.WriteLine("Employee Company is "+ Ecompany);
            Console.WriteLine("Employee number is "+ Enumber);
        }
        internal void DisplayEmployee()
        {
            Console.WriteLine("Employee id is "+ Eid);
            Console.WriteLine("Employee name is "+ Ename);
            Console.WriteLine("Employee age is "+ Eage);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee(1001,"harsha",25);
            Employee.EmployeeCompany("deloitte", 987654321);
            obj.DisplayEmployee();
            
            
            
        }
    }
}
