namespace QuanLyQuanCafe
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoginName = new System.Windows.Forms.Panel();
            this.textbox = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Textbox3 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.LoginName.SuspendLayout();
            this.Password.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LoginButton);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.LoginName);
            this.panel1.Location = new System.Drawing.Point(8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 178);
            this.panel1.TabIndex = 0;
            // 
            // LoginName
            // 
            this.LoginName.Controls.Add(this.textBox1);
            this.LoginName.Controls.Add(this.textbox);
            this.LoginName.Location = new System.Drawing.Point(3, 4);
            this.LoginName.Name = "LoginName";
            this.LoginName.Size = new System.Drawing.Size(430, 48);
            this.LoginName.TabIndex = 0;
            // 
            // textbox
            // 
            this.textbox.AutoSize = true;
            this.textbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox.ForeColor = System.Drawing.Color.Black;
            this.textbox.Location = new System.Drawing.Point(3, 10);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(159, 24);
            this.textbox.TabIndex = 0;
            this.textbox.Text = "Tên đăng nhập:";
            this.textbox.Click += new System.EventHandler(this.Label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Password
            // 
            this.Password.Controls.Add(this.textBox2);
            this.Password.Controls.Add(this.Textbox3);
            this.Password.Location = new System.Drawing.Point(3, 58);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(430, 48);
            this.Password.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(182, 10);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(245, 22);
            this.textBox2.TabIndex = 1;
            // 
            // Textbox3
            // 
            this.Textbox3.AutoSize = true;
            this.Textbox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox3.ForeColor = System.Drawing.Color.Black;
            this.Textbox3.Location = new System.Drawing.Point(3, 10);
            this.Textbox3.Name = "Textbox3";
            this.Textbox3.Size = new System.Drawing.Size(104, 24);
            this.Textbox3.TabIndex = 0;
            this.Textbox3.Text = "Mật khẩu:";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(145, 130);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(115, 29);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Đăng nhập";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 189);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Đăng nhập";
            this.panel1.ResumeLayout(false);
            this.LoginName.ResumeLayout(false);
            this.LoginName.PerformLayout();
            this.Password.ResumeLayout(false);
            this.Password.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel LoginName;
        private System.Windows.Forms.Label textbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel Password;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Textbox3;
        private System.Windows.Forms.Button LoginButton;
    }
}

