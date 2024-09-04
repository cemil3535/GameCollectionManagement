namespace GameCollectionManagement
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
            menuStrip1 = new MenuStrip();
            fileTsmi = new ToolStripMenuItem();
            exitTsmi = new ToolStripMenuItem();
            userTsmi = new ToolStripMenuItem();
            registerTsmi = new ToolStripMenuItem();
            userListTsmi = new ToolStripMenuItem();
            kullaniciToolStripMenuItem = new ToolStripMenuItem();
            gameTsmi = new ToolStripMenuItem();
            newGameTsmi = new ToolStripMenuItem();
            gameListTsmi = new ToolStripMenuItem();
            reviewTsmi = new ToolStripMenuItem();
            addReviewTsmi = new ToolStripMenuItem();
            reviewListTsmi = new ToolStripMenuItem();
            aboutTsmi = new ToolStripMenuItem();
            panelContent = new Panel();
            statusStrip1 = new StatusStrip();
            tssUserName = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            panelContent.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileTsmi, userTsmi, gameTsmi, reviewTsmi, aboutTsmi });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1255, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileTsmi
            // 
            fileTsmi.DropDownItems.AddRange(new ToolStripItem[] { exitTsmi });
            fileTsmi.Name = "fileTsmi";
            fileTsmi.Size = new Size(78, 29);
            fileTsmi.Text = "Dosya";
            // 
            // exitTsmi
            // 
            exitTsmi.Name = "exitTsmi";
            exitTsmi.Size = new Size(150, 34);
            exitTsmi.Text = "Çıkış";
            // 
            // userTsmi
            // 
            userTsmi.DropDownItems.AddRange(new ToolStripItem[] { registerTsmi, userListTsmi, kullaniciToolStripMenuItem });
            userTsmi.Name = "userTsmi";
            userTsmi.Size = new Size(91, 29);
            userTsmi.Text = "Kullanıcı";
            // 
            // registerTsmi
            // 
            registerTsmi.Name = "registerTsmi";
            registerTsmi.Size = new Size(236, 34);
            registerTsmi.Text = "Kayıt Ol";
            registerTsmi.Click += registerTsmi_Click;
            // 
            // userListTsmi
            // 
            userListTsmi.Name = "userListTsmi";
            userListTsmi.Size = new Size(236, 34);
            userListTsmi.Text = "Tüm Kullanıcılar";
            userListTsmi.Click += userListTsmi_Click;
            // 
            // kullaniciToolStripMenuItem
            // 
            kullaniciToolStripMenuItem.Name = "kullaniciToolStripMenuItem";
            kullaniciToolStripMenuItem.Size = new Size(236, 34);
            kullaniciToolStripMenuItem.Text = "Kullanıcı";
            // 
            // gameTsmi
            // 
            gameTsmi.DropDownItems.AddRange(new ToolStripItem[] { newGameTsmi, gameListTsmi });
            gameTsmi.Name = "gameTsmi";
            gameTsmi.Size = new Size(76, 29);
            gameTsmi.Text = "Oyun ";
            // 
            // newGameTsmi
            // 
            newGameTsmi.Name = "newGameTsmi";
            newGameTsmi.Size = new Size(216, 34);
            newGameTsmi.Text = "Oyun Ekle";
            newGameTsmi.Click += newGameTsmi_Click;
            // 
            // gameListTsmi
            // 
            gameListTsmi.Name = "gameListTsmi";
            gameListTsmi.Size = new Size(216, 34);
            gameListTsmi.Text = "Tum Oyunlar";
            gameListTsmi.Click += gameListTsmi_Click;
            // 
            // reviewTsmi
            // 
            reviewTsmi.DropDownItems.AddRange(new ToolStripItem[] { addReviewTsmi, reviewListTsmi });
            reviewTsmi.Name = "reviewTsmi";
            reviewTsmi.Size = new Size(79, 29);
            reviewTsmi.Text = "Yorum";
            // 
            // addReviewTsmi
            // 
            addReviewTsmi.Name = "addReviewTsmi";
            addReviewTsmi.Size = new Size(224, 34);
            addReviewTsmi.Text = "Yorum Ekle";
            addReviewTsmi.Click += addReviewTsmi_Click;
            // 
            // reviewListTsmi
            // 
            reviewListTsmi.Name = "reviewListTsmi";
            reviewListTsmi.Size = new Size(224, 34);
            reviewListTsmi.Text = "Tum Yorumlar";
            reviewListTsmi.Click += reviewListTsmi_Click;
            // 
            // aboutTsmi
            // 
            aboutTsmi.Name = "aboutTsmi";
            aboutTsmi.Size = new Size(102, 29);
            aboutTsmi.Text = "Hakkında";
            // 
            // panelContent
            // 
            panelContent.Controls.Add(statusStrip1);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 33);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1255, 430);
            panelContent.TabIndex = 1;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tssUserName });
            statusStrip1.Location = new Point(0, 408);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1255, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // tssUserName
            // 
            tssUserName.Name = "tssUserName";
            tssUserName.Size = new Size(0, 15);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1255, 463);
            Controls.Add(panelContent);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Oyun Koleksiyon Yonetim Sistemi";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileTsmi;
        private ToolStripMenuItem exitTsmi;
        private ToolStripMenuItem userTsmi;
        private ToolStripMenuItem registerTsmi;
        private ToolStripMenuItem userListTsmi;
        private ToolStripMenuItem gameTsmi;
        private ToolStripMenuItem reviewTsmi;
        private ToolStripMenuItem aboutTsmi;
        private ToolStripMenuItem newGameTsmi;
        private ToolStripMenuItem gameListTsmi;
        private ToolStripMenuItem addReviewTsmi;
        private ToolStripMenuItem reviewListTsmi;
        private Panel panelContent;
        private ToolStripMenuItem kullaniciToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tssUserName;
    }
}
