namespace RegisterLoginSystem
{
    partial class FormPost
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.buttonAddImg = new System.Windows.Forms.Button();
            this.buttonPost = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDeleteImg = new System.Windows.Forms.Button();
            this.labelpost = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "Create a Post";
            // 
            // txtPost
            // 
            this.txtPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPost.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPost.Location = new System.Drawing.Point(44, 55);
            this.txtPost.Multiline = true;
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(216, 28);
            this.txtPost.TabIndex = 15;
            // 
            // buttonAddImg
            // 
            this.buttonAddImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonAddImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddImg.FlatAppearance.BorderSize = 0;
            this.buttonAddImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddImg.ForeColor = System.Drawing.Color.White;
            this.buttonAddImg.Location = new System.Drawing.Point(304, 89);
            this.buttonAddImg.Name = "buttonAddImg";
            this.buttonAddImg.Size = new System.Drawing.Size(117, 30);
            this.buttonAddImg.TabIndex = 21;
            this.buttonAddImg.Text = "Add Image";
            this.buttonAddImg.UseVisualStyleBackColor = false;
            this.buttonAddImg.Click += new System.EventHandler(this.buttonAddImg_Click);
            // 
            // buttonPost
            // 
            this.buttonPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPost.FlatAppearance.BorderSize = 0;
            this.buttonPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPost.ForeColor = System.Drawing.Color.White;
            this.buttonPost.Location = new System.Drawing.Point(304, 296);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(117, 30);
            this.buttonPost.TabIndex = 22;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = false;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.White;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.FlatAppearance.BorderSize = 2;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonClear.Location = new System.Drawing.Point(44, 296);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(216, 30);
            this.buttonClear.TabIndex = 23;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDeleteImg
            // 
            this.buttonDeleteImg.BackColor = System.Drawing.Color.White;
            this.buttonDeleteImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteImg.FlatAppearance.BorderSize = 2;
            this.buttonDeleteImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteImg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonDeleteImg.Location = new System.Drawing.Point(304, 197);
            this.buttonDeleteImg.Name = "buttonDeleteImg";
            this.buttonDeleteImg.Size = new System.Drawing.Size(117, 30);
            this.buttonDeleteImg.TabIndex = 24;
            this.buttonDeleteImg.Text = "Delete Image";
            this.buttonDeleteImg.UseVisualStyleBackColor = false;
            this.buttonDeleteImg.Click += new System.EventHandler(this.buttonDeleteImg_Click);
            // 
            // labelpost
            // 
            this.labelpost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelpost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelpost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelpost.Location = new System.Drawing.Point(301, 122);
            this.labelpost.Name = "labelpost";
            this.labelpost.Size = new System.Drawing.Size(120, 44);
            this.labelpost.TabIndex = 25;
            this.labelpost.Text = "Add images or Drag and Drop from your folder";
            this.labelpost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.Black;
            this.buttonBack.Location = new System.Drawing.Point(344, 15);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(77, 24);
            this.buttonBack.TabIndex = 27;
            this.buttonBack.Text = "BACK";
            this.buttonBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RegisterLoginSystem.Properties.Resources.arrow;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(353, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            this.nextButton.Location = new System.Drawing.Point(266, 168);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(23, 23);
            this.nextButton.TabIndex = 6;
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Visible = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click_1);
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
            this.previousButton.Location = new System.Drawing.Point(15, 168);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(23, 23);
            this.previousButton.TabIndex = 5;
            this.previousButton.UseVisualStyleBackColor = false;
            this.previousButton.Visible = false;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RegisterLoginSystem.Properties.Resources.imgbg;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(44, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormPost
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(453, 359);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelpost);
            this.Controls.Add(this.buttonDeleteImg);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.buttonAddImg);
            this.Controls.Add(this.txtPost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonBack);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPost";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormPost_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormPost_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPost;
        private System.Windows.Forms.Button buttonAddImg;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDeleteImg;
        private System.Windows.Forms.Label labelpost;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonBack;
    }
}