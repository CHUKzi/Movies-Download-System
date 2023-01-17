
namespace movie.tabs.dashboard.admin_tabs
{
    partial class admin_home_page
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uploads = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Deleted = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bebas Neue", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(29, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 78);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dashboard";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.uploads);
            this.panel1.Location = new System.Drawing.Point(24, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 185);
            this.panel1.TabIndex = 5;
            // 
            // uploads
            // 
            this.uploads.AutoSize = true;
            this.uploads.Font = new System.Drawing.Font("Bebas Neue", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploads.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.uploads.Location = new System.Drawing.Point(3, 31);
            this.uploads.Name = "uploads";
            this.uploads.Size = new System.Drawing.Size(149, 56);
            this.uploads.TabIndex = 0;
            this.uploads.Text = "loading..";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.Deleted);
            this.panel2.Location = new System.Drawing.Point(421, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 185);
            this.panel2.TabIndex = 6;
            // 
            // Deleted
            // 
            this.Deleted.AutoSize = true;
            this.Deleted.Font = new System.Drawing.Font("Bebas Neue", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deleted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Deleted.Location = new System.Drawing.Point(3, 31);
            this.Deleted.Name = "Deleted";
            this.Deleted.Size = new System.Drawing.Size(149, 56);
            this.Deleted.TabIndex = 1;
            this.Deleted.Text = "loading..";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(-6, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(837, 514);
            this.panel3.TabIndex = 7;
            // 
            // admin_home_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(825, 596);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Name = "admin_home_page";
            this.Text = "admin_home_page";
            this.Load += new System.EventHandler(this.admin_home_page_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label uploads;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Deleted;
        private System.Windows.Forms.Panel panel3;
    }
}