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
    public partial class ShowMyMoives : UserControl
    {
        string ordb = "data source=orcl;user id = hr;password = hr;";
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataReader dr;
        public ShowMyMoives()
        {
            InitializeComponent();
        }

        private void ShowMyMoives_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            //Get user movies
            flowLayoutPanel1.Controls.Clear();

            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "VIEWUSERMOVIES";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("e", MyUser.email);
            cmd.Parameters.Add("rec", OracleDbType.RefCursor, ParameterDirection.Output);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                List<string> ls = new List<string>();
                ls.Add(dr[0].ToString());
                ls.Add(dr[1].ToString());
                ls.Add(dr[2].ToString());
                ls.Add(dr[3].ToString());
                ls.Add(dr[4].ToString());
                ls.Add(dr[5].ToString());
                ls.Add(dr[6].ToString());
                Movie movie = new Movie();
                movie.setvalues(ls);
                flowLayoutPanel1.Controls.Add(movie);
            }
        }

        internal void myRefresh()
        {
            //Get user movies
            flowLayoutPanel1.Controls.Clear();

            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "VIEWUSERMOVIES";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("e", MyUser.email);
            cmd.Parameters.Add("rec", OracleDbType.RefCursor, ParameterDirection.Output);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                List<string> ls = new List<string>();
                ls.Add(dr[0].ToString());
                ls.Add(dr[1].ToString());
                ls.Add(dr[2].ToString());
                ls.Add(dr[3].ToString());
                ls.Add(dr[4].ToString());
                ls.Add(dr[5].ToString());
                ls.Add(dr[6].ToString());
                Movie movie = new Movie();
                movie.setvalues(ls);
                flowLayoutPanel1.Controls.Add(movie);
            }
        }
    }
}
