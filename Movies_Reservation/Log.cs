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
    public partial class Log : UserControl
    {
        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection conn;

        public Log()
        {
            InitializeComponent();
        }

        private void btnShowSignUp_Click(object sender, EventArgs e)
        {
            Form1.incta.showSignup();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd;
            OracleDataReader dr;

            if (Validation.validateUserName(bunifuTextBox2.Text) && Validation.validatePassword(bunifuTextBox5.Text))
            {
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from username where email=:e and password1=:p";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("e", bunifuTextBox2.Text);
                cmd.Parameters.Add("p", bunifuTextBox5.Text);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    DateTime d = Convert.ToDateTime(dr[4]);
                    MyUser.email = dr[0].ToString();

                    MyUser.firstname = dr[1].ToString();

                    MyUser.lastname = dr[2].ToString();
                    MyUser.password = dr[3].ToString();
                    MyUser.birthdate = dr[4].ToString();
                    MyUser.gender = dr[5].ToString();
                    MyUser.phone = dr[6].ToString();
                    MyUser.role = dr[7].ToString();
                    MyUser.cash = int.Parse(dr[8].ToString());
                    MyUser.age = (DateTime.Now.Year - d.Year).ToString();

                    Form1.incta.Close();
                }
                else
                {
                    label3.Text = "Email or Password is incorrect.";
                    return;
                }
                dr.Close();
            } else
            {
                label3.Text = "Email or Password is incorrect.";
            }
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

        private void Log_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }
    }
}
