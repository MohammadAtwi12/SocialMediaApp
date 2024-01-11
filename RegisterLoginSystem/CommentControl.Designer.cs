namespace RegisterLoginSystem
{
    partial class CommentControl
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
            this.userenameLabel = new System.Windows.Forms.Label();
            this.commenttxtLabel = new System.Windows.Forms.Label();
            this.buttonDeleteCom = new System.Windows.Forms.Button();
            this.pictureBoxprof = new System.Windows.Forms.PictureBox();
            this.labeltime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxprof)).BeginInit();
            this.SuspendLayout();
            // 
            // userenameLabel
            // 
            this.userenameLabel.AutoSize = true;
            this.userenameLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userenameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.userenameLabel.Location = new System.Drawing.Point(31, 6);
            this.userenameLabel.Name = "userenameLabel";
            this.userenameLabel.Size = new System.Drawing.Size(64, 15);
            this.userenameLabel.TabIndex = 1;
            this.userenameLabel.Text = "Username";
            this.userenameLabel.Click += new System.EventHandler(this.userenameLabel_Click);
            // 
            // commenttxtLabel
            // 
            this.commenttxtLabel.AutoSize = true;
            this.commenttxtLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commenttxtLabel.ForeColor = System.Drawing.Color.Black;
            this.commenttxtLabel.Location = new System.Drawing.Point(16, 27);
            this.commenttxtLabel.MaximumSize = new System.Drawing.Size(180, 21474800);
            this.commenttxtLabel.Name = "commenttxtLabel";
            this.commenttxtLabel.Size = new System.Drawing.Size(133, 15);
            this.commenttxtLabel.TabIndex = 2;
            this.commenttxtLabel.Text = "Text inputed by the user";
            // 
            // buttonDeleteCom
            // 
            this.buttonDeleteCom.BackColor = System.Drawing.Color.Transparent;
            this.buttonDeleteCom.BackgroundImage = global::RegisterLoginSystem.Properties.Resources.bin;
            this.buttonDeleteCom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDeleteCom.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonDeleteCom.FlatAppearance.BorderSize = 0;
            this.buttonDeleteCom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonDeleteCom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonDeleteCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteCom.Location = new System.Drawing.Point(194, 3);
            this.buttonDeleteCom.Name = "buttonDeleteCom";
            this.buttonDeleteCom.Size = new System.Drawing.Size(29, 21);
            this.buttonDeleteCom.TabIndex = 10;
            this.buttonDeleteCom.UseVisualStyleBackColor = false;
            this.buttonDeleteCom.Click += new System.EventHandler(this.buttonDeleteCom_Click);
            // 
            // pictureBoxprof
            // 
            this.pictureBoxprof.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxprof.Name = "pictureBoxprof";
            this.pictureBoxprof.Size = new System.Drawing.Size(22, 22);
            this.pictureBoxprof.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxprof.TabIndex = 25;
            this.pictureBoxprof.TabStop = false;
            // 
            // labeltime
            // 
            this.labeltime.AutoSize = true;
            this.labeltime.Font = new System.Drawing.Font("Nirmala UI", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltime.ForeColor = System.Drawing.Color.DarkGray;
            this.labeltime.Location = new System.Drawing.Point(101, 7);
            this.labeltime.MaximumSize = new System.Drawing.Size(320, 21474800);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(19, 10);
            this.labeltime.TabIndex = 26;
            this.labeltime.Text = "date";
            // 
            // CommentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labeltime);
            this.Controls.Add(this.pictureBoxprof);
            this.Controls.Add(this.buttonDeleteCom);
            this.Controls.Add(this.commenttxtLabel);
            this.Controls.Add(this.userenameLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CommentControl";
            this.Size = new System.Drawing.Size(226, 59);
            this.Load += new System.EventHandler(this.CommentControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxprof)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userenameLabel;
        private System.Windows.Forms.Label commenttxtLabel;
        private System.Windows.Forms.Button buttonDeleteCom;
        private System.Windows.Forms.PictureBox pictureBoxprof;
        private System.Windows.Forms.Label labeltime;
    }
}
