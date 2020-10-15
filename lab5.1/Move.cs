using System;
using System.Drawing;

namespace DrowLab5
{
    class Move
    {
        
        public static float len;
        public PointF p1 { get; set; }
        public PointF p2 { get; set; }
        public PointF p3 { get; set; }
        public PointF p4 { get; set; }
        public PointF[] Points { get; set; }
        public Move(float lenght = 50)
        {
            len = lenght;
            p1 = new PointF(250f, 250f);
            p2 = new PointF(p1.X + lenght, p1.Y);
            p3 = new PointF(p1.X + lenght, p1.Y + lenght);
            p4 = new PointF(p1.X, p1.Y + lenght);
            Points = new PointF[4] { p1, p2, p3, p4 };

        }

        public virtual PointF[] LeftMove()
        {
            for (int i = 0; i < Points.Length; i++)
            {
                Points[i].X -= 50;
            }
            
            return Points;
        }
        public virtual PointF[] RightMove()
        {
            for (int i = 0; i < Points.Length; i++)
            {
                Points[i].X += 50;
            }
            return Points;
        }
        public void Сoordinates()
        {
            Program.MainForm.point1.Text = "";
            for (int i = 0; i < Points.Length; i++)
            {
                string A = $"point{i}";
                Program.MainForm.point1.Text += $"{Points[i]}";
            }
            
           
        }
    }
}
