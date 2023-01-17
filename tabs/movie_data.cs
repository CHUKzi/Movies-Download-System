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
using System.Runtime.InteropServices;

namespace movie.tabs
{
    public partial class movie_data : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,     // x-coordinate of upper-left corner
                int nTopRect,      // y-coordinate of upper-left corner
                int nRightRect,    // x-coordinate of lower-right corner
                int nBottomRect,   // y-coordinate of lower-right corner
                int nWidthEllipse, // height of ellipse
                int nHeightEllipse // width of ellipse
            );


        /*        string connectionstring = @"Data Source=MSI;Initial Catalog=moviedb;Integrated Security=True";*/

        SqlConnection connection;
        
        public movie_data(string id)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            get_movie_code.Text = id;

        }

        private void movie_data_Load(object sender, EventArgs e)
        {
            connection = connection_class.GetSqlConnection();

            try
            {
                string sql = "select * from movies WHERE movie_id = ('" + get_movie_code.Text + "')";
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader show = command.ExecuteReader(CommandBehavior.SingleResult);

                show.Read();
                byte[] movie_image = (byte[])(show["movie_image"]);
                MemoryStream ms = new MemoryStream(movie_image);
                get_movie_image.Image = Image.FromStream(ms);

                get_movie_name.Text = show["movie_name"].ToString();
                get_movie_description.Text = show["movie_description"].ToString();
                get_download_button.Text = "Download " + show["movie_size"].ToString();
                get_movie_downloads.Text = "DOWNLOADS " + show["download"].ToString();

                movie_link.Text = show["movie_link"].ToString();

                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("invalid username or password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void get_download_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(movie_link.Text);
            processing showload = new processing();
            showload.Show();

            try
            {
                string sql = "Update movies set download = download+1 WHERE movie_id = ('" + get_movie_code.Text + "')";
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid ID");
            }
        }

        private void movie_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(movie_link.Text);
            try
            {
                string sql = "Update movies set download = download+1 WHERE movie_id = ('" + get_movie_code.Text + "')";
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid ID");
            }
        }
    }
}
