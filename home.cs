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

namespace movie
{
    public partial class home : Form
    {
        
        public home()
        {
            InitializeComponent();
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
            right_panel.Controls.Add(childForm);
            right_panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*openChildFormInPanel(new tabs.home());*/
            openChildFormInPanel(new tabs.home());
            processing showload = new processing();
            showload.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new tabs.trending());
            processing showload = new processing();
            showload.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new tabs.admin());
            processing showload = new processing();
            showload.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*openChildFormInPanel(new tabs.search_bar());*/
        }
        /*private int xPos = 0, YPos = 0;*/
        private void home_Load(object sender, EventArgs e)
        {
            openChildFormInPanel(new tabs.home());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new tabs.movies_page());
            processing showload = new processing();
            showload.Show();
        }
    }
}
