namespace RegisterLoginSystem
{
    partial class FormInfo
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
            this.pictureBoxback = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeleteImg = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonAddImg = new System.Windows.Forms.Button();
            this.txtAbout = new System.Windows.Forms.TextBox();
            this.labelEditProf = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBoxProf = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProf)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxback
            // 
            this.pictureBoxback.Image = global::RegisterLoginSystem.Properties.Resources.arrow;
            this.pictureBoxback.ImageLocation = "";
            this.pictureBoxback.Location = new System.Drawing.Point(307, 18);
            this.pictureBoxback.Name = "pictureBoxback";
            this.pictureBoxback.Size = new System.Drawing.Size(25, 24);
            this.pictureBoxback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxback.TabIndex = 38;
            this.pictureBoxback.TabStop = false;
            this.pictureBoxback.Click += new System.EventHandler(this.pictureBoxback_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(229, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 33);
            this.label1.TabIndex = 37;
            this.label1.Text = "Add images or Drag and Drop ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDeleteImg
            // 
            this.buttonDeleteImg.BackColor = System.Drawing.Color.White;
            this.buttonDeleteImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteImg.FlatAppearance.BorderSize = 2;
            this.buttonDeleteImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteImg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonDeleteImg.Location = new System.Drawing.Point(203, 142);
            this.buttonDeleteImg.Name = "buttonDeleteImg";
            this.buttonDeleteImg.Size = new System.Drawing.Size(117, 30);
            this.buttonDeleteImg.TabIndex = 36;
            this.buttonDeleteImg.Text = "Delete Image";
            this.buttonDeleteImg.UseVisualStyleBackColor = false;
            this.buttonDeleteImg.Click += new System.EventHandler(this.buttonDeleteImg_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.White;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.FlatAppearance.BorderSize = 2;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonClear.Location = new System.Drawing.Point(43, 194);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(87, 30);
            this.buttonClear.TabIndex = 35;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone.FlatAppearance.BorderSize = 0;
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone.ForeColor = System.Drawing.Color.White;
            this.buttonDone.Location = new System.Drawing.Point(43, 265);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(87, 30);
            this.buttonDone.TabIndex = 34;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonAddImg
            // 
            this.buttonAddImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonAddImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddImg.FlatAppearance.BorderSize = 0;
            this.buttonAddImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddImg.ForeColor = System.Drawing.Color.White;
            this.buttonAddImg.Location = new System.Drawing.Point(203, 73);
            this.buttonAddImg.Name = "buttonAddImg";
            this.buttonAddImg.Size = new System.Drawing.Size(117, 30);
            this.buttonAddImg.TabIndex = 33;
            this.buttonAddImg.Text = "Add Image";
            this.buttonAddImg.UseVisualStyleBackColor = false;
            this.buttonAddImg.Click += new System.EventHandler(this.buttonAddImg_Click);
            // 
            // txtAbout
            // 
            this.txtAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAbout.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbout.Location = new System.Drawing.Point(198, 194);
            this.txtAbout.Multiline = true;
            this.txtAbout.Name = "txtAbout";
            this.txtAbout.Size = new System.Drawing.Size(122, 101);
            this.txtAbout.TabIndex = 32;
            // 
            // labelEditProf
            // 
            this.labelEditProf.AutoSize = true;
            this.labelEditProf.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditProf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelEditProf.Location = new System.Drawing.Point(12, 18);
            this.labelEditProf.Name = "labelEditProf";
            this.labelEditProf.Size = new System.Drawing.Size(271, 27);
            this.labelEditProf.TabIndex = 31;
            this.labelEditProf.Text = "Edit Your Profile Info";
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
            this.buttonBack.Location = new System.Drawing.Point(298, 18);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(77, 24);
            this.buttonBack.TabIndex = 39;
            this.buttonBack.Text = "BACK";
            this.buttonBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // pictureBoxProf
            // 
            this.pictureBoxProf.Location = new System.Drawing.Point(43, 73);
            this.pictureBoxProf.Name = "pictureBoxProf";
            this.pictureBoxProf.Size = new System.Drawing.Size(106, 99);
            this.pictureBoxProf.TabIndex = 40;
            this.pictureBoxProf.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(198, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 33);
            this.label2.TabIndex = 41;
            this.label2.Text = "Change your about info";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // FormInfo
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(376, 343);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxProf);
            this.Controls.Add(this.pictureBoxback);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDeleteImg);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonAddImg);
            this.Controls.Add(this.txtAbout);
            this.Controls.Add(this.labelEditProf);
            this.Controls.Add(this.buttonBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInfo";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormInfo_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormInfo_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeleteImg;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonAddImg;
        private System.Windows.Forms.TextBox txtAbout;
        private System.Windows.Forms.Label labelEditProf;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBoxProf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}