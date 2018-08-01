using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person employee1 = new Person("Sefton", "Munro", 1000, 0, "30001654");
            Person employee2 = new Person("Bill", "Gates", 100, 10, "2");
            Person employee3 = new Person("Jeff", "Jeff", 100, 10, "3");
            Person employee4 = new Person("Dave", "O", 100, 10, "4");
            Person employee5 = new Person("Matt", "n", 100, 10, "5");
            //Console.WriteLine(employee1.Fname + " " + employee1.Lname);
            Console.WriteLine("Employee 1: {0} {1}  Pay Rate: {2}  Tax Rate: {3}  Account Number: {4}", employee1.Fname, employee1.Lname, employee1.PayRate, employee1.Tax, employee1.AccNum);
            Console.WriteLine("Employee 1: {0} {1}  Pay Rate: {2}  Tax Rate: {3}  Account Number: {4}", employee2.Fname, employee2.Lname, employee2.PayRate, employee2.Tax, employee2.AccNum);
            Console.WriteLine("Employee 1: {0} {1}  Pay Rate: {2}  Tax Rate: {3}  Account Number: {4}", employee3.Fname, employee3.Lname, employee3.PayRate, employee3.Tax, employee3.AccNum);
            Console.WriteLine("Employee 1: {0} {1}  Pay Rate: {2}  Tax Rate: {3}  Account Number: {4}", employee4.Fname, employee4.Lname, employee4.PayRate, employee4.Tax, employee4.AccNum);
            Console.WriteLine("Employee 1: {0} {1}  Pay Rate: {2}  Tax Rate: {3}  Account Number: {4}", employee5.Fname, employee5.Lname, employee5.PayRate, employee5.Tax, employee5.AccNum);
            //Console.WriteLine($"employee name: {employee3.Fname} {employee3.Lname}");
            Console.ReadLine();
        }
    }

    
}
