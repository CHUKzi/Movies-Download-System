using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace movie.tabs.dashboard.admin_tabs
{
    public partial class admin_home_page : Form
    {
        /*string connectionstring = @"Data Source=MSI;Initial Catalog=moviedb;Integrated Security=True";*/
        SqlConnection connection;
        public admin_home_page()
        {
            InitializeComponent();
        }

        private void admin_home_page_Load(object sender, EventArgs e)
        {
            try
            {
                connection = connection_class.GetSqlConnection();
                string sql = "select * from movies WHERE (is_delete = '0')"; //title 
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader show = command.ExecuteReader(CommandBehavior.SingleResult);
                int count = 0;
                while (show.Read())
                {
                    count++;
                }
                uploads.Text = count.ToString() + " \nMovies Uploaded";
                connection.Close();
            }

            catch (Exception ex)
            {
                /*panel1.Visible = false;*/
            }

            try
            {
                connection = connection_class.GetSqlConnection();
                string sql = "select * from movies WHERE (is_delete = '1')"; //title 
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader show = command.ExecuteReader(CommandBehavior.SingleResult);
                int count = 0;
                while (show.Read())
                {
                    count++;
                }
                Deleted.Text = count.ToString() + " \nMovies Deleted";
                connection.Close();
            }

            catch (Exception ex)
            {
                /*panel1.Visible = false;*/
            }
        }

    }
}
