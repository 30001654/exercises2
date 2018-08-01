using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises2
{
    public class Person
    {
        string fName;
        string lName;
        float payRate;
        float tax;
        string accNum;

        public string Fname
        {
            get
            {
                return fName;
            }
            set
            {
                fName = value;
            }
        }

        public string Lname
        {
            get
            {
                return lName;
            }
            set
            {
                lName = value;
            }
        }

        public float PayRate
        {
            get
            {
                return payRate;
            }
            set
            {
                payRate = value;
            }
        }

        public float Tax
        {
            get
            {
                return tax;
            }
            set
            {
                tax = value;
            }
        }

        public string AccNum
        {
            get
            {
                return accNum;
            }
            set
            {
                accNum = value;
            }
        }
        public Person(string _fname, string _lname, float _payrate, float _tax, string _accnum)
        {
            Fname = _fname;
            Lname = _lname;
            PayRate = _payrate;
            Tax = _tax;
            AccNum = _accnum;
        }
    }

}
