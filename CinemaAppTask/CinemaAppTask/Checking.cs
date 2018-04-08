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
    public partial class Checking : Form
    {
        public Checking()
        {
            InitializeComponent();
            btn1.Click += new EventHandler(Btn1); 
            for (int i = 0; i < Seats.oturacaglar.Count; i++)
            {
                SeatsBox.Text += Seats.oturacaglar[i]+ ",";
            }
       
            if (Seats.rdcheck==true)
            {
                SeansBox.Text = "12 :00";
            }
            else
            {
                SeansBox.Text = "20 : 00";
            }
            PayingBox.Text = (Seats.qiymetler.Count * 5).ToString();
        }

        public void Btn1(object obj,EventArgs e)
        {

            var btn = new Form1();
            btn.Show();

        }
        
        
    }
}
