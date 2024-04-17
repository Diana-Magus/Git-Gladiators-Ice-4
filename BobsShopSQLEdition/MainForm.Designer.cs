namespace BobsShop
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginPanel = new Panel();
            label3 = new Label();
            label4 = new Label();
            btnSignup = new Button();
            btnSubmit = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            labLogin = new Label();
            WelcomePanel = new Panel();
            btnWelcome = new Button();
            labTitle = new Label();
            RegisterPanel = new Panel();
            label2 = new Label();
            label1 = new Label();
            btnLogin = new Button();
            btnSubmitNew = new Button();
            txtPasswordNew = new TextBox();
            txtUsernameNew = new TextBox();
            labRegister = new Label();
            LoginPanel.SuspendLayout();
            WelcomePanel.SuspendLayout();
            RegisterPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LoginPanel
            // 
            LoginPanel.BackColor = SystemColors.ActiveCaption;
            LoginPanel.BackgroundImageLayout = ImageLayout.Stretch;
            LoginPanel.Controls.Add(label3);
            LoginPanel.Controls.Add(label4);
            LoginPanel.Controls.Add(btnSignup);
            LoginPanel.Controls.Add(btnSubmit);
            LoginPanel.Controls.Add(txtPassword);
            LoginPanel.Controls.Add(txtUsername);
            LoginPanel.Controls.Add(labLogin);
            LoginPanel.Font = new Font("Constantia", 20.25F);
            LoginPanel.Location = new Point(0, 0);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(1224, 772);
            LoginPanel.TabIndex = 0;
            LoginPanel.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(200, 255, 255, 255);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(467, 330);
            label3.Name = "label3";
            label3.Size = new Size(125, 33);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(200, 255, 255, 255);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(467, 213);
            label4.Name = "label4";
            label4.Size = new Size(133, 33);
            label4.TabIndex = 7;
            label4.Text = "Username";
            // 
            // btnSignup
            // 
            btnSignup.Location = new Point(467, 491);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(129, 45);
            btnSignup.TabIndex = 4;
            btnSignup.Text = "Sign-Up";
            btnSignup.UseVisualStyleBackColor = true;
            btnSignup.MouseClick += btnSignup_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(629, 491);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(129, 45);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.MouseClick += btnSubmit_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Constantia", 20.25F);
            txtPassword.Location = new Point(467, 366);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(291, 40);
            txtPassword.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Constantia", 20.25F);
            txtUsername.Location = new Point(467, 249);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(291, 40);
            txtUsername.TabIndex = 1;
            // 
            // labLogin
            // 
            labLogin.AutoSize = true;
            labLogin.BackColor = Color.FromArgb(200, 255, 255, 255);
            labLogin.Font = new Font("Constantia", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labLogin.ForeColor = SystemColors.ActiveCaptionText;
            labLogin.Location = new Point(509, 95);
            labLogin.Name = "labLogin";
            labLogin.Size = new Size(206, 78);
            labLogin.TabIndex = 0;
            labLogin.Text = "Login";
            labLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WelcomePanel
            // 
            WelcomePanel.BackColor = SystemColors.ActiveCaption;
            WelcomePanel.BackgroundImageLayout = ImageLayout.Stretch;
            WelcomePanel.Controls.Add(btnWelcome);
            WelcomePanel.Controls.Add(labTitle);
            WelcomePanel.Font = new Font("Constantia", 20.25F);
            WelcomePanel.Location = new Point(0, 0);
            WelcomePanel.Name = "WelcomePanel";
            WelcomePanel.Size = new Size(1224, 772);
            WelcomePanel.TabIndex = 1;
            // 
            // btnWelcome
            // 
            btnWelcome.Font = new Font("Constantia", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnWelcome.Location = new Point(481, 355);
            btnWelcome.Name = "btnWelcome";
            btnWelcome.Size = new Size(262, 63);
            btnWelcome.TabIndex = 4;
            btnWelcome.Text = "Welcome";
            btnWelcome.UseVisualStyleBackColor = true;
            btnWelcome.MouseClick += btnWelcome_Click;
            // 
            // labTitle
            // 
            labTitle.AutoSize = true;
            labTitle.BackColor = Color.FromArgb(200, 255, 255, 255);
            labTitle.Font = new Font("Constantia", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labTitle.Location = new Point(431, 159);
            labTitle.Name = "labTitle";
            labTitle.Size = new Size(360, 78);
            labTitle.TabIndex = 0;
            labTitle.Text = "Bob's Shop";
            labTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegisterPanel
            // 
            RegisterPanel.BackColor = SystemColors.ActiveCaption;
            RegisterPanel.BackgroundImageLayout = ImageLayout.Stretch;
            RegisterPanel.Controls.Add(label2);
            RegisterPanel.Controls.Add(label1);
            RegisterPanel.Controls.Add(btnLogin);
            RegisterPanel.Controls.Add(btnSubmitNew);
            RegisterPanel.Controls.Add(txtPasswordNew);
            RegisterPanel.Controls.Add(txtUsernameNew);
            RegisterPanel.Controls.Add(labRegister);
            RegisterPanel.Font = new Font("Constantia", 20.25F);
            RegisterPanel.Location = new Point(0, 0);
            RegisterPanel.Name = "RegisterPanel";
            RegisterPanel.Size = new Size(1224, 772);
            RegisterPanel.TabIndex = 2;
            RegisterPanel.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(200, 255, 255, 255);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(467, 330);
            label2.Name = "label2";
            label2.Size = new Size(125, 33);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(200, 255, 255, 255);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(467, 213);
            label1.Name = "label1";
            label1.Size = new Size(133, 33);
            label1.TabIndex = 5;
            label1.Text = "Username";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(467, 491);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(129, 45);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.MouseClick += btnLogin_Click;
            // 
            // btnSubmitNew
            // 
            btnSubmitNew.Location = new Point(629, 491);
            btnSubmitNew.Name = "btnSubmitNew";
            btnSubmitNew.Size = new Size(129, 45);
            btnSubmitNew.TabIndex = 3;
            btnSubmitNew.Text = "Submit";
            btnSubmitNew.UseVisualStyleBackColor = true;
            btnSubmitNew.MouseClick += btnSubmitNew_Click;
            // 
            // txtPasswordNew
            // 
            txtPasswordNew.Font = new Font("Constantia", 20.25F);
            txtPasswordNew.Location = new Point(467, 366);
            txtPasswordNew.Name = "txtPasswordNew";
            txtPasswordNew.Size = new Size(291, 40);
            txtPasswordNew.TabIndex = 2;
            // 
            // txtUsernameNew
            // 
            txtUsernameNew.Font = new Font("Constantia", 20.25F);
            txtUsernameNew.Location = new Point(467, 249);
            txtUsernameNew.Name = "txtUsernameNew";
            txtUsernameNew.Size = new Size(291, 40);
            txtUsernameNew.TabIndex = 1;
            // 
            // labRegister
            // 
            labRegister.AutoSize = true;
            labRegister.BackColor = Color.FromArgb(200, 255, 255, 255);
            labRegister.Font = new Font("Constantia", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labRegister.ForeColor = SystemColors.ActiveCaptionText;
            labRegister.Location = new Point(471, 95);
            labRegister.Name = "labRegister";
            labRegister.Size = new Size(282, 78);
            labRegister.TabIndex = 0;
            labRegister.Text = "Register";
            labRegister.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 772);
            Controls.Add(RegisterPanel);
            Controls.Add(LoginPanel);
            Controls.Add(WelcomePanel);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Minimized;
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            WelcomePanel.ResumeLayout(false);
            WelcomePanel.PerformLayout();
            RegisterPanel.ResumeLayout(false);
            RegisterPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel LoginPanel;
        private TextBox txtUsername;
        private Label labLogin;
        private TextBox txtPassword;
        private Button btnSubmit;
        private Panel WelcomePanel;
        private Button btnWelcome;
        private Label labTitle;
        private Panel RegisterPanel;
        private Button btnLogin;
        private Button btnSubmitNew;
        private TextBox txtPasswordNew;
        private TextBox txtUsernameNew;
        private Label labRegister;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnSignup;
    }
}
