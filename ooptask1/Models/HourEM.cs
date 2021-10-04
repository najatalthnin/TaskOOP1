using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ooptask1.Models
{
    public class HourEM : Employee
{
    int hour;
    double hourprice;
    public int _hour
    {
        set { hour = value; }
        get { return hour; }
    }
    public double _hourprice
    {
        set { hourprice = value; }
        get { return hourprice; }
    }

    public override bool check()
    {
        if (firstname != "" && lastname != " " && email != " " && phone != " " && hour != 0 && hourprice != 0)
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
        double sal = hour * hourprice;
        return sal;

    }




}
   

}
