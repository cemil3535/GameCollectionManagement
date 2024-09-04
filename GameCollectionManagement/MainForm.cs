using GameCollectionManagement.Models;

namespace GameCollectionManagement
{
    public partial class MainForm : Form
    {
        private readonly User _user;

        public MainForm(User user)
        {
            InitializeComponent();
            _user = user;

            tssUserName.Text = _user.UserName;
        }

        private void AddControl(UserControl control)
        {
            panelContent.Controls.Clear();

            panelContent.Controls.Add(control);
        }

        private void newGameTsmi_Click(object sender, EventArgs e)
        {
            AddControl(new AddGame());
        }

        private void gameListTsmi_Click(object sender, EventArgs e)
        {
            AddControl(new GameList());
        }

        private void registerTsmi_Click(object sender, EventArgs e)
        {
            AddControl(new AddUser());
        }

        private void userListTsmi_Click(object sender, EventArgs e)
        {
            AddControl(new UserList());
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addReviewTsmi_Click(object sender, EventArgs e)
        {
            AddControl(new AddReview(_user));
        }

        private void reviewListTsmi_Click(object sender, EventArgs e)
        {
            AddControl(new ReviewList(_user));
        }





        //private void oyunToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        //private void tumKullanicilarToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        //private void MainForm_Load(object sender, EventArgs e)
        //{

        //}
    }
}
