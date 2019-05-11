using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies_Reservation
{
    public partial class Dashboard : Form
    {
        public static Dashboard dashboard = null;
        public Dashboard()
        {
            dashboard = this;
            InitializeComponent();

            bunifuFormDock1.SubscribeControlsToDragEvents(new Control[] {
                panel2
            },false);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            manageMovies1.Visible = false;
            manageMovies1.BringToFront();
            bunifuTransition1.ShowSync(manageMovies1);
            MyUser.state = true;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            showMyMoives1.myRefresh();
            showMyMoives1.Visible = false;
            showMyMoives1.BringToFront();
            bunifuTransition1.ShowSync(showMyMoives1);
            MyUser.state = false;

        }

        internal void GetDetails(List<string> mylist)
        {

            movieDetails1.Visible = false;
            movieDetails1.BringToFront();
            movieDetails1.fillMoive(mylist);
            bunifuTransition1.ShowSync(movieDetails1);
            
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            string str = Form.ActiveForm.WindowState.ToString();
            if (str.Equals("Normal"))
                Form.ActiveForm.WindowState = FormWindowState.Maximized;
            else
                Form.ActiveForm.WindowState = FormWindowState.Normal;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.WindowState = FormWindowState.Minimized;
        }

        private void showMovies1_Load(object sender, EventArgs e)
        {
           
        }

        internal void bookTicket()
        {
            
            manageMovies1.myRefresh();
            manageMovies1.Visible = false;
            manageMovies1.BringToFront();
            bunifuTransition1.ShowSync(manageMovies1);
        }

        internal void cancelBooking()
        {
            
            showMyMoives1.myRefresh();
            showMyMoives1.Visible = false;
            showMyMoives1.BringToFront();
            bunifuTransition1.ShowSync(showMyMoives1);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            MyUser.state = true;
            label2.Text = MyUser.cash.ToString();
        }

        internal void updateCash()
        {
            label2.Text = MyUser.cash.ToString();
        }
    }
}
