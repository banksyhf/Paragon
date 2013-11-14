namespace Paragon
{
    partial class FormLogin
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblServer = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblServerOnline = new System.Windows.Forms.ToolStripStatusLabel();
            this.hiddenTab1 = new Paragon.Controls.HiddenTab();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnToRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tabRegister = new System.Windows.Forms.TabPage();
            this.lblfocus = new System.Windows.Forms.Label();
            this.txtRegisterPassword = new Paragon.Controls.CueTextBox();
            this.txtRegisterUsername = new Paragon.Controls.CueTextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtRegisterEmail = new Paragon.Controls.CueTextBox();
            this.statusStrip1.SuspendLayout();
            this.hiddenTab1.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblServer,
            this.lblServerOnline});
            this.statusStrip1.Location = new System.Drawing.Point(0, 184);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(376, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblServer
            // 
            this.lblServer.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(51, 17);
            this.lblServer.Text = "Server:";
            // 
            // lblServerOnline
            // 
            this.lblServerOnline.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerOnline.Name = "lblServerOnline";
            this.lblServerOnline.Size = new System.Drawing.Size(72, 17);
            this.lblServerOnline.Text = "Checking...";
            this.lblServerOnline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hiddenTab1
            // 
            this.hiddenTab1.Controls.Add(this.tabLogin);
            this.hiddenTab1.Controls.Add(this.tabRegister);
            this.hiddenTab1.DesignerIndex = 1;
            this.hiddenTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hiddenTab1.Location = new System.Drawing.Point(0, 0);
            this.hiddenTab1.Name = "hiddenTab1";
            this.hiddenTab1.SelectedIndex = 0;
            this.hiddenTab1.Size = new System.Drawing.Size(376, 184);
            this.hiddenTab1.TabIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.txtPassword);
            this.tabLogin.Controls.Add(this.txtUsername);
            this.tabLogin.Controls.Add(this.btnToRegister);
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Location = new System.Drawing.Point(0, 0);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(376, 184);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(96, 84);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(184, 21);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(96, 57);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(184, 21);
            this.txtUsername.TabIndex = 0;
            // 
            // btnToRegister
            // 
            this.btnToRegister.Enabled = false;
            this.btnToRegister.Location = new System.Drawing.Point(96, 111);
            this.btnToRegister.Name = "btnToRegister";
            this.btnToRegister.Size = new System.Drawing.Size(89, 25);
            this.btnToRegister.TabIndex = 3;
            this.btnToRegister.Text = "Register";
            this.btnToRegister.UseVisualStyleBackColor = true;
            this.btnToRegister.Click += new System.EventHandler(this.btnToRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Enabled = false;
            this.btnLogin.Location = new System.Drawing.Point(191, 111);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(89, 25);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tabRegister
            // 
            this.tabRegister.Controls.Add(this.txtRegisterEmail);
            this.tabRegister.Controls.Add(this.lblfocus);
            this.tabRegister.Controls.Add(this.txtRegisterPassword);
            this.tabRegister.Controls.Add(this.txtRegisterUsername);
            this.tabRegister.Controls.Add(this.btnBack);
            this.tabRegister.Controls.Add(this.btnRegister);
            this.tabRegister.Location = new System.Drawing.Point(0, 0);
            this.tabRegister.Name = "tabRegister";
            this.tabRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegister.Size = new System.Drawing.Size(376, 184);
            this.tabRegister.TabIndex = 1;
            this.tabRegister.UseVisualStyleBackColor = true;
            // 
            // lblfocus
            // 
            this.lblfocus.AutoSize = true;
            this.lblfocus.Location = new System.Drawing.Point(93, 23);
            this.lblfocus.Name = "lblfocus";
            this.lblfocus.Size = new System.Drawing.Size(68, 13);
            this.lblfocus.TabIndex = 0;
            this.lblfocus.Text = "focus label";
            this.lblfocus.Visible = false;
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.CueText = "Password";
            this.txtRegisterPassword.Location = new System.Drawing.Point(96, 94);
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.Size = new System.Drawing.Size(184, 21);
            this.txtRegisterPassword.TabIndex = 3;
            // 
            // txtRegisterUsername
            // 
            this.txtRegisterUsername.CueText = "Username";
            this.txtRegisterUsername.Location = new System.Drawing.Point(96, 39);
            this.txtRegisterUsername.Name = "txtRegisterUsername";
            this.txtRegisterUsername.Size = new System.Drawing.Size(184, 21);
            this.txtRegisterUsername.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Enabled = false;
            this.btnBack.Location = new System.Drawing.Point(96, 121);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 25);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Enabled = false;
            this.btnRegister.Location = new System.Drawing.Point(191, 121);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(89, 25);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtRegisterEmail
            // 
            this.txtRegisterEmail.CueText = "Email";
            this.txtRegisterEmail.Location = new System.Drawing.Point(96, 67);
            this.txtRegisterEmail.Name = "txtRegisterEmail";
            this.txtRegisterEmail.Size = new System.Drawing.Size(184, 21);
            this.txtRegisterEmail.TabIndex = 2;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 206);
            this.Controls.Add(this.hiddenTab1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.hiddenTab1.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabRegister.ResumeLayout(false);
            this.tabRegister.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblServer;
        private System.Windows.Forms.ToolStripStatusLabel lblServerOnline;
        private Controls.HiddenTab hiddenTab1;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabRegister;
        private System.Windows.Forms.Button btnToRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRegister;
        private Controls.CueTextBox txtRegisterPassword;
        private Controls.CueTextBox txtRegisterUsername;
        private System.Windows.Forms.Label lblfocus;
        private Controls.CueTextBox txtRegisterEmail;
    }
}

