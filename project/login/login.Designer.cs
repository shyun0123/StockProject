namespace project
{
    partial class login
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_join = new System.Windows.Forms.Button();
            this.btn_pwchange = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.txt_id.Location = new System.Drawing.Point(58, 27);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(351, 30);
            this.txt_id.TabIndex = 1;
            this.txt_id.Text = "아이디";
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // txt_password
            // 
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.txt_password.Location = new System.Drawing.Point(58, 75);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(351, 30);
            this.txt_password.TabIndex = 2;
            this.txt_password.Text = "비밀번호";
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.White;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_login.FlatAppearance.BorderSize = 2;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.btn_login.Location = new System.Drawing.Point(12, 119);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(416, 46);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "로그인";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_join
            // 
            this.btn_join.BackColor = System.Drawing.Color.White;
            this.btn_join.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_join.FlatAppearance.BorderSize = 2;
            this.btn_join.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_join.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.btn_join.Location = new System.Drawing.Point(234, 171);
            this.btn_join.Name = "btn_join";
            this.btn_join.Size = new System.Drawing.Size(194, 37);
            this.btn_join.TabIndex = 4;
            this.btn_join.Text = "회원가입";
            this.btn_join.UseVisualStyleBackColor = false;
            this.btn_join.Click += new System.EventHandler(this.btn_join_Click);
            // 
            // btn_pwchange
            // 
            this.btn_pwchange.BackColor = System.Drawing.Color.White;
            this.btn_pwchange.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_pwchange.FlatAppearance.BorderSize = 2;
            this.btn_pwchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pwchange.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.btn_pwchange.Location = new System.Drawing.Point(12, 171);
            this.btn_pwchange.Name = "btn_pwchange";
            this.btn_pwchange.Size = new System.Drawing.Size(201, 37);
            this.btn_pwchange.TabIndex = 5;
            this.btn_pwchange.Text = "비밀번호변경";
            this.btn_pwchange.UseVisualStyleBackColor = false;
            this.btn_pwchange.Click += new System.EventHandler(this.btn_pwchange_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::project.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(444, 221);
            this.Controls.Add(this.btn_join);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_pwchange);
            this.Controls.Add(this.btn_login);
            this.Name = "login";
            this.Text = "로그인";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.login_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_join;
        private System.Windows.Forms.Button btn_pwchange;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

