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
    public partial class addMovie : UserControl
    {
        string ordb = "data source=orcl;user id = hr;password = hr;";
        OracleConnection conn;
        OracleCommand cmd;

        public addMovie()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose Image(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                pictureBox1.ImageLocation = ofd.FileName;
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "ADDMOVIE";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("name", bunifuTextBox1.Text);
            cmd.Parameters.Add("cat", bunifuTextBox2.Text);
            cmd.Parameters.Add("price", int.Parse(bunifuTextBox3.Text));
            cmd.Parameters.Add("pic", pictureBox1.ImageLocation.ToString());
            cmd.Parameters.Add("run", int.Parse(bunifuTextBox4.Text));
            cmd.Parameters.Add("d", bunifuDatePicker1.Value);
            cmd.ExecuteNonQuery();
            Admin.admin.DeleteMovie();
        }

        private void addMovie_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }
    }
}
