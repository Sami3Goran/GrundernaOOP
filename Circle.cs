using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GrundernaOOP
{
     class Circle
     {
        public decimal radius {  get; set; } //insatsvariabel / fält

       
        public Circle(decimal radie) //konstruktor
        {
            radius = radie;
        }

        public decimal Getradie() //metod
        {
            return radius;
        }

        public decimal GetArea() //metod
        {
            return (decimal)Math.PI * radius * radius;
        }

        public decimal GetCircumference()  //metod
        {
            return (decimal)Math.PI*(radius + radius);
        }

        public decimal GetVolym() //metod
        {
           
            return (4 * (decimal)Math.PI * (decimal)Math.Pow((double)radius, 3))/ 3;
        }
            
    }
}
