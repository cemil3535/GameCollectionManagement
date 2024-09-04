namespace GameCollectionManagement
{
    partial class AddGame
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
            txtGameName = new TextBox();
            txtGameGenre = new TextBox();
            txtGameCoverImage = new TextBox();
            cbGamePlatform = new ComboBox();
            dtpGameReleaseDate = new DateTimePicker();
            numericGamePlayTime = new NumericUpDown();
            btnOpenFileDialog = new Button();
            ofdCoverImage = new OpenFileDialog();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnGameSave = new Button();
            ((System.ComponentModel.ISupportInitialize)numericGamePlayTime).BeginInit();
            SuspendLayout();
            // 
            // txtGameName
            // 
            txtGameName.Location = new Point(161, 11);
            txtGameName.Name = "txtGameName";
            txtGameName.Size = new Size(527, 31);
            txtGameName.TabIndex = 0;
            // 
            // txtGameGenre
            // 
            txtGameGenre.Location = new Point(161, 57);
            txtGameGenre.Name = "txtGameGenre";
            txtGameGenre.Size = new Size(527, 31);
            txtGameGenre.TabIndex = 1;
            // 
            // txtGameCoverImage
            // 
            txtGameCoverImage.Location = new Point(161, 275);
            txtGameCoverImage.Name = "txtGameCoverImage";
            txtGameCoverImage.Size = new Size(458, 31);
            txtGameCoverImage.TabIndex = 2;
            // 
            // cbGamePlatform
            // 
            cbGamePlatform.FormattingEnabled = true;
            cbGamePlatform.Items.AddRange(new object[] { "PC", "XBox", "Plat Station", "Nintendo" });
            cbGamePlatform.Location = new Point(161, 107);
            cbGamePlatform.Name = "cbGamePlatform";
            cbGamePlatform.Size = new Size(527, 33);
            cbGamePlatform.TabIndex = 6;
            // 
            // dtpGameReleaseDate
            // 
            dtpGameReleaseDate.Location = new Point(161, 162);
            dtpGameReleaseDate.Name = "dtpGameReleaseDate";
            dtpGameReleaseDate.Size = new Size(527, 31);
            dtpGameReleaseDate.TabIndex = 7;
            // 
            // numericGamePlayTime
            // 
            numericGamePlayTime.Location = new Point(161, 219);
            numericGamePlayTime.Name = "numericGamePlayTime";
            numericGamePlayTime.Size = new Size(527, 31);
            numericGamePlayTime.TabIndex = 8;
            // 
            // btnOpenFileDialog
            // 
            btnOpenFileDialog.Location = new Point(625, 273);
            btnOpenFileDialog.Name = "btnOpenFileDialog";
            btnOpenFileDialog.Size = new Size(74, 34);
            btnOpenFileDialog.TabIndex = 9;
            btnOpenFileDialog.Text = "...";
            btnOpenFileDialog.UseVisualStyleBackColor = true;
            btnOpenFileDialog.Click += btnOpenFileDialog_Click;
            // 
            // ofdCoverImage
            // 
            ofdCoverImage.FileName = "openFileDialog1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 17);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 10;
            label1.Text = "Oyun Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 63);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 11;
            label2.Text = "Oyun Turu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 113);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 12;
            label3.Text = "Oyun Platformu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 168);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 13;
            label4.Text = "Çıkış Tarihi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 225);
            label5.Name = "label5";
            label5.Size = new Size(107, 25);
            label5.TabIndex = 14;
            label5.Text = "Oyun Süresi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 281);
            label6.Name = "label6";
            label6.Size = new Size(112, 25);
            label6.TabIndex = 15;
            label6.Text = "Kapak Resmi";
            // 
            // btnGameSave
            // 
            btnGameSave.Location = new Point(587, 346);
            btnGameSave.Name = "btnGameSave";
            btnGameSave.Size = new Size(112, 34);
            btnGameSave.TabIndex = 16;
            btnGameSave.Text = "Oyun Ekle";
            btnGameSave.UseVisualStyleBackColor = true;
            btnGameSave.Click += btnGameSave_Click;
            // 
            // AddGame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnGameSave);
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
            Name = "AddGame";
            Size = new Size(724, 421);
            ((System.ComponentModel.ISupportInitialize)numericGamePlayTime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtGameName;
        private TextBox txtGameGenre;
        private TextBox txtGameCoverImage;
        private ComboBox cbGamePlatform;
        private DateTimePicker dtpGameReleaseDate;
        private NumericUpDown numericGamePlayTime;
        private Button btnOpenFileDialog;
        private OpenFileDialog ofdCoverImage;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnGameSave;
    }
}
