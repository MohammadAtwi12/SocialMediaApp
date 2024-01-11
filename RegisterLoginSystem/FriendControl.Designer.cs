namespace RegisterLoginSystem
{
    partial class FriendControl
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
            this.buttonreject = new System.Windows.Forms.Button();
            this.buttonAdd_Accept_remove = new System.Windows.Forms.Button();
            this.pictureBoxprof = new System.Windows.Forms.PictureBox();
            this.labelname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxprof)).BeginInit();
            this.SuspendLayout();
            // 
            // userenameLabel
            // 
            this.userenameLabel.AutoSize = true;
            this.userenameLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userenameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.userenameLabel.Location = new System.Drawing.Point(50, 14);
            this.userenameLabel.Name = "userenameLabel";
            this.userenameLabel.Size = new System.Drawing.Size(69, 17);
            this.userenameLabel.TabIndex = 26;
            this.userenameLabel.Text = "Username";
            this.userenameLabel.Click += new System.EventHandler(this.userenameLabel_Click);
            // 
            // buttonreject
            // 
            this.buttonreject.BackColor = System.Drawing.Color.White;
            this.buttonreject.BackgroundImage = global::RegisterLoginSystem.Properties.Resources.decline;
            this.buttonreject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonreject.FlatAppearance.BorderSize = 0;
            this.buttonreject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonreject.Location = new System.Drawing.Point(135, 5);
            this.buttonreject.Name = "buttonreject";
            this.buttonreject.Size = new System.Drawing.Size(40, 37);
            this.buttonreject.TabIndex = 31;
            this.buttonreject.UseVisualStyleBackColor = false;
            this.buttonreject.Click += new System.EventHandler(this.buttonreject_Click);
            // 
            // buttonAdd_Accept_remove
            // 
            this.buttonAdd_Accept_remove.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd_Accept_remove.BackgroundImage = global::RegisterLoginSystem.Properties.Resources.check;
            this.buttonAdd_Accept_remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAdd_Accept_remove.FlatAppearance.BorderSize = 0;
            this.buttonAdd_Accept_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd_Accept_remove.Location = new System.Drawing.Point(181, 11);
            this.buttonAdd_Accept_remove.Name = "buttonAdd_Accept_remove";
            this.buttonAdd_Accept_remove.Size = new System.Drawing.Size(25, 24);
            this.buttonAdd_Accept_remove.TabIndex = 30;
            this.buttonAdd_Accept_remove.UseVisualStyleBackColor = false;
            this.buttonAdd_Accept_remove.Click += new System.EventHandler(this.buttonAdd_Accept_remove_Click);
            // 
            // pictureBoxprof
            // 
            this.pictureBoxprof.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxprof.Name = "pictureBoxprof";
            this.pictureBoxprof.Size = new System.Drawing.Size(41, 41);
            this.pictureBoxprof.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxprof.TabIndex = 29;
            this.pictureBoxprof.TabStop = false;
            // 
            // labelname
            // 
            this.labelname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.ForeColor = System.Drawing.Color.DarkGray;
            this.labelname.Location = new System.Drawing.Point(171, 17);
            this.labelname.MaximumSize = new System.Drawing.Size(320, 21474800);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(35, 13);
            this.labelname.TabIndex = 32;
            this.labelname.Text = "name";
            this.labelname.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(0, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "__________________________________";
            // 
            // FriendControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.buttonreject);
            this.Controls.Add(this.buttonAdd_Accept_remove);
            this.Controls.Add(this.pictureBoxprof);
            this.Controls.Add(this.userenameLabel);
            this.Name = "FriendControl";
            this.Size = new System.Drawing.Size(217, 48);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxprof)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxprof;
        private System.Windows.Forms.Label userenameLabel;
        private System.Windows.Forms.Button buttonAdd_Accept_remove;
        private System.Windows.Forms.Button buttonreject;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
