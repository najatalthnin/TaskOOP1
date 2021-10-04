using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ooptask1.Models
{
    public abstract class Employee
    {
        protected string firstname;
        protected string lastname;
        protected string email;
        protected string phone;

        public string _firstname
        {
            set { firstname = value; }
            get { return firstname; }
        }
        public string _lastname
        {
            set { lastname = value; }
            get { return lastname; }
        }
        public string _email
        {
            set { email = value; }
            get { return email; }
        }
        public string _phone
        {
            set { phone = value; }
            get { return phone; }
        }

        public abstract bool check();

        public abstract double cal();

        public String print(double sal){

            String massage = "Heelo" + firstname + lastname + ".This is Employee ,Your Salary is:" + sal;


                return massage;
}
    
    }
}
