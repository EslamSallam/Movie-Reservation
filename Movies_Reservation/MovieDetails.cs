using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Movies_Reservation
{
    public partial class MovieDetails : UserControl
    {
        private List<string> movielist;
        string ordb = "data source=orcl;user id = hr;password = hr;";
        OracleConnection conn;
        OracleCommand cmd;
        public MovieDetails()
        {
            movielist = new List<string>();
            InitializeComponent();
        }

        private void MovieDetails_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        internal void fillMoive(List<string> mylist)
        {
            this.movielist = mylist;
            //label1.Text = mylist[0];
            label2.Text = mylist[1];
            label3.Text = mylist[2];
            label4.Text = mylist[3];
            //pictureBox1.Image = Image.FromFile(mylist[4].ToString());
            pictureBox1.ImageLocation = mylist[4];
            label6.Text = mylist[5] + " minutes";
            label5.Text = mylist[6];
            if (MyUser.role == "a")
            {
                btn.ButtonText = "Delete Movie";
            }
            else if (MyUser.state == false && MyUser.role == "u")
            {
                btn.ButtonText = "Cancel Booking";
            }
            else if (MyUser.state == true && MyUser.role == "u")
            {
                btn.ButtonText = "book A ticket";
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (btn.ButtonText == "Delete Movie")
            {
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DeleteMovie";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("mid", ClickedMovie.movieID);
                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("Done :)");
                }
                Admin.admin.DeleteMovie();
            }
            else if (btn.ButtonText == "book A ticket")
            {
                if (MyUser.cash > int.Parse(movielist[3]))
                {
                    Dashboard.dashboard.bookTicket();
                    MyUser.cash -= int.Parse(movielist[3]);
                    cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "AddUserMovie";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("e", MyUser.email);
                    cmd.Parameters.Add("mid", ClickedMovie.movieID);
                    cmd.Parameters.Add("c", MyUser.cash);
                    int r = cmd.ExecuteNonQuery();
                    if (r != -1)
                    {
                        MessageBox.Show("Done :)");
                    }
                    Dashboard.dashboard.updateCash();
                }
                else
                {
                    MessageBox.Show("Can't Book Movie");
                }
            }
            else if (btn.ButtonText == "Cancel Booking")
            {
                
                MyUser.cash += int.Parse(movielist[3]);
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "CancelUserMovie";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("e", MyUser.email);
                cmd.Parameters.Add("mid", ClickedMovie.movieID);
                cmd.Parameters.Add("c", MyUser.cash);
                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("Done :)");
                }
                Dashboard.dashboard.updateCash();
                Dashboard.dashboard.cancelBooking();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (MyUser.role == "a")
            {
                Admin.admin.backToView();
                
            }
            else if (MyUser.state == false && MyUser.role == "u")
            {
                Dashboard.dashboard.cancelBooking();
            }
            else
            {
                Dashboard.dashboard.bookTicket();
            }
        }
    }
}
