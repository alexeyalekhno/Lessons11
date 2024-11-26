using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    struct LinearEquation
    {
        double k;
        double x;
        double b;



        public LinearEquation(double k, double x, double b)
        { 
        this.k = k;
        this.x = x;
        this.b = b;

        }

        public string Root()
        {
            if (k == 0)
                return "Значение K не может быть меньше нуля"; 
        double x = (-b) / k;
            return $"X равен {x}";
        }
           

    }       



    
}
