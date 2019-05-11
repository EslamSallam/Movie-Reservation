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
    public partial class Form1 : Form
    {
        public static Form1 incta = null;

        public Form1()
        {
            incta = this;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        internal void showSignup()
        {
            reg1.Visible = false;
            reg1.BringToFront();
            bunifuTransition1.ShowSync(reg1);
        }

        internal void showLogin()
        {
            log1.Visible = false;
            log1.BringToFront();
            bunifuTransition1.ShowSync(log1);
        }

        internal Image imagevalidator(bool v)
        {
            if (v)
            {
                return imageList1.Images[1];
            }
            return imageList1.Images[0];
        }

        
    }
}
