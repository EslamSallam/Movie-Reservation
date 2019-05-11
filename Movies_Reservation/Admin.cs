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
    public partial class Admin : Form
    {
        public static Admin admin = null;
        public Admin()
        {
            admin = this;
            InitializeComponent();
            bunifuFormDock1.SubscribeControlsToDragEvents(new Control[] {
                panel2
            }, false);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            manageMovies1.Visible = false;
            manageMovies1.BringToFront();
            bunifuTransition1.ShowSync(manageMovies1);

        }

        internal void GetDetails(List<string> mylist)
        {
            movieDetails1.Visible = false;
            movieDetails1.BringToFront();
            movieDetails1.fillMoive(mylist);
            bunifuTransition1.ShowSync(movieDetails1);
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            addMovie1.Visible = false;
            addMovie1.BringToFront();
            bunifuTransition1.ShowSync(addMovie1);
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        internal void DeleteMovie()
        {
            manageMovies1.myRefresh();
            manageMovies1.Visible = false;
            manageMovies1.BringToFront();
            bunifuTransition1.ShowSync(manageMovies1);
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

        internal void backToView()
        {
            manageMovies1.Visible = false;
            manageMovies1.BringToFront();
            bunifuTransition1.ShowSync(manageMovies1);
        }
    }
}
