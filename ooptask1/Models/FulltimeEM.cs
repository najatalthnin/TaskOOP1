using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ooptask1.Models
{
    public class FulltimeEM :Employee
    {
        int day;
        double dayprice;
        public int _day
        {
            set { day = value; }
            get { return day; }
        }
        public  double _dayprice
    {
        set { dayprice = value; }
        get { return dayprice; }
    }

        public override bool check()
        {
           if(firstname!="" && lastname!=" "&& email!=" "&& phone!=" " && day!=0 && dayprice!=0 )
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public override double cal()
        {
            double sal = day * dayprice;
            return sal;

        }




    }
   

}
