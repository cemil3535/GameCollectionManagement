namespace GameCollectionManagement
{
    partial class EditGame
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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnOpenFileDialog = new Button();
            numericGamePlayTime = new NumericUpDown();
            dtpGameReleaseDate = new DateTimePicker();
            cbGamePlatform = new ComboBox();
            txtGameCoverImage = new TextBox();
            txtGameGenre = new TextBox();
            txtGameName = new TextBox();
            btnEdit = new Button();
            ofdCoverImage = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)numericGamePlayTime).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 305);
            label6.Name = "label6";
            label6.Size = new Size(112, 25);
            label6.TabIndex = 28;
            label6.Text = "Kapak Resmi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 249);
            label5.Name = "label5";
            label5.Size = new Size(107, 25);
            label5.TabIndex = 27;
            label5.Text = "Oyun Süresi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 192);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 26;
            label4.Text = "Çıkış Tarihi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 137);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 25;
            label3.Text = "Oyun Platformu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 87);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 24;
            label2.Text = "Oyun Turu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 41);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 23;
            label1.Text = "Oyun Adı";
            // 
            // btnOpenFileDialog
            // 
            btnOpenFileDialog.Location = new Point(638, 297);
            btnOpenFileDialog.Name = "btnOpenFileDialog";
            btnOpenFileDialog.Size = new Size(74, 34);
            btnOpenFileDialog.TabIndex = 22;
            btnOpenFileDialog.Text = "...";
            btnOpenFileDialog.UseVisualStyleBackColor = true;
            btnOpenFileDialog.Click += btnOpenFileDialog_Click;
            // 
            // numericGamePlayTime
            // 
            numericGamePlayTime.Location = new Point(174, 243);
            numericGamePlayTime.Name = "numericGamePlayTime";
            numericGamePlayTime.Size = new Size(527, 31);
            numericGamePlayTime.TabIndex = 21;
            // 
            // dtpGameReleaseDate
            // 
            dtpGameReleaseDate.Location = new Point(174, 186);
            dtpGameReleaseDate.Name = "dtpGameReleaseDate";
            dtpGameReleaseDate.Size = new Size(527, 31);
            dtpGameReleaseDate.TabIndex = 20;
            // 
            // cbGamePlatform
            // 
            cbGamePlatform.FormattingEnabled = true;
            cbGamePlatform.Items.AddRange(new object[] { "PC", "XBox", "Plat Station", "Nintendo" });
            cbGamePlatform.Location = new Point(174, 131);
            cbGamePlatform.Name = "cbGamePlatform";
            cbGamePlatform.Size = new Size(527, 33);
            cbGamePlatform.TabIndex = 19;
            // 
            // txtGameCoverImage
            // 
            txtGameCoverImage.Location = new Point(174, 299);
            txtGameCoverImage.Name = "txtGameCoverImage";
            txtGameCoverImage.Size = new Size(458, 31);
            txtGameCoverImage.TabIndex = 18;
            // 
            // txtGameGenre
            // 
            txtGameGenre.Location = new Point(174, 81);
            txtGameGenre.Name = "txtGameGenre";
            txtGameGenre.Size = new Size(527, 31);
            txtGameGenre.TabIndex = 17;
            // 
            // txtGameName
            // 
            txtGameName.Location = new Point(174, 35);
            txtGameName.Name = "txtGameName";
            txtGameName.Size = new Size(527, 31);
            txtGameName.TabIndex = 16;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(656, 386);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(120, 34);
            btnEdit.TabIndex = 29;
            btnEdit.Text = "Guncelle";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // ofdCoverImage
            // 
            ofdCoverImage.FileName = "file name";
            // 
            // EditGame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 499);
            Controls.Add(btnEdit);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnOpenFileDialog);
            Controls.Add(numericGamePlayTime);
            Controls.Add(dtpGameReleaseDate);
            Controls.Add(cbGamePlatform);
            Controls.Add(txtGameCoverImage);
            Controls.Add(txtGameGenre);
            Controls.Add(txtGameName);
            Name = "EditGame";
            Text = "Oyun Guncelle";
            ((System.ComponentModel.ISupportInitialize)numericGamePlayTime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnOpenFileDialog;
        private NumericUpDown numericGamePlayTime;
        private DateTimePicker dtpGameReleaseDate;
        private ComboBox cbGamePlatform;
        private TextBox txtGameCoverImage;
        private TextBox txtGameGenre;
        private TextBox txtGameName;
        private Button btnEdit;
        private OpenFileDialog ofdCoverImage;
    }
}