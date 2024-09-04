using GameCollectionManagement.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCollectionManagement
{
    public partial class GameList : UserControl
    {
        private readonly IGameService _gameService;

        public GameList()
        {
            InitializeComponent();

            _gameService = new GameService();
        }

        public void LoadGames()
        {
            var games = _gameService.GetAll();

            dgvGames.DataSource = games;

            dgvGames.Columns["Id"].Visible = false;

        }

        private void btnGameList_Click(object sender, EventArgs e)
        {
            LoadGames();
        }

        private void btnGameDelete_Click(object sender, EventArgs e)
        {
            if (dgvGames.SelectedRows.Count > 0)
            {
                int id = (int)dgvGames.SelectedRows[0].Cells["Id"].Value;

                string name = dgvGames.SelectedRows[0].Cells["Name"].Value.ToString();

                if (MessageBox.Show($"{name} adli oyunu silmek istediginizden emin misiniz?", "Silme Onayi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        _gameService.Delete(id);
                        LoadGames();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }


            }
            else
            {
                MessageBox.Show("Oyun Secmelisiniz.");
            }
        }

        private void btnEditGame_Click(object sender, EventArgs e)
        {
            if (dgvGames.SelectedRows.Count > 0)
            {
                int id = (int)dgvGames.SelectedRows[0].Cells["Id"].Value;

                EditGame editGame = new EditGame(id, this);

                editGame.ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddGameForm addGameForm = new AddGameForm(this);
            addGameForm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchterm = string.Empty;

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                searchterm = txtSearch.Text;
            }

            if (cbPlatform.SelectedItem != null)
            {
                searchterm = cbPlatform.SelectedItem.ToString();
            }

            if (cbGenre.SelectedItem != null)
            {
                searchterm = cbGenre.SelectedItem.ToString();
            }

            var games = _gameService.Search(searchterm);

            dgvGames.DataSource = games;
        }



        public void LoadGenres()
        {
            var genres = _gameService.GetGenres();

            cbGenre.Items.Clear();

            cbGenre.Items.AddRange(genres.ToArray());
        }



        private void GameList_Load(object sender, EventArgs e)
        {
            LoadGenres();
        }
    }
}
