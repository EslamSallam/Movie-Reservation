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
    public partial class Reg : UserControl
    {
        string ordb = "data source=orcl;user id = hr;password = hr;"; 
        OracleConnection conn;
        public Reg()
        {
            InitializeComponent();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            string str = Form.ActiveForm.WindowState.ToString();
            if (str.Equals("Normal"))
                Form.ActiveForm.WindowState = FormWindowState.Maximized;
            else
                Form.ActiveForm.WindowState = FormWindowState.Normal;
        }

        private void btnShowSignIn_Click(object sender, EventArgs e)
        {
            Form1.incta.showLogin();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd;
            OracleDataReader dr;
            if (Validation.validateUserName(bunifuTextBox2.Text))
            {
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select email from Username where email=:e";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("e", bunifuTextBox2.Text);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    label4.Text = "This Mail is taken before.";
                    return;
                }
                dr.Close();

            }
            if (!Validation.validateFirstName(bunifuTextBox1.Text))
            {
                label4.Text = "Enter at least 5 chars for First name.";
                return;
            }
            if (!Validation.validateLastName(bunifuTextBox3.Text))
            {
                label4.Text = "Enter at least 5 chars for Last name.";
                return;
            }
            if (!Validation.validatePassword(bunifuTextBox5.Text))
            {
                label4.Text = "Enter at least 5 chars for Password.";
                return;
            }
            if (!Validation.validatePasswordconfirm(bunifuTextBox5.Text, bunifuTextBox4.Text))
            {
                label4.Text = "Confirm password should be the same as Password.";
                return;
            }
            if (!Validation.validatePhone(bunifuTextBox6.Text))
            {
                
                label4.Text = "This Phone is Wrong.";
            }
            string gender = "m";
            if (bunifuRadioButton2.Checked)
            {
                gender = "f";
            }
            int age = DateTime.Now.Year - bunifuDatePicker1.Value.Year;
            DateTime d = bunifuDatePicker1.Value;
            string urole = "u";
            Random random = new Random();
            int cash = random.Next(1000, 10000);
            
            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "CREATEMUSER";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("e", bunifuTextBox2.Text);
            cmd.Parameters.Add("f", bunifuTextBox1.Text);
            cmd.Parameters.Add("l", bunifuTextBox3.Text);
            cmd.Parameters.Add("p1", bunifuTextBox5.Text);
            cmd.Parameters.Add("birth", d);
            cmd.Parameters.Add("g", gender);
            cmd.Parameters.Add("ph", bunifuTextBox6.Text);
            cmd.Parameters.Add("r", urole);
            cmd.Parameters.Add("c", cash);
            cmd.ExecuteNonQuery();


            

            MyUser.email = bunifuTextBox2.Text;
            MyUser.firstname = bunifuTextBox1.Text;
            MyUser.lastname = bunifuTextBox3.Text;
            MyUser.password = bunifuTextBox5.Text;
            MyUser.birthdate = d.ToString();
            MyUser.gender = gender;
            MyUser.age = age.ToString();
            MyUser.role = urole;
            MyUser.cash = cash;
            Form1.incta.Close();
        }

        private void Reg_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void bunifuTextBox2_TextChange(object sender, EventArgs e)
        {
            bunifuTextBox2.IconRight = Form1.incta.imagevalidator(Validation.validateUserName(bunifuTextBox2.Text));
        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {
            bunifuTextBox1.IconRight = Form1.incta.imagevalidator(Validation.validateFirstName(bunifuTextBox1.Text));

        }

        private void bunifuTextBox3_TextChange(object sender, EventArgs e)
        {
            bunifuTextBox3.IconRight = Form1.incta.imagevalidator(Validation.validateLastName(bunifuTextBox3.Text));

        }

        private void bunifuTextBox5_TextChange(object sender, EventArgs e)
        {
            bunifuTextBox5.IconRight = Form1.incta.imagevalidator(Validation.validatePassword(bunifuTextBox5.Text));
        }

        private void bunifuTextBox4_TextChange(object sender, EventArgs e)
        {
            bunifuTextBox4.IconRight = Form1.incta.imagevalidator(Validation.validatePasswordconfirm(bunifuTextBox5.Text, bunifuTextBox4.Text));
        }

        private void bunifuTextBox6_TextChange(object sender, EventArgs e)
        {
            bunifuTextBox6.IconRight = Form1.incta.imagevalidator(Validation.validatePhone(bunifuTextBox6.Text));
        }
    }
}
