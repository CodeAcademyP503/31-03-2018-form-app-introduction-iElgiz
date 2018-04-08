using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaAppTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn1.Click += new EventHandler(FirstBtn);
            btn2.Click += new EventHandler(SecondBtn);
            btn3.Click += new EventHandler(ThirdBtn);
            btn4.Click += new EventHandler(FourthBtn);




        }

        public void FirstBtn(object obj,EventArgs e)
        {
            var btn = new Seats();
            btn.Show();

        }

        public void SecondBtn(object obj, EventArgs e)
        {
            var btn = new Seats();
            btn.Show();

        }
        public void ThirdBtn(object obj, EventArgs e)
        {
            var btn = new Seats();
            btn.Show();

        }
        public void FourthBtn(object obj, EventArgs e)
        {
            var btn = new Seats();
            btn.Show();

        }


    }
}
