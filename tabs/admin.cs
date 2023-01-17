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

namespace movie.tabs
{
    public partial class admin : Form
    {
        /*        string connectionstring = @"Data Source=MSI;Initial Catalog=moviedb;Integrated Security=True";*/

        SqlConnection connection;

        public admin()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(username.Text))
            {
                MessageBox.Show("Username is required", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(password.Text))
            {
                MessageBox.Show("password is required", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 

                try
                {
                    connection = connection_class.GetSqlConnection();
                    string sql = "select * from admins WHERE username = ('" + username.Text + "') AND pass = ('" + password.Text + "')";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader show = command.ExecuteReader(CommandBehavior.SingleResult);

                    show.Read();

                    string FirstName = show["firstname"].ToString();
                    username.Text = "";
                    password.Text = "";

                    dashboard.admin_home login = new dashboard.admin_home(FirstName);
                    login.Show();
                    connection.Close();
                }
              
                catch (Exception ex)
                {
                    password.Text = "";
                    MessageBox.Show("Oops, invalid username or password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
