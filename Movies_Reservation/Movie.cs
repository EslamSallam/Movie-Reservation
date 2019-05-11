using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies_Reservation
{
    public partial class Movie : UserControl
    {
        private List<string> mylist;
        public Movie()
        {
            mylist = new List<string>();
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClickedMovie.movieID = int.Parse(this.mylist[0]);
            ClickedMovie.movieName = this.label1.Text;
            if (MyUser.role == "a")
                Admin.admin.GetDetails(mylist);
            else if (MyUser.role == "u")
                Dashboard.dashboard.GetDetails(mylist);
            


        }

        internal void setvalues(List<string> ls)
        {
            label1.Text = ls[1];
            label2.Text = ls[5] + " m";
            pictureBox1.ImageLocation = ls[4];
            this.mylist = ls;
        }
    }
}
