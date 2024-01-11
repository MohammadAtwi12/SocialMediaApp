using System.Drawing;

namespace RegisterLoginSystem
{
    partial class PostControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usrnameLabel = new System.Windows.Forms.Label();
            this.posttxtLabel = new System.Windows.Forms.Label();
            this.labelnolikes = new System.Windows.Forms.Label();
            this.pictureBoxprof = new System.Windows.Forms.PictureBox();
            this.commentButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.likeButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.PostpictureBox = new System.Windows.Forms.PictureBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labeltime = new System.Windows.Forms.Label();
            this.labelcomments = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxprof)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // usrnameLabel
            // 
            this.usrnameLabel.AutoSize = true;
            this.usrnameLabel.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrnameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.usrnameLabel.Location = new System.Drawing.Point(53, 7);
            this.usrnameLabel.Name = "usrnameLabel";
            this.usrnameLabel.Size = new System.Drawing.Size(80, 20);
            this.usrnameLabel.TabIndex = 0;
            this.usrnameLabel.Text = "Username";
            this.usrnameLabel.Click += new System.EventHandler(this.usrnameLabel_Click);
            // 
            // posttxtLabel
            // 
            this.posttxtLabel.AutoSize = true;
            this.posttxtLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posttxtLabel.ForeColor = System.Drawing.Color.Black;
            this.posttxtLabel.Location = new System.Drawing.Point(43, 49);
            this.posttxtLabel.MaximumSize = new System.Drawing.Size(320, 21474800);
            this.posttxtLabel.Name = "posttxtLabel";
            this.posttxtLabel.Size = new System.Drawing.Size(133, 15);
            this.posttxtLabel.TabIndex = 1;
            this.posttxtLabel.Text = "Text inputed by the user";
            this.posttxtLabel.SizeChanged += new System.EventHandler(this.posttxtLabel_SizeChanged);
            // 
            // labelnolikes
            // 
            this.labelnolikes.AutoSize = true;
            this.labelnolikes.Location = new System.Drawing.Point(54, 317);
            this.labelnolikes.Name = "labelnolikes";
            this.labelnolikes.Size = new System.Drawing.Size(35, 13);
            this.labelnolikes.TabIndex = 0;
            this.labelnolikes.Text = "label1";
            // 
            // pictureBoxprof
            // 
            this.pictureBoxprof.Location = new System.Drawing.Point(9, 7);
            this.pictureBoxprof.Name = "pictureBoxprof";
            this.pictureBoxprof.Size = new System.Drawing.Size(39, 39);
            this.pictureBoxprof.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxprof.TabIndex = 24;
            this.pictureBoxprof.TabStop = false;
            // 
            // commentButton
            // 
            this.commentButton.BackColor = System.Drawing.Color.Transparent;
            this.commentButton.BackgroundImage = global::RegisterLoginSystem.Properties.Resources.comment;
            this.commentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.commentButton.FlatAppearance.BorderSize = 0;
            this.commentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.commentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.commentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.commentButton.ForeColor = System.Drawing.Color.Transparent;
            this.commentButton.Location = new System.Drawing.Point(364, 300);
            this.commentButton.Name = "commentButton";
            this.commentButton.Size = new System.Drawing.Size(31, 30);
            this.commentButton.TabIndex = 23;
            this.commentButton.UseVisualStyleBackColor = false;
            this.commentButton.Click += new System.EventHandler(this.commentButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.BackColor = System.Drawing.Color.Transparent;
            this.previousButton.BackgroundImage = global::RegisterLoginSystem.Properties.Resources.left_arrow;
            this.previousButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.previousButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previousButton.FlatAppearance.BorderSize = 0;
            this.previousButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.previousButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.previousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousButton.Location = new System.Drawing.Point(20, 172);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(20, 23);
            this.previousButton.TabIndex = 20;
            this.previousButton.UseVisualStyleBackColor = false;
            this.previousButton.Visible = false;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // likeButton
            // 
            this.likeButton.BackColor = System.Drawing.Color.Transparent;
            this.likeButton.BackgroundImage = global::RegisterLoginSystem.Properties.Resources.love;
            this.likeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.likeButton.FlatAppearance.BorderSize = 0;
            this.likeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.likeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.likeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.likeButton.ForeColor = System.Drawing.Color.Transparent;
            this.likeButton.Location = new System.Drawing.Point(20, 302);
            this.likeButton.Name = "likeButton";
            this.likeButton.Size = new System.Drawing.Size(28, 28);
            this.likeButton.TabIndex = 21;
            this.likeButton.UseVisualStyleBackColor = false;
            this.likeButton.Click += new System.EventHandler(this.likeButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.Transparent;
            this.nextButton.BackgroundImage = global::RegisterLoginSystem.Properties.Resources.right_arrow;
            this.nextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextButton.FlatAppearance.BorderSize = 0;
            this.nextButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Location = new System.Drawing.Point(372, 172);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(20, 23);
            this.nextButton.TabIndex = 19;
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Visible = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // PostpictureBox
            // 
            this.PostpictureBox.BackColor = System.Drawing.Color.White;
            this.PostpictureBox.Location = new System.Drawing.Point(46, 83);
            this.PostpictureBox.Name = "PostpictureBox";
            this.PostpictureBox.Size = new System.Drawing.Size(320, 199);
            this.PostpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PostpictureBox.TabIndex = 18;
            this.PostpictureBox.TabStop = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.BackgroundImage = global::RegisterLoginSystem.Properties.Resources.bin;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(367, 14);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(28, 26);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labeltime
            // 
            this.labeltime.AutoSize = true;
            this.labeltime.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltime.ForeColor = System.Drawing.Color.DarkGray;
            this.labeltime.Location = new System.Drawing.Point(54, 27);
            this.labeltime.MaximumSize = new System.Drawing.Size(320, 21474800);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(30, 13);
            this.labeltime.TabIndex = 25;
            this.labeltime.Text = "date";
            // 
            // labelcomments
            // 
            this.labelcomments.AutoSize = true;
            this.labelcomments.Location = new System.Drawing.Point(323, 317);
            this.labelcomments.Name = "labelcomments";
            this.labelcomments.Size = new System.Drawing.Size(35, 13);
            this.labelcomments.TabIndex = 26;
            this.labelcomments.Text = "label1";
            this.labelcomments.Click += new System.EventHandler(this.labelcomments_Click);
            // 
            // PostControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.labelcomments);
            this.Controls.Add(this.labeltime);
            this.Controls.Add(this.pictureBoxprof);
            this.Controls.Add(this.labelnolikes);
            this.Controls.Add(this.commentButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.likeButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.PostpictureBox);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.posttxtLabel);
            this.Controls.Add(this.usrnameLabel);
            this.Name = "PostControl";
            this.Padding = new System.Windows.Forms.Padding(20, 20, 10, 20);
            this.Size = new System.Drawing.Size(409, 353);
            this.Load += new System.EventHandler(this.PostControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxprof)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usrnameLabel;
        private System.Windows.Forms.Label posttxtLabel;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button commentButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button likeButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.PictureBox PostpictureBox;
        private System.Windows.Forms.Label labelnolikes;
        private System.Windows.Forms.PictureBox pictureBoxprof;
        private System.Windows.Forms.Label labeltime;
        private System.Windows.Forms.Label labelcomments;
    }
}
