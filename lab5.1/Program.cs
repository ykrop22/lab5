﻿using System;
using System.Windows.Forms;

namespace DrowLab5
{
    static class Program
    {
        public static Form1 MainForm { get; private set; }
        

        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm = new Form1();
            Application.Run(MainForm);

        }
    }
}
