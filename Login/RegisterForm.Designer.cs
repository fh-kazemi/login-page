namespace Login
{
    partial class RegisterForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.txt_Firstname = new System.Windows.Forms.TextBox();
            this.txt_Lastname = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_LoginForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ConfirmPass = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_ShowPassword = new System.Windows.Forms.Button();
            this.btn_HidePassword = new System.Windows.Forms.Button();
            this.btn_ShowConfirmPass = new System.Windows.Forms.Button();
            this.btn_HideConfirmPass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Firstname
            // 
            this.txt_Firstname.Location = new System.Drawing.Point(180, 29);
            this.txt_Firstname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Firstname.Name = "txt_Firstname";
            this.txt_Firstname.Size = new System.Drawing.Size(264, 26);
            this.txt_Firstname.TabIndex = 1;
            // 
            // txt_Lastname
            // 
            this.txt_Lastname.Location = new System.Drawing.Point(180, 83);
            this.txt_Lastname.Name = "txt_Lastname";
            this.txt_Lastname.Size = new System.Drawing.Size(264, 26);
            this.txt_Lastname.TabIndex = 2;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(180, 133);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(264, 26);
            this.txt_Email.TabIndex = 3;
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(180, 185);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(264, 26);
            this.txt_Username.TabIndex = 4;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(180, 235);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(264, 26);
            this.txt_Password.TabIndex = 5;
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(192, 333);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(105, 28);
            this.btn_Register.TabIndex = 7;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(322, 333);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(105, 28);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_LoginForm
            // 
            this.btn_LoginForm.Location = new System.Drawing.Point(262, 387);
            this.btn_LoginForm.Name = "btn_LoginForm";
            this.btn_LoginForm.Size = new System.Drawing.Size(105, 28);
            this.btn_LoginForm.TabIndex = 9;
            this.btn_LoginForm.Text = "Login";
            this.btn_LoginForm.UseVisualStyleBackColor = true;
            this.btn_LoginForm.Click += new System.EventHandler(this.btn_LoginForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lastname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Confirm Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Have you account?";
            // 
            // txt_ConfirmPass
            // 
            this.txt_ConfirmPass.Location = new System.Drawing.Point(180, 281);
            this.txt_ConfirmPass.Name = "txt_ConfirmPass";
            this.txt_ConfirmPass.Size = new System.Drawing.Size(264, 26);
            this.txt_ConfirmPass.TabIndex = 6;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btn_ShowPassword
            // 
            this.btn_ShowPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ShowPassword.BackgroundImage")));
            this.btn_ShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ShowPassword.Location = new System.Drawing.Point(418, 235);
            this.btn_ShowPassword.Name = "btn_ShowPassword";
            this.btn_ShowPassword.Size = new System.Drawing.Size(26, 26);
            this.btn_ShowPassword.TabIndex = 10;
            this.btn_ShowPassword.UseVisualStyleBackColor = true;
            this.btn_ShowPassword.Click += new System.EventHandler(this.btn_ShowPassword_Click);
            // 
            // btn_HidePassword
            // 
            this.btn_HidePassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_HidePassword.BackgroundImage")));
            this.btn_HidePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_HidePassword.Location = new System.Drawing.Point(418, 235);
            this.btn_HidePassword.Name = "btn_HidePassword";
            this.btn_HidePassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_HidePassword.Size = new System.Drawing.Size(26, 26);
            this.btn_HidePassword.TabIndex = 11;
            this.btn_HidePassword.UseVisualStyleBackColor = true;
            this.btn_HidePassword.Click += new System.EventHandler(this.btn_HidePassword_Click);
            // 
            // btn_ShowConfirmPass
            // 
            this.btn_ShowConfirmPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ShowConfirmPass.BackgroundImage")));
            this.btn_ShowConfirmPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ShowConfirmPass.Location = new System.Drawing.Point(418, 281);
            this.btn_ShowConfirmPass.Name = "btn_ShowConfirmPass";
            this.btn_ShowConfirmPass.Size = new System.Drawing.Size(26, 26);
            this.btn_ShowConfirmPass.TabIndex = 12;
            this.btn_ShowConfirmPass.UseVisualStyleBackColor = true;
            this.btn_ShowConfirmPass.Click += new System.EventHandler(this.btn_ShowConfirmPass_Click);
            // 
            // btn_HideConfirmPass
            // 
            this.btn_HideConfirmPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_HideConfirmPass.BackgroundImage")));
            this.btn_HideConfirmPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_HideConfirmPass.Location = new System.Drawing.Point(418, 281);
            this.btn_HideConfirmPass.Name = "btn_HideConfirmPass";
            this.btn_HideConfirmPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_HideConfirmPass.Size = new System.Drawing.Size(26, 26);
            this.btn_HideConfirmPass.TabIndex = 13;
            this.btn_HideConfirmPass.UseVisualStyleBackColor = true;
            this.btn_HideConfirmPass.Click += new System.EventHandler(this.btn_HideConfirmPass_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 442);
            this.Controls.Add(this.btn_HideConfirmPass);
            this.Controls.Add(this.btn_ShowConfirmPass);
            this.Controls.Add(this.btn_HidePassword);
            this.Controls.Add(this.btn_ShowPassword);
            this.Controls.Add(this.txt_ConfirmPass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_LoginForm);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Lastname);
            this.Controls.Add(this.txt_Firstname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Firstname;
        private System.Windows.Forms.TextBox txt_Lastname;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_LoginForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ConfirmPass;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btn_HideConfirmPass;
        private System.Windows.Forms.Button btn_ShowConfirmPass;
        private System.Windows.Forms.Button btn_HidePassword;
        private System.Windows.Forms.Button btn_ShowPassword;
    }
}