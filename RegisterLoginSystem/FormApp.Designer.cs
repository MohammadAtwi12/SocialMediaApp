using System.Drawing;
using System.Windows.Forms;

namespace RegisterLoginSystem
{
    partial class FormApp
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
            this.crtPostbtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanesu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelSuggestions = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonprofile = new System.Windows.Forms.Button();
            this.infolbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usrnameLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxsearch = new System.Windows.Forms.TextBox();
            this.pictureBoxlogout = new System.Windows.Forms.PictureBox();
            this.buttonlogout = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogout)).BeginInit();
            this.SuspendLayout();
            // 
            // crtPostbtn
            // 
            this.crtPostbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.crtPostbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crtPostbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crtPostbtn.ForeColor = System.Drawing.Color.White;
            this.crtPostbtn.Location = new System.Drawing.Point(100, 3);
            this.crtPostbtn.Name = "crtPostbtn";
            this.crtPostbtn.Size = new System.Drawing.Size(236, 31);
            this.crtPostbtn.TabIndex = 0;
            this.crtPostbtn.Text = "Create a Post";
            this.crtPostbtn.UseVisualStyleBackColor = false;
            this.crtPostbtn.Click += new System.EventHandler(this.crtPostbtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 37);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(450, 426);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(450, 426);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.flowLayoutPanesu);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.crtPostbtn);
            this.panel4.Controls.Add(this.flowLayoutPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(170, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(678, 463);
            this.panel4.TabIndex = 5;
            // 
            // flowLayoutPanesu
            // 
            this.flowLayoutPanesu.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanesu.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanesu.Name = "flowLayoutPanesu";
            this.flowLayoutPanesu.Size = new System.Drawing.Size(449, 187);
            this.flowLayoutPanesu.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.flowLayoutPanelSuggestions);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(449, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 463);
            this.panel1.TabIndex = 2;
            // 
            // flowLayoutPanelSuggestions
            // 
            this.flowLayoutPanelSuggestions.AutoScroll = true;
            this.flowLayoutPanelSuggestions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanelSuggestions.Location = new System.Drawing.Point(0, 46);
            this.flowLayoutPanelSuggestions.Name = "flowLayoutPanelSuggestions";
            this.flowLayoutPanelSuggestions.Size = new System.Drawing.Size(227, 415);
            this.flowLayoutPanelSuggestions.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Suggestions";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.buttonprofile);
            this.panel3.Controls.Add(this.infolbl);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.usrnameLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 463);
            this.panel3.TabIndex = 4;
            // 
            // buttonprofile
            // 
            this.buttonprofile.BackColor = System.Drawing.Color.White;
            this.buttonprofile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonprofile.FlatAppearance.BorderSize = 2;
            this.buttonprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonprofile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonprofile.Location = new System.Drawing.Point(27, 370);
            this.buttonprofile.Name = "buttonprofile";
            this.buttonprofile.Size = new System.Drawing.Size(106, 47);
            this.buttonprofile.TabIndex = 26;
            this.buttonprofile.Text = "Profile";
            this.buttonprofile.UseVisualStyleBackColor = false;
            this.buttonprofile.Click += new System.EventHandler(this.buttonprofile_Click);
            // 
            // infolbl
            // 
            this.infolbl.BackColor = System.Drawing.Color.Transparent;
            this.infolbl.Location = new System.Drawing.Point(27, 164);
            this.infolbl.MinimumSize = new System.Drawing.Size(106, 100);
            this.infolbl.Name = "infolbl";
            this.infolbl.Size = new System.Drawing.Size(106, 100);
            this.infolbl.TabIndex = 25;
            this.infolbl.Text = "info";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // usrnameLabel
            // 
            this.usrnameLabel.AutoSize = true;
            this.usrnameLabel.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrnameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.usrnameLabel.Location = new System.Drawing.Point(23, 126);
            this.usrnameLabel.Name = "usrnameLabel";
            this.usrnameLabel.Size = new System.Drawing.Size(80, 20);
            this.usrnameLabel.TabIndex = 24;
            this.usrnameLabel.Text = "Username";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.textBoxsearch);
            this.panel2.Controls.Add(this.pictureBoxlogout);
            this.panel2.Controls.Add(this.buttonlogout);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 49);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::RegisterLoginSystem.Properties.Resources.search;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(625, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 26);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // textBoxsearch
            // 
            this.textBoxsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxsearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxsearch.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxsearch.Location = new System.Drawing.Point(170, 10);
            this.textBoxsearch.Multiline = true;
            this.textBoxsearch.Name = "textBoxsearch";
            this.textBoxsearch.Size = new System.Drawing.Size(449, 28);
            this.textBoxsearch.TabIndex = 29;
            this.textBoxsearch.TextChanged += new System.EventHandler(this.textBoxsearch_TextChanged);
            // 
            // pictureBoxlogout
            // 
            this.pictureBoxlogout.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxlogout.BackgroundImage = global::RegisterLoginSystem.Properties.Resources.logout;
            this.pictureBoxlogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxlogout.Location = new System.Drawing.Point(756, 3);
            this.pictureBoxlogout.Name = "pictureBoxlogout";
            this.pictureBoxlogout.Size = new System.Drawing.Size(27, 40);
            this.pictureBoxlogout.TabIndex = 28;
            this.pictureBoxlogout.TabStop = false;
            this.pictureBoxlogout.Click += new System.EventHandler(this.pictureBoxlogout_Click);
            // 
            // buttonlogout
            // 
            this.buttonlogout.BackColor = System.Drawing.Color.Transparent;
            this.buttonlogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonlogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonlogout.FlatAppearance.BorderSize = 0;
            this.buttonlogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonlogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogout.ForeColor = System.Drawing.Color.Black;
            this.buttonlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonlogout.Location = new System.Drawing.Point(747, 3);
            this.buttonlogout.Name = "buttonlogout";
            this.buttonlogout.Size = new System.Drawing.Size(89, 40);
            this.buttonlogout.TabIndex = 27;
            this.buttonlogout.Text = "Logout";
            this.buttonlogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonlogout.UseVisualStyleBackColor = false;
            this.buttonlogout.Click += new System.EventHandler(this.buttonlogout_Click);
            // 
            // FormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(848, 512);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormApp_FormClosed);
            this.Load += new System.EventHandler(this.FormApp_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogout)).EndInit();
            this.ResumeLayout(false);

        }

        private Button crtPostbtn;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel4;
        private Panel panel3;
        private Button buttonprofile;
        private Label infolbl;
        private PictureBox pictureBox1;
        private Label usrnameLabel;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanelSuggestions;
        private Button buttonlogout;
        private PictureBox pictureBoxlogout;
        private PictureBox pictureBox2;
        private TextBox textBoxsearch;
        private FlowLayoutPanel flowLayoutPanesu;
    }
    #endregion
}