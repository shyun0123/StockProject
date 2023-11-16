namespace project
{
    partial class pwchange
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
            this.pn_pwchange = new System.Windows.Forms.Panel();
            this.txt_changeid = new System.Windows.Forms.TextBox();
            this.txt_changename = new System.Windows.Forms.TextBox();
            this.btn_idcheck = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_pwcheck = new System.Windows.Forms.TextBox();
            this.txt_newpw = new System.Windows.Forms.TextBox();
            this.btn_pwchange = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pn_pwchange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_pwchange
            // 
            this.pn_pwchange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pn_pwchange.Controls.Add(this.txt_changeid);
            this.pn_pwchange.Controls.Add(this.txt_changename);
            this.pn_pwchange.Controls.Add(this.btn_idcheck);
            this.pn_pwchange.Controls.Add(this.pictureBox1);
            this.pn_pwchange.Location = new System.Drawing.Point(0, 0);
            this.pn_pwchange.Name = "pn_pwchange";
            this.pn_pwchange.Size = new System.Drawing.Size(444, 221);
            this.pn_pwchange.TabIndex = 0;
            // 
            // txt_changeid
            // 
            this.txt_changeid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_changeid.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.txt_changeid.Location = new System.Drawing.Point(63, 89);
            this.txt_changeid.Multiline = true;
            this.txt_changeid.Name = "txt_changeid";
            this.txt_changeid.Size = new System.Drawing.Size(351, 30);
            this.txt_changeid.TabIndex = 11;
            this.txt_changeid.Text = "아이디";
            this.txt_changeid.TextChanged += new System.EventHandler(this.txt_changeid_TextChanged);
            // 
            // txt_changename
            // 
            this.txt_changename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_changename.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.txt_changename.Location = new System.Drawing.Point(63, 41);
            this.txt_changename.Multiline = true;
            this.txt_changename.Name = "txt_changename";
            this.txt_changename.Size = new System.Drawing.Size(351, 30);
            this.txt_changename.TabIndex = 10;
            this.txt_changename.Text = "이름";
            this.txt_changename.TextChanged += new System.EventHandler(this.txt_changename_TextChanged);
            // 
            // btn_idcheck
            // 
            this.btn_idcheck.BackColor = System.Drawing.Color.White;
            this.btn_idcheck.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_idcheck.FlatAppearance.BorderSize = 2;
            this.btn_idcheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_idcheck.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.btn_idcheck.Location = new System.Drawing.Point(12, 144);
            this.btn_idcheck.Name = "btn_idcheck";
            this.btn_idcheck.Size = new System.Drawing.Size(416, 46);
            this.btn_idcheck.TabIndex = 3;
            this.btn_idcheck.Text = "확인";
            this.btn_idcheck.UseVisualStyleBackColor = false;
            this.btn_idcheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::project.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txt_pwcheck
            // 
            this.txt_pwcheck.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pwcheck.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.txt_pwcheck.Location = new System.Drawing.Point(63, 89);
            this.txt_pwcheck.Multiline = true;
            this.txt_pwcheck.Name = "txt_pwcheck";
            this.txt_pwcheck.Size = new System.Drawing.Size(351, 30);
            this.txt_pwcheck.TabIndex = 5;
            this.txt_pwcheck.Text = "비밀번호 확인";
            this.txt_pwcheck.TextChanged += new System.EventHandler(this.txt_pwcheck_TextChanged);
            // 
            // txt_newpw
            // 
            this.txt_newpw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_newpw.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.txt_newpw.Location = new System.Drawing.Point(63, 41);
            this.txt_newpw.Multiline = true;
            this.txt_newpw.Name = "txt_newpw";
            this.txt_newpw.Size = new System.Drawing.Size(351, 30);
            this.txt_newpw.TabIndex = 4;
            this.txt_newpw.Text = "변경할 비밀번호";
            this.txt_newpw.TextChanged += new System.EventHandler(this.txt_newpw_TextChanged);
            // 
            // btn_pwchange
            // 
            this.btn_pwchange.BackColor = System.Drawing.Color.White;
            this.btn_pwchange.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_pwchange.FlatAppearance.BorderSize = 2;
            this.btn_pwchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pwchange.Location = new System.Drawing.Point(12, 144);
            this.btn_pwchange.Name = "btn_pwchange";
            this.btn_pwchange.Size = new System.Drawing.Size(416, 46);
            this.btn_pwchange.TabIndex = 6;
            this.btn_pwchange.Text = "비밀번호 변경";
            this.btn_pwchange.UseVisualStyleBackColor = false;
            this.btn_pwchange.Click += new System.EventHandler(this.btn_pwchange_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::project.Properties.Resources.login;
            this.pictureBox2.Location = new System.Drawing.Point(12, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(416, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pwchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(445, 221);
            this.Controls.Add(this.pn_pwchange);
            this.Controls.Add(this.btn_pwchange);
            this.Controls.Add(this.txt_pwcheck);
            this.Controls.Add(this.txt_newpw);
            this.Controls.Add(this.pictureBox2);
            this.Name = "pwchange";
            this.Text = "비밀번호 변경";
            this.pn_pwchange.ResumeLayout(false);
            this.pn_pwchange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_pwchange;
        private System.Windows.Forms.Button btn_idcheck;
        private System.Windows.Forms.TextBox txt_pwcheck;
        private System.Windows.Forms.TextBox txt_newpw;
        private System.Windows.Forms.Button btn_pwchange;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_changeid;
        private System.Windows.Forms.TextBox txt_changename;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}