namespace GameCollectionManagement
{
    partial class UserList
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
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnLoad = new Button();
            panalContainer = new Panel();
            dgvUsers = new DataGridView();
            panel1.SuspendLayout();
            panalContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnLoad);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(967, 124);
            panel1.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(139, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(322, 31);
            txtSearch.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(3, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Ara";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(602, 80);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Güncelle";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(437, 74);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(274, 74);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(54, 74);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(176, 34);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Kullanıcıları Listele";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // panalContainer
            // 
            panalContainer.Controls.Add(dgvUsers);
            panalContainer.Dock = DockStyle.Fill;
            panalContainer.Location = new Point(0, 124);
            panalContainer.Name = "panalContainer";
            panalContainer.Size = new Size(967, 395);
            panalContainer.TabIndex = 1;
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.Location = new Point(0, 0);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 62;
            dgvUsers.Size = new Size(967, 395);
            dgvUsers.TabIndex = 0;
            // 
            // UserList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panalContainer);
            Controls.Add(panel1);
            Name = "UserList";
            Size = new Size(967, 519);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panalContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panalContainer;
        private DataGridView dgvUsers;
        private Button btnLoad;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnSearch;
        private TextBox txtSearch;
    }
}
