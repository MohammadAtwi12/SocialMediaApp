namespace RegisterLoginSystem
{
    partial class FormComment
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
            this.commenttxtbox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.commentLabel = new System.Windows.Forms.Label();
            this.buttonComment = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // commenttxtbox
            // 
            this.commenttxtbox.Location = new System.Drawing.Point(12, 43);
            this.commenttxtbox.Name = "commenttxtbox";
            this.commenttxtbox.Size = new System.Drawing.Size(213, 29);
            this.commenttxtbox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.commenttxtbox.StateCommon.Border.Rounding = 9;
            this.commenttxtbox.StateCommon.Content.Color1 = System.Drawing.Color.Silver;
            this.commenttxtbox.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.commenttxtbox.StateDisabled.Border.Rounding = 9;
            this.commenttxtbox.TabIndex = 23;
            this.commenttxtbox.Tag = "";
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.commentLabel.Location = new System.Drawing.Point(12, 20);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(123, 20);
            this.commentLabel.TabIndex = 24;
            this.commentLabel.Text = "Add a Comment";
            // 
            // buttonComment
            // 
            this.buttonComment.BackColor = System.Drawing.Color.Transparent;
            this.buttonComment.BackgroundImage = global::RegisterLoginSystem.Properties.Resources.send;
            this.buttonComment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonComment.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonComment.FlatAppearance.BorderSize = 0;
            this.buttonComment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonComment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComment.Location = new System.Drawing.Point(231, 43);
            this.buttonComment.Name = "buttonComment";
            this.buttonComment.Size = new System.Drawing.Size(23, 29);
            this.buttonComment.TabIndex = 26;
            this.buttonComment.UseVisualStyleBackColor = false;
            this.buttonComment.Click += new System.EventHandler(this.buttonComment_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 87);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(245, 354);
            this.flowLayoutPanel2.TabIndex = 27;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RegisterLoginSystem.Properties.Resources.arrow;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(197, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            this.buttonBack.Location = new System.Drawing.Point(188, 10);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(69, 27);
            this.buttonBack.TabIndex = 29;
            this.buttonBack.Text = "BACK";
            this.buttonBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(266, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.buttonComment);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.commenttxtbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormComment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormComment";
            this.Load += new System.EventHandler(this.FormComment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox commenttxtbox;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.Button buttonComment;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonBack;
    }
}