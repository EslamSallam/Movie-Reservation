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
    public partial class ShowMovies : UserControl
    {
        public ShowMovies()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShowMovies_Load(object sender, EventArgs e)
        {

            for (int i = 1; i <= 10; i++)
            {
                //List<string> ls = new List<string>();
                //ls.Add(i.ToString());
                //ls.Add("I'm Number" + i.ToString());
                //ls.Add("My Name is" + i.ToString());
                //Movie movie = new Movie();
                //movie.setvalues(ls);
                //flowLayoutPanel1.Controls.Add(movie);
            }
        }

        private void flowLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
