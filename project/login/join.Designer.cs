namespace project
{
    partial class join
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
            this.txt_joinpassword = new System.Windows.Forms.TextBox();
            this.txt_joinid = new System.Windows.Forms.TextBox();
            this.txt_joinname = new System.Windows.Forms.TextBox();
            this.btn_join = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_joinpassword
            // 
            this.txt_joinpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_joinpassword.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.txt_joinpassword.Location = new System.Drawing.Point(56, 127);
            this.txt_joinpassword.Multiline = true;
            this.txt_joinpassword.Name = "txt_joinpassword";
            this.txt_joinpassword.Size = new System.Drawing.Size(351, 30);
            this.txt_joinpassword.TabIndex = 3;
            this.txt_joinpassword.Text = "비밀번호";
            this.txt_joinpassword.TextChanged += new System.EventHandler(this.txt_joinpassword_TextChanged);
            // 
            // txt_joinid
            // 
            this.txt_joinid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_joinid.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.txt_joinid.Location = new System.Drawing.Point(56, 80);
            this.txt_joinid.Multiline = true;
            this.txt_joinid.Name = "txt_joinid";
            this.txt_joinid.Size = new System.Drawing.Size(351, 30);
            this.txt_joinid.TabIndex = 2;
            this.txt_joinid.Text = "아이디";
            this.txt_joinid.TextChanged += new System.EventHandler(this.txt_joinid_TextChanged);
            // 
            // txt_joinname
            // 
            this.txt_joinname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_joinname.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.txt_joinname.Location = new System.Drawing.Point(56, 31);
            this.txt_joinname.Multiline = true;
            this.txt_joinname.Name = "txt_joinname";
            this.txt_joinname.Size = new System.Drawing.Size(351, 30);
            this.txt_joinname.TabIndex = 1;
            this.txt_joinname.Text = "이름";
            this.txt_joinname.TextChanged += new System.EventHandler(this.txt_joinname_TextChanged);
            // 
            // btn_join
            // 
            this.btn_join.BackColor = System.Drawing.SystemColors.Control;
            this.btn_join.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_join.FlatAppearance.BorderSize = 2;
            this.btn_join.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_join.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.btn_join.Location = new System.Drawing.Point(12, 170);
            this.btn_join.Name = "btn_join";
            this.btn_join.Size = new System.Drawing.Size(416, 46);
            this.btn_join.TabIndex = 4;
            this.btn_join.Text = "회원가입";
            this.btn_join.UseVisualStyleBackColor = false;
            this.btn_join.Click += new System.EventHandler(this.btnjoin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::project.Properties.Resources.join;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // join
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(444, 221);
            this.Controls.Add(this.btn_join);
            this.Controls.Add(this.txt_joinpassword);
            this.Controls.Add(this.txt_joinname);
            this.Controls.Add(this.txt_joinid);
            this.Controls.Add(this.pictureBox1);
            this.Name = "join";
            this.Text = "회원가입";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_joinpassword;
        private System.Windows.Forms.TextBox txt_joinid;
        private System.Windows.Forms.TextBox txt_joinname;
        private System.Windows.Forms.Button btn_join;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}