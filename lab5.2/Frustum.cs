using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    class Frustum : Cone
    {
        private double __lowRadius;
        public Frustum()
        {
            __lowRadius = Convert.ToDouble(Program.MainForm.lRadiusU.Text);
        }
        public override double Area()
        {
            double result = (1.0/3.0) * (Math.PI * height * (Math.Pow(radius, 2) * Math.Pow(__lowRadius, 2) * radius * __lowRadius));
            return result;
        }
    }
}
