namespace BobsShop
{
    partial class WelcomeForm
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
            FinalPanel = new Panel();
            labUsername = new Label();
            label1 = new Label();
            labWelcome = new Label();
            FinalPanel.SuspendLayout();
            SuspendLayout();
            // 
            // FinalPanel
            // 
            FinalPanel.BackColor = SystemColors.ActiveCaption;
            FinalPanel.BackgroundImage = Properties.Resources.download;
            FinalPanel.BackgroundImageLayout = ImageLayout.Stretch;
            FinalPanel.Controls.Add(labUsername);
            FinalPanel.Controls.Add(label1);
            FinalPanel.Controls.Add(labWelcome);
            FinalPanel.Font = new Font("Constantia", 20.25F);
            FinalPanel.Location = new Point(-3, -3);
            FinalPanel.Name = "FinalPanel";
            FinalPanel.Size = new Size(1224, 772);
            FinalPanel.TabIndex = 4;
            // 
            // labUsername
            // 
            labUsername.AutoSize = true;
            labUsername.BackColor = Color.FromArgb(200, 255, 255, 255);
            labUsername.Location = new Point(668, 367);
            labUsername.Name = "labUsername";
            labUsername.Size = new Size(133, 33);
            labUsername.TabIndex = 6;
            labUsername.Text = "Username";
            labUsername.Click += labUsername_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(200, 255, 255, 255);
            label1.Location = new Point(432, 367);
            label1.Name = "label1";
            label1.Size = new Size(131, 33);
            label1.TabIndex = 5;
            label1.Text = "Welcome:";
            // 
            // labWelcome
            // 
            labWelcome.AutoSize = true;
            labWelcome.BackColor = Color.FromArgb(200, 255, 255, 255);
            labWelcome.Font = new Font("Constantia", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labWelcome.Location = new Point(432, 259);
            labWelcome.Name = "labWelcome";
            labWelcome.Size = new Size(360, 78);
            labWelcome.TabIndex = 0;
            labWelcome.Text = "Bob's Shop";
            labWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 766);
            Controls.Add(FinalPanel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WelcomeForm";
            FinalPanel.ResumeLayout(false);
            FinalPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel RegisterPanel;
        private Label label1;
        private Label labWelcome;
        private Label labUsername;
        private Panel WelcomePanel;
        private Panel FinalPanel;
    }
}