﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Circle
    {
        private double radius;
        
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public double CalculateCircumference()
        {
            double circumference = Math.PI * radius * 2;
            return circumference;
        }
        public string CalculateFormattedCircumference()
        {
            string formattedCir = $"{CalculateCircumference(), 0:N2}";
            return formattedCir;
        }
        public double CalculateArea()
        {
            double area = (Math.PI * radius * radius);
            return area;
        }
        public string CalculateFormattedArea()
        {
            string formattedArea = $"{CalculateArea(),0:N2}";
            return formattedArea;
        }


    }
}
