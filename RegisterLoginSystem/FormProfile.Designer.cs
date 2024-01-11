namespace RegisterLoginSystem
{
    partial class FormProfile
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.crtPostbtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelrequests = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelfriends = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usrnameLabel = new System.Windows.Forms.Label();
            this.infolbl = new System.Windows.Forms.Label();
            this.buttoninfoChange = new System.Windows.Forms.Button();
            this.buttonfeed = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonAddFr = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.crtPostbtn);
            this.panel4.Controls.Add(this.flowLayoutPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(155, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(450, 495);
            this.panel4.TabIndex = 8;
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, 37);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(450, 458);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.flowLayoutPanelrequests);
            this.panel2.Controls.Add(this.flowLayoutPanelfriends);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(605, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 495);
            this.panel2.TabIndex = 6;
            // 
            // flowLayoutPanelrequests
            // 
            this.flowLayoutPanelrequests.AutoScroll = true;
            this.flowLayoutPanelrequests.Location = new System.Drawing.Point(10, 269);
            this.flowLayoutPanelrequests.Name = "flowLayoutPanelrequests";
            this.flowLayoutPanelrequests.Size = new System.Drawing.Size(241, 214);
            this.flowLayoutPanelrequests.TabIndex = 6;
            // 
            // flowLayoutPanelfriends
            // 
            this.flowLayoutPanelfriends.AutoScroll = true;
            this.flowLayoutPanelfriends.Location = new System.Drawing.Point(10, 37);
            this.flowLayoutPanelfriends.Name = "flowLayoutPanelfriends";
            this.flowLayoutPanelfriends.Size = new System.Drawing.Size(241, 206);
            this.flowLayoutPanelfriends.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(6, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Friend Requests";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Friends";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(22, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // usrnameLabel
            // 
            this.usrnameLabel.AutoSize = true;
            this.usrnameLabel.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrnameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.usrnameLabel.Location = new System.Drawing.Point(18, 128);
            this.usrnameLabel.Name = "usrnameLabel";
            this.usrnameLabel.Size = new System.Drawing.Size(80, 20);
            this.usrnameLabel.TabIndex = 2;
            this.usrnameLabel.Text = "Username";
            // 
            // infolbl
            // 
            this.infolbl.BackColor = System.Drawing.Color.Transparent;
            this.infolbl.Location = new System.Drawing.Point(22, 166);
            this.infolbl.MinimumSize = new System.Drawing.Size(106, 100);
            this.infolbl.Name = "infolbl";
            this.infolbl.Size = new System.Drawing.Size(106, 100);
            this.infolbl.TabIndex = 5;
            this.infolbl.Text = "info";
            // 
            // buttoninfoChange
            // 
            this.buttoninfoChange.BackColor = System.Drawing.Color.White;
            this.buttoninfoChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttoninfoChange.FlatAppearance.BorderSize = 2;
            this.buttoninfoChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoninfoChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttoninfoChange.Location = new System.Drawing.Point(22, 352);
            this.buttoninfoChange.Name = "buttoninfoChange";
            this.buttoninfoChange.Size = new System.Drawing.Size(106, 35);
            this.buttoninfoChange.TabIndex = 22;
            this.buttoninfoChange.Text = "Change Profile";
            this.buttoninfoChange.UseVisualStyleBackColor = false;
            this.buttoninfoChange.Click += new System.EventHandler(this.buttonInfoChange_Click);
            // 
            // buttonfeed
            // 
            this.buttonfeed.BackColor = System.Drawing.Color.White;
            this.buttonfeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonfeed.FlatAppearance.BorderSize = 2;
            this.buttonfeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonfeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonfeed.Location = new System.Drawing.Point(22, 415);
            this.buttonfeed.Name = "buttonfeed";
            this.buttonfeed.Size = new System.Drawing.Size(106, 35);
            this.buttonfeed.TabIndex = 23;
            this.buttonfeed.Text = "Home";
            this.buttonfeed.UseVisualStyleBackColor = false;
            this.buttonfeed.Click += new System.EventHandler(this.buttonfeed_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.buttonAddFr);
            this.panel3.Controls.Add(this.buttonfeed);
            this.panel3.Controls.Add(this.buttoninfoChange);
            this.panel3.Controls.Add(this.infolbl);
            this.panel3.Controls.Add(this.usrnameLabel);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(155, 495);
            this.panel3.TabIndex = 7;
            // 
            // buttonAddFr
            // 
            this.buttonAddFr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonAddFr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddFr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddFr.ForeColor = System.Drawing.Color.White;
            this.buttonAddFr.Location = new System.Drawing.Point(22, 283);
            this.buttonAddFr.Name = "buttonAddFr";
            this.buttonAddFr.Size = new System.Drawing.Size(106, 31);
            this.buttonAddFr.TabIndex = 1;
            this.buttonAddFr.Text = "Add Friend";
            this.buttonAddFr.UseVisualStyleBackColor = false;
            this.buttonAddFr.Click += new System.EventHandler(this.buttonAddFr_Click);
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(861, 495);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FormProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProfile";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormProfile_FormClosed);
            this.Load += new System.EventHandler(this.FormProfile_Load);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button crtPostbtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelrequests;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelfriends;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label usrnameLabel;
        private System.Windows.Forms.Label infolbl;
        private System.Windows.Forms.Button buttoninfoChange;
        private System.Windows.Forms.Button buttonfeed;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonAddFr;
    }
}