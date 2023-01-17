using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movie.tabs.dashboard
{
    public partial class admin_home : Form
    {
        public admin_home(string welcome_name)
        {
            InitializeComponent();
            welcome_user_name.Text = "Hellow " +welcome_name;
        }

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            admin_right_panel.Controls.Add(childForm);
            admin_right_panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new admin_tabs.admin_home_page());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new admin_tabs.all_movies());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new admin_tabs.movies_upload());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new admin_tabs.deleted_movies());
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void admin_home_Load(object sender, EventArgs e)
        {
            openChildFormInPanel(new admin_tabs.admin_home_page());
        }
    }
}
