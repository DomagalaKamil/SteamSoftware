namespace SteamApp
{
    partial class accountCreation
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
            this.emailPanel = new System.Windows.Forms.Panel();
            this.continueBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.verificationCodeTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmEmailTextBox = new System.Windows.Forms.TextBox();
            this.verifyBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.dobDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.emailPanel.SuspendLayout();
            this.detailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailPanel
            // 
            this.emailPanel.Controls.Add(this.continueBtn);
            this.emailPanel.Controls.Add(this.label3);
            this.emailPanel.Controls.Add(this.verificationCodeTxt);
            this.emailPanel.Controls.Add(this.label2);
            this.emailPanel.Controls.Add(this.confirmEmailTextBox);
            this.emailPanel.Controls.Add(this.verifyBtn);
            this.emailPanel.Controls.Add(this.label1);
            this.emailPanel.Controls.Add(this.emailTextBox);
            this.emailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailPanel.Location = new System.Drawing.Point(0, 0);
            this.emailPanel.Name = "emailPanel";
            this.emailPanel.Size = new System.Drawing.Size(599, 683);
            this.emailPanel.TabIndex = 0;
            // 
            // continueBtn
            // 
            this.continueBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(157)))), ((int)(((byte)(194)))));
            this.continueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.continueBtn.Location = new System.Drawing.Point(211, 508);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(153, 41);
            this.continueBtn.TabIndex = 11;
            this.continueBtn.Text = "Continue";
            this.continueBtn.UseVisualStyleBackColor = false;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(157)))), ((int)(((byte)(194)))));
            this.label3.Location = new System.Drawing.Point(106, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Insert verification code sent to your Email Address";
            // 
            // verificationCodeTxt
            // 
            this.verificationCodeTxt.BackColor = System.Drawing.Color.White;
            this.verificationCodeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.verificationCodeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verificationCodeTxt.Location = new System.Drawing.Point(109, 453);
            this.verificationCodeTxt.Name = "verificationCodeTxt";
            this.verificationCodeTxt.Size = new System.Drawing.Size(376, 31);
            this.verificationCodeTxt.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(157)))), ((int)(((byte)(194)))));
            this.label2.Location = new System.Drawing.Point(104, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Confirm your Address";
            // 
            // confirmEmailTextBox
            // 
            this.confirmEmailTextBox.BackColor = System.Drawing.Color.White;
            this.confirmEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmEmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmEmailTextBox.Location = new System.Drawing.Point(107, 212);
            this.confirmEmailTextBox.Name = "confirmEmailTextBox";
            this.confirmEmailTextBox.Size = new System.Drawing.Size(376, 31);
            this.confirmEmailTextBox.TabIndex = 7;
            // 
            // verifyBtn
            // 
            this.verifyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(157)))), ((int)(((byte)(194)))));
            this.verifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.verifyBtn.Location = new System.Drawing.Point(209, 272);
            this.verifyBtn.Name = "verifyBtn";
            this.verifyBtn.Size = new System.Drawing.Size(153, 41);
            this.verifyBtn.TabIndex = 6;
            this.verifyBtn.Text = "Verify";
            this.verifyBtn.UseVisualStyleBackColor = false;
            this.verifyBtn.Click += new System.EventHandler(this.verifyBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(157)))), ((int)(((byte)(194)))));
            this.label1.Location = new System.Drawing.Point(104, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Email Address";
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.White;
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(107, 132);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(376, 31);
            this.emailTextBox.TabIndex = 3;
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(157)))), ((int)(((byte)(194)))));
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerBtn.Location = new System.Drawing.Point(229, 525);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(153, 41);
            this.registerBtn.TabIndex = 1;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // detailsPanel
            // 
            this.detailsPanel.Controls.Add(this.dobDatePicker);
            this.detailsPanel.Controls.Add(this.label8);
            this.detailsPanel.Controls.Add(this.registerBtn);
            this.detailsPanel.Controls.Add(this.phoneTextBox);
            this.detailsPanel.Controls.Add(this.label7);
            this.detailsPanel.Controls.Add(this.label6);
            this.detailsPanel.Controls.Add(this.label5);
            this.detailsPanel.Controls.Add(this.label4);
            this.detailsPanel.Controls.Add(this.confirmPasswordTextBox);
            this.detailsPanel.Controls.Add(this.passwordTextBox);
            this.detailsPanel.Controls.Add(this.usernameTextBox);
            this.detailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsPanel.Location = new System.Drawing.Point(0, 0);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(599, 683);
            this.detailsPanel.TabIndex = 2;
            // 
            // dobDatePicker
            // 
            this.dobDatePicker.Location = new System.Drawing.Point(123, 312);
            this.dobDatePicker.Name = "dobDatePicker";
            this.dobDatePicker.Size = new System.Drawing.Size(376, 20);
            this.dobDatePicker.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(157)))), ((int)(((byte)(194)))));
            this.label8.Location = new System.Drawing.Point(120, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Phone Number (Optional)";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BackColor = System.Drawing.Color.White;
            this.phoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(123, 382);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(376, 31);
            this.phoneTextBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(157)))), ((int)(((byte)(194)))));
            this.label7.Location = new System.Drawing.Point(120, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Date of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(157)))), ((int)(((byte)(194)))));
            this.label6.Location = new System.Drawing.Point(120, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Confirm Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(157)))), ((int)(((byte)(194)))));
            this.label5.Location = new System.Drawing.Point(120, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(157)))), ((int)(((byte)(194)))));
            this.label4.Location = new System.Drawing.Point(120, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Name";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.BackColor = System.Drawing.Color.White;
            this.confirmPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(123, 230);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(376, 31);
            this.confirmPasswordTextBox.TabIndex = 6;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.White;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(123, 151);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(376, 31);
            this.passwordTextBox.TabIndex = 5;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.White;
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(123, 77);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(376, 31);
            this.usernameTextBox.TabIndex = 4;
            // 
            // accountCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(599, 683);
            this.Controls.Add(this.emailPanel);
            this.Controls.Add(this.detailsPanel);
            this.Name = "accountCreation";
            this.Text = "accountCreation";
            this.emailPanel.ResumeLayout(false);
            this.emailPanel.PerformLayout();
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel emailPanel;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox confirmEmailTextBox;
        private System.Windows.Forms.Button verifyBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.Button continueBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox verificationCodeTxt;
        private System.Windows.Forms.DateTimePicker dobDatePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
    }
}