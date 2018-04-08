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
    public partial class Seats : Form
    {
        public static List<int> qiymetler = new List<int>();
        public int RowCount = 4;
        public int ColumnCount = 10;
        public int LeftPos = 0;
        public int TopPos = 0;
        public int SeatNumber = 1;
        public static bool rdcheck = false;
        public static List<int> oturacaglar = new List<int>();
        public Seats()
        { 
        InitializeComponent();

            for (int row = 0; row<RowCount; row++)
            {
                for (int column = 0; column<ColumnCount; column++)
                {
                    var seat = new Button();
                    seat.Width = 50;
                    seat.Height = 50;
                    seat.Left = LeftPos;
                    seat.Top = TopPos;
                    seat.Text = SeatNumber.ToString();
                    Controls.Add(seat);
                    seat.Click += new EventHandler(ReservSeat);
                    SeatNumber++;
                    LeftPos += 50;
                }
                LeftPos = 0;
                TopPos += 50;

            }
            this.Width = ColumnCount * 50 + 17;
            this.Height = RowCount * 50 + 240;
            
        }
        public void ReservSeat(object obj, EventArgs e)
        {
            var btn = obj as Button;
            btn.BackColor = Color.Red;
            btn.Enabled = false;
            oturacaglar.Add(Convert.ToInt32(btn.Text));
            qiymetler.Add(Convert.ToInt32(btn.Text));
    
        }
         
       

        private void button1_Click(object sender, EventArgs e)
        {
            rdcheck = rd1.Checked == true ? true : false;
            var btn = new Checking();
            btn.Show();
        }

        


       
    }
}
