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


namespace movie.tabs
{
    public partial class home : Form
    {
        /*string connectionstring = @"Data Source=MSI;Initial Catalog=moviedb;Integrated Security=True";*/
        SqlConnection connection;

        public home()
        {
            InitializeComponent();
        }
        private void home_Load(object sender, EventArgs e)
        {
            show_result_name.Visible = false;
            result_count.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*textBox1.Location = new Point(55, 85);
              button1.Location = new Point(777, 85);*/
            if (String.IsNullOrEmpty(search_bar.Text))
            {
                MessageBox.Show("Search is required", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connection = connection_class.GetSqlConnection();
                    string sql = "select * from movies WHERE (is_delete = 0 AND movie_name LIKE '%" + search_bar.Text + "%' OR movie_id LIKE '%" + search_bar.Text + "%')";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader show = command.ExecuteReader(CommandBehavior.SingleResult);
                    int count = 0;
                    while (show.Read())
                    {
                        count++;
                        search_bar.Visible = false;
                        search_button.Visible = false;
                        panelend.Visible = false;
                        label1.Visible = false;
                        show_result_name.Visible = true;
                        result_count.Visible = true;
                        processing showload = new processing();
                        showload.Show();

                        show_result_name.Text = "Result for : " + search_bar.Text;
                        //CallToFuntion FOR variable
                        string id = show["movie_id"].ToString();
                        string size = show["movie_size"].ToString();
                        byte[] movie_image = (byte[])(show["movie_image"]);
                        string movie_name = show["movie_name"].ToString();
                        //FUNCTIONS CALL HERE
                        imagecall(movie_image);
                        lablecall(movie_name);
                        buttoncall(id, size);
                        /*panel2.Visible = false;*/
                        pictureBox1.Visible = false;
                    }
                    if (count==0)
                    {
                        MessageBox.Show("No Result Found", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else
                    {
                        result_count.Text = count.ToString() + " Result(S) Found";
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DataBase Not connected", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        int a = 1;
        public System.Windows.Forms.PictureBox imagecall(byte[] movie_image)
        {
            System.Windows.Forms.PictureBox img_here = new System.Windows.Forms.PictureBox();
            this.Controls.Add(img_here);
            img_here.Top = a * 150;
            img_here.Left = 20;
            img_here.Name = this.a.ToString();
            MemoryStream ms = new MemoryStream(movie_image);
            img_here.Image = Image.FromStream(ms);
            img_here.SizeMode = PictureBoxSizeMode.StretchImage;
            img_here.Size = new Size(150, 150);
            a = a + 1;
            return img_here;
        }
        int b = 1;
        public System.Windows.Forms.Label lablecall(string movie_name)
        {
            System.Windows.Forms.Label lable_here = new System.Windows.Forms.Label();
            this.Controls.Add(lable_here);
            lable_here.Top = b * 150;
            lable_here.Left = 170;
            lable_here.Name = this.a.ToString();
            lable_here.Size = new Size(200, 150);
            lable_here.Font = new Font("Bebas Neue", 21f);
            lable_here.Text = movie_name;
            b = b + 1;
            return lable_here;
        }
        int c = 1;
        public System.Windows.Forms.Button buttoncall(string id, string size)
        {
            System.Windows.Forms.Button button_here = new System.Windows.Forms.Button();
            this.Controls.Add(button_here);
            button_here.Top = c * 150;
            button_here.Left = 450;
            button_here.Name = this.a.ToString();
            button_here.Text = "Download\n" + size;

            button_here.Click += new EventHandler(ItemClicked);
            void ItemClicked(Object sender, EventArgs e)
            {
                movie_data show_movie_data = new movie_data(id);
                show_movie_data.Show();
            }

            button_here.BackColor = Color.FromArgb(17, 103, 177);
            button_here.ForeColor = Color.FromArgb(208, 239, 255);
            /*button_here.Font = new Font(FontFamily.GenericSansSerif, 50);*/
            button_here.Size = new Size(200, 150);
            button_here.Font = new Font("Bebas Neue", 28f);
            c = c + 1;
            return button_here;
        }
    }
}
