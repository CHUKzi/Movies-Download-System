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
    public partial class movies_upload : Form
    {
        /*string connectionstring = @"Data Source=MSI;Initial Catalog=moviedb;Integrated Security=True";*/
        SqlConnection connection;
        string imgLoc = "";
        public movies_upload()
        {
            InitializeComponent();
        }
        private void browse_Click(object sender, EventArgs e)
        {
            Guid guid = Guid.NewGuid();
            Random random = new Random();
            int i = random.Next();

            id_movie.Text = i.ToString();

            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files (*.*)|*";
                dlg.Title = "Select Employee Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    MovieImage.ImageLocation = imgLoc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void upload_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);

                int by = 1;
                int delete = 0;
                int downloads = 0;

                connection = connection_class.GetSqlConnection();
                string sql = "insert into movies (movie_id, movie_name, movie_description, movie_size, movie_link, movie_upload_by, is_delete, download, movie_image) VALUES ('" + id_movie.Text + "','" + name_movie.Text + "','" + description.Text + "', '" + size_movie.Text + "', '" + link_movie.Text + "', '" + by + "', '" + delete + "', '" + downloads + "', @img)";
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.Add(new SqlParameter("@img", img));
                command.ExecuteNonQuery();
                connection.Close();

                MovieImage.Image = null;
                id_movie.Text = "";
                name_movie.Text = "";
                description.Text = "";
                size_movie.Text = "";
                link_movie.Text = "";

                MessageBox.Show("Upload successfully!!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void movies_upload_Load(object sender, EventArgs e)
        {
            id_movie.Enabled = false;
        }
    }
}
