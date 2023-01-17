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
using System.IO;

namespace movie.tabs.dashboard.admin_tabs
{
    public partial class all_movies : Form
    {
        /*string connectionstring = @"Data Source=MSI;Initial Catalog=moviedb;Integrated Security=True";*/
        SqlConnection connection;
        string imgLoc = "";
        public all_movies()
        {
            InitializeComponent();
        }

        private void all_movies_Load(object sender, EventArgs e)
        {

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            try
            {
                connection = connection_class.GetSqlConnection();
                string sql = "select movie_id, movie_name, movie_size, download from movies WHERE is_delete = 0"; //movie_upload_by
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

        private void button4_Click(object sender, EventArgs e)
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
            if (String.IsNullOrEmpty(Search_text.Text))
            {
                MessageBox.Show("Search is required", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connection = connection_class.GetSqlConnection();
                    string sql = "select * from movies WHERE (movie_id LIKE '%" + Search_text.Text + "%')";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader show = command.ExecuteReader(CommandBehavior.SingleResult);
                    show.Read();
                    {
                        byte[] movie_image = (byte[])(show["movie_image"]);
                        MemoryStream ms = new MemoryStream(movie_image);
                        pictureBox1.Image = Image.FromStream(ms);

                        name_movie.Text = show["movie_name"].ToString();
                        link_movie.Text = show["movie_link"].ToString();
                        size_movie.Text = show["movie_size"].ToString();

                        description_movie.Text = show["movie_description"].ToString();
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DataBase Not connected", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files (*.*)|*";
                dlg.Title = "Select Employee Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    pictureBox1.ImageLocation = imgLoc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(imgLoc))
            {
                try
                {
                    connection = connection_class.GetSqlConnection();
                    string sql = "Update movies set movie_name = '" + name_movie.Text + "', movie_link = '" + link_movie.Text + "', movie_size = '" + size_movie.Text + "', movie_description = '" + description_movie.Text + "' WHERE movie_id = ('" + Search_text.Text + "')";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Update Successfully!!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else
            {
                try
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    connection = connection_class.GetSqlConnection();
                    string sql = "Update movies set movie_name = '" + name_movie.Text + "', movie_link = '" + link_movie.Text + "', movie_size = '" + size_movie.Text + "', movie_description = '" + description_movie.Text + "', movie_image = @img WHERE movie_id = ('" + Search_text.Text + "')";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.Add(new SqlParameter("@img", img));
                    command.ExecuteNonQuery();
                    MessageBox.Show("Update Successfully!!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                connection = connection_class.GetSqlConnection();
                string sql = "Update movies set is_delete = 1 WHERE movie_id = ('" + Search_text.Text + "')";
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                MessageBox.Show(name_movie.Text + " is Delete Successfully!!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                pictureBox1.Image = null;
                name_movie.Text = "";
                link_movie.Text = "";
                size_movie.Text = "";
                description_movie.Text = "";
                
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection faild");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            processing showload = new processing();
            showload.Show();

            pictureBox1.Image = null;
            name_movie.Text = "";
            link_movie.Text = "";
            size_movie.Text = "";
            description_movie.Text = "";
        }
    }
}
