using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab5_2
{
    class Cone
    {
        public double radius { get; private set; }
        public double height { get; private set; }
        public Cone()
        {
            radius = Convert.ToDouble(Program.MainForm.RadiusK.Text);
            height =Convert.ToDouble(Program.MainForm.HeightK.Text);
        }
        public virtual double Volume()
        {
            double result = (1.0 / 3.0) * Math.PI * Math.Pow(radius, 2) * height;
            return result;
        }
        public virtual double Area()
        {
            double result = Math.PI * radius;
            return result;
        }
    }
}
