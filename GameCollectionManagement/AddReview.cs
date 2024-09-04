using GameCollectionManagement.Models;
using GameCollectionManagement.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCollectionManagement
{
    public partial class AddReview : UserControl
    {
        private readonly IReviewService _reviewService;

        private readonly User _user;

        private readonly IGameService _gameService;

        private readonly ReviewList _reviewList;


        public AddReview(User user)
        {
            InitializeComponent();
            _user = user;
            _gameService = new GameService();
            _reviewService = new ReviewService();

            var games = _gameService.GetAll();
            cbGames.DataSource = games;
            cbGames.DisplayMember = "Name";
            cbGames.ValueMember = "Id";
            
        }


        public AddReview(User user, ReviewList reviewList)
        {
            InitializeComponent();
            _user = user;
            _gameService = new GameService();
            _reviewService = new ReviewService();

            var games = _gameService.GetAll();
            cbGames.DataSource = games;
            cbGames.DisplayMember = "Name";
            cbGames.ValueMember = "Id";
            _reviewList = reviewList;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    Game selectedGame = cbGames.SelectedItem as Game;

                    if (selectedGame == null)
                    {
                        MessageBox.Show("Sistemsel bir hata olustu.");
                    }



                    Review review = new Review()
                    {
                        Rating = (int)nudRating.Value,
                        ReviewText = txtReview.Text.Trim(),
                        UserId = _user.Id,
                        GameId = selectedGame.Id
                    };

                    _reviewService.Add(review);

                    MessageBox.Show("Yorumunuz eklendi");
                    
                    if (_reviewList is not null)
                    {
                        _reviewList.LoadReviews();
                        ((Form)Parent.Parent).Close();
                    }
                    ClearInputs();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void ClearInputs()
        {
            foreach (var ctrl in Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                }
                else if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).SelectedItem = null;
                }
                else if (ctrl is NumericUpDown)
                {
                    ((NumericUpDown)ctrl).Value = nudRating.Minimum;
                }

            }
        }

        private bool ValidateInput()
        {
            if (cbGames.SelectedItem == null)
            {
                MessageBox.Show("Oyun secmelisiniz");

                return false;
            }

            if (nudRating.Value < 1 || nudRating.Value > 5)
                {
                MessageBox.Show("Rating araligi 1-5 arsidir.");
                return false;
                }

            if (string.IsNullOrWhiteSpace(txtReview.Text)) 
            {
                MessageBox.Show("Yorum girmelisiniz.");
                return false;
            }

            return true;
        }
    }
}
