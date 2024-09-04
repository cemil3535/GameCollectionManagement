namespace GameCollectionManagement
{
    partial class EditReview
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
            btnEdit = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtReview = new TextBox();
            nudRating = new NumericUpDown();
            cbGames = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nudRating).BeginInit();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(334, 327);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Güncelle";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 112);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 12;
            label3.Text = "Yorum";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 66);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 11;
            label2.Text = "Rating";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 20);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 10;
            label1.Text = "Oyun";
            // 
            // txtReview
            // 
            txtReview.Location = new Point(114, 109);
            txtReview.Multiline = true;
            txtReview.Name = "txtReview";
            txtReview.Size = new Size(332, 198);
            txtReview.TabIndex = 9;
            // 
            // nudRating
            // 
            nudRating.Location = new Point(114, 60);
            nudRating.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudRating.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudRating.Name = "nudRating";
            nudRating.Size = new Size(332, 31);
            nudRating.TabIndex = 8;
            nudRating.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbGames
            // 
            cbGames.FormattingEnabled = true;
            cbGames.Location = new Point(112, 12);
            cbGames.Name = "cbGames";
            cbGames.Size = new Size(334, 33);
            cbGames.TabIndex = 7;
            // 
            // EditReview
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEdit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtReview);
            Controls.Add(nudRating);
            Controls.Add(cbGames);
            Name = "EditReview";
            Text = "EditReview";
            ((System.ComponentModel.ISupportInitialize)nudRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEdit;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtReview;
        private NumericUpDown nudRating;
        private ComboBox cbGames;
    }
}