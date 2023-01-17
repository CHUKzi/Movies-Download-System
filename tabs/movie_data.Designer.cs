
namespace movie.tabs
{
    partial class movie_data
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.get_movie_downloads = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.get_download_button = new System.Windows.Forms.Button();
            this.get_movie_name = new System.Windows.Forms.Label();
            this.get_movie_description = new System.Windows.Forms.RichTextBox();
            this.get_movie_code = new System.Windows.Forms.Label();
            this.get_movie_image = new System.Windows.Forms.PictureBox();
            this.movie_link = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.get_movie_image)).BeginInit();
            this.SuspendLayout();
            // 
            // get_movie_downloads
            // 
            this.get_movie_downloads.AutoSize = true;
            this.get_movie_downloads.Font = new System.Drawing.Font("Bebas Neue", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get_movie_downloads.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            this.get_movie_downloads.Location = new System.Drawing.Point(35, 705);
            this.get_movie_downloads.Name = "get_movie_downloads";
            this.get_movie_downloads.Size = new System.Drawing.Size(120, 43);
            this.get_movie_downloads.TabIndex = 0;
            this.get_movie_downloads.Text = "loading...";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-9, -12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 112);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(1013, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bebas Neue", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(39, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 78);
            this.label2.TabIndex = 0;
            this.label2.Text = "movie details";
            // 
            // get_download_button
            // 
            this.get_download_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            this.get_download_button.Font = new System.Drawing.Font("Bebas Neue", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get_download_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.get_download_button.Location = new System.Drawing.Point(43, 615);
            this.get_download_button.Name = "get_download_button";
            this.get_download_button.Size = new System.Drawing.Size(374, 60);
            this.get_download_button.TabIndex = 5;
            this.get_download_button.Text = "button Name loading..";
            this.get_download_button.UseVisualStyleBackColor = false;
            this.get_download_button.Click += new System.EventHandler(this.get_download_button_Click);
            // 
            // get_movie_name
            // 
            this.get_movie_name.AutoSize = true;
            this.get_movie_name.Font = new System.Drawing.Font("Bebas Neue", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get_movie_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            this.get_movie_name.Location = new System.Drawing.Point(437, 145);
            this.get_movie_name.Name = "get_movie_name";
            this.get_movie_name.Size = new System.Drawing.Size(157, 56);
            this.get_movie_name.TabIndex = 6;
            this.get_movie_name.Text = "loading...";
            // 
            // get_movie_description
            // 
            this.get_movie_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.get_movie_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.get_movie_description.Font = new System.Drawing.Font("Bebas Neue", 19.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get_movie_description.Location = new System.Drawing.Point(447, 216);
            this.get_movie_description.Name = "get_movie_description";
            this.get_movie_description.Size = new System.Drawing.Size(620, 521);
            this.get_movie_description.TabIndex = 7;
            this.get_movie_description.Text = "loading...";
            // 
            // get_movie_code
            // 
            this.get_movie_code.AutoSize = true;
            this.get_movie_code.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get_movie_code.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            this.get_movie_code.Location = new System.Drawing.Point(35, 751);
            this.get_movie_code.Name = "get_movie_code";
            this.get_movie_code.Size = new System.Drawing.Size(103, 37);
            this.get_movie_code.TabIndex = 0;
            this.get_movie_code.Text = "loading...";
            // 
            // get_movie_image
            // 
            this.get_movie_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.get_movie_image.Location = new System.Drawing.Point(43, 145);
            this.get_movie_image.Name = "get_movie_image";
            this.get_movie_image.Size = new System.Drawing.Size(374, 461);
            this.get_movie_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.get_movie_image.TabIndex = 4;
            this.get_movie_image.TabStop = false;
            // 
            // movie_link
            // 
            this.movie_link.AutoSize = true;
            this.movie_link.Location = new System.Drawing.Point(43, 681);
            this.movie_link.Name = "movie_link";
            this.movie_link.Size = new System.Drawing.Size(62, 17);
            this.movie_link.TabIndex = 8;
            this.movie_link.TabStop = true;
            this.movie_link.Text = "loading..";
            this.movie_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.movie_link_LinkClicked);
            // 
            // movie_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1100, 813);
            this.Controls.Add(this.movie_link);
            this.Controls.Add(this.get_movie_description);
            this.Controls.Add(this.get_movie_name);
            this.Controls.Add(this.get_download_button);
            this.Controls.Add(this.get_movie_image);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.get_movie_code);
            this.Controls.Add(this.get_movie_downloads);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1100, 800);
            this.Name = "movie_data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "movie_data";
            this.Load += new System.EventHandler(this.movie_data_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.get_movie_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label get_movie_downloads;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox get_movie_image;
        private System.Windows.Forms.Button get_download_button;
        private System.Windows.Forms.Label get_movie_name;
        private System.Windows.Forms.RichTextBox get_movie_description;
        private System.Windows.Forms.Label get_movie_code;
        private System.Windows.Forms.LinkLabel movie_link;
    }
}