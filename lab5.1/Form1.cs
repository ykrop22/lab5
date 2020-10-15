using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrowLab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(PushKey);
        }
       
        Bitmap bitmap;
        Graphics graph;
        Pen pen;
        Move square;
        
        private void PushKey(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode.ToString())
            {
                case "Left":
                    {
                        graph.Clear(Color.White);
                        graph.DrawPolygon(pen, square.LeftMove());
                        pictureBox.Image = bitmap;
                        square.Сoordinates();
                        break;
                    }
                case "Right":
                    {
                        graph.Clear(Color.White);
                        graph.DrawPolygon(pen, square.RightMove());
                        pictureBox.Image = bitmap;
                        square.Сoordinates();
                        break;
                    }
            }


        }
        private void pictureBox_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            graph = Graphics.FromImage(bitmap);
            pen = new Pen(Color.Blue, 3);
            square = new Move((float.Parse(textBox.Text)));
            graph.DrawPolygon(pen, square.Points);
            pictureBox.Image = bitmap;
            square.Сoordinates();
            textBox.Enabled = false;

        }


        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
