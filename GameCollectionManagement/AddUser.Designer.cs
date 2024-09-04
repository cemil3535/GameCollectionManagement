namespace GameCollectionManagement
{
    partial class AddUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUserName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtRole = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BtnAddUser = new Button();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(153, 62);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(333, 31);
            txtUserName.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(153, 120);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(333, 31);
            txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(153, 191);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(333, 31);
            txtPassword.TabIndex = 2;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(153, 237);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(333, 31);
            txtRole.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 65);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 4;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 126);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 194);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 243);
            label4.Name = "label4";
            label4.Size = new Size(46, 25);
            label4.TabIndex = 7;
            label4.Text = "Role";
            // 
            // BtnAddUser
            // 
            BtnAddUser.Location = new Point(374, 303);
            BtnAddUser.Name = "BtnAddUser";
            BtnAddUser.Size = new Size(112, 34);
            BtnAddUser.TabIndex = 8;
            BtnAddUser.Text = "Ekle";
            BtnAddUser.UseVisualStyleBackColor = true;
            BtnAddUser.Click += BtnAddUser_Click;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BtnAddUser);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtRole);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtUserName);
            Name = "AddUser";
            Size = new Size(661, 440);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtRole;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BtnAddUser;
    }
}
