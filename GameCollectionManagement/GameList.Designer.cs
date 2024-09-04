namespace GameCollectionManagement
{
    partial class GameList
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            btnSearch = new Button();
            cbGenre = new ComboBox();
            cbPlatform = new ComboBox();
            txtSearch = new TextBox();
            btnAdd = new Button();
            btnGameDelete = new Button();
            btnGameList = new Button();
            btnEditGame = new Button();
            panel2 = new Panel();
            dgvGames = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGames).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(cbGenre);
            panel1.Controls.Add(cbPlatform);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnGameDelete);
            panel1.Controls.Add(btnGameList);
            panel1.Controls.Add(btnEditGame);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1071, 160);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(678, 69);
            label2.Name = "label2";
            label2.Size = new Size(37, 25);
            label2.TabIndex = 9;
            label2.Text = "Tür";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 71);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 8;
            label1.Text = "Platform";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(52, 21);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cbGenre
            // 
            cbGenre.FormattingEnabled = true;
            cbGenre.Location = new Point(721, 63);
            cbGenre.Name = "cbGenre";
            cbGenre.Size = new Size(182, 33);
            cbGenre.TabIndex = 6;
            // 
            // cbPlatform
            // 
            cbPlatform.FormattingEnabled = true;
            cbPlatform.Items.AddRange(new object[] { "PC", "XBox", "Plat Station", "Nintendo" });
            cbPlatform.Location = new Point(266, 66);
            cbPlatform.Name = "cbPlatform";
            cbPlatform.Size = new Size(182, 33);
            cbPlatform.TabIndex = 5;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(196, 21);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(789, 31);
            txtSearch.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(29, 117);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnGameDelete
            // 
            btnGameDelete.BackColor = Color.Red;
            btnGameDelete.ForeColor = Color.White;
            btnGameDelete.Location = new Point(504, 120);
            btnGameDelete.Name = "btnGameDelete";
            btnGameDelete.Size = new Size(112, 34);
            btnGameDelete.TabIndex = 2;
            btnGameDelete.Text = "Oyunu Sil";
            btnGameDelete.UseVisualStyleBackColor = false;
            btnGameDelete.Click += btnGameDelete_Click;
            // 
            // btnGameList
            // 
            btnGameList.Location = new Point(220, 118);
            btnGameList.Name = "btnGameList";
            btnGameList.Size = new Size(143, 34);
            btnGameList.TabIndex = 1;
            btnGameList.Text = "Oyunları Listele";
            btnGameList.UseCompatibleTextRendering = true;
            btnGameList.UseVisualStyleBackColor = true;
            btnGameList.Click += btnGameList_Click;
            // 
            // btnEditGame
            // 
            btnEditGame.Anchor = AnchorStyles.Right;
            btnEditGame.Location = new Point(721, 120);
            btnEditGame.Name = "btnEditGame";
            btnEditGame.Size = new Size(149, 31);
            btnEditGame.TabIndex = 0;
            btnEditGame.Text = "Oyun Güncelle";
            btnEditGame.UseVisualStyleBackColor = true;
            btnEditGame.Click += btnEditGame_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvGames);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 160);
            panel2.Name = "panel2";
            panel2.Size = new Size(1071, 373);
            panel2.TabIndex = 2;
            // 
            // dgvGames
            // 
            dgvGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGames.Dock = DockStyle.Fill;
            dgvGames.Location = new Point(0, 0);
            dgvGames.Name = "dgvGames";
            dgvGames.RowHeadersWidth = 62;
            dgvGames.Size = new Size(1071, 373);
            dgvGames.TabIndex = 0;
            // 
            // GameList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "GameList";
            Size = new Size(1071, 533);
            Load += GameList_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGames).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnEditGame;
        private Panel panel2;
        private DataGridView dgvGames;
        private Button btnGameList;
        private Button btnGameDelete;
        private Button btnAdd;
        private TextBox txtSearch;
        private ComboBox cbGenre;
        private ComboBox cbPlatform;
        private Button btnSearch;
        private Label label1;
        private Label label2;
    }
}
