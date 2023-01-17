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
    public partial class deleted_movies : Form
    {
        SqlConnection connection;
        public deleted_movies()
        {
            InitializeComponent();
        }

        private void deleted_movies_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            try
            {
                connection = connection_class.GetSqlConnection();
                string sql = "select movie_id, movie_name, movie_size, download from movies WHERE is_delete = 1"; //movie_upload_by
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("connection faile!!");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            try
            {
                connection = connection_class.GetSqlConnection();
                string sql = "select movie_id, movie_name, movie_size, download from movies WHERE (is_delete = 0 AND movie_name LIKE '%" + Search_movie.Text + "%' OR movie_id LIKE '%" + Search_movie.Text + "%')"; //movie_upload_by
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("connection faile!!");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connection = connection_class.GetSqlConnection();
                string sql = "Update movies set is_delete = 0 WHERE movie_id = ('" + search_id.Text + "')";
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                search_id.Text = "";
                MessageBox.Show("Recover Successfully!!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid ID");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connection = connection_class.GetSqlConnection();
                string sql = "Delete from movies WHERE movie_id = ('" + search_id.Text + "')";
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                search_id.Text = "";
                MessageBox.Show("Delete Successfully!!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid ID");
            }
        }
    }
}
