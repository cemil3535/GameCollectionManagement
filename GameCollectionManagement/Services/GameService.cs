﻿using GameCollectionManagement.Models;
using GameCollectionManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollectionManagement.Services
{
    public class GameService : IGameService
    {
        private readonly GameRepository _gameRepository;

        public GameService()
        {
            _gameRepository = new GameRepository();
        }

        public void Add(Game game)
        {
            if(string.IsNullOrEmpty(game.Name))
                throw new ArgumentException("Oyun adi olmadan ekleme yapamazsiniz.");

            _gameRepository.Add(game);
        }

        public void Delete(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Gecersiz oyun Id");

            var game = GetById(id);

            if (game is not null)
            {
                _gameRepository.Delete(game);
            }
        }

        public List<Game> GetAll()
        {
           return _gameRepository.GetAll();
        }

        

        public List<Game> GetByGenre(string genre)
        {
            return GetAll().Where(g=>g.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public Game GetById(int id)
        {
            return _gameRepository.GetById(id);
        }

        public List<string> GetGenres()
        {
            return _gameRepository.GetGenres();
        }

        public int GetTotalCount()
        {
            return GetAll().Count;
        }

        public List<Game> Search(string searchTerm)
        {
            return GetAll().Where(g=>g.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) 
                                  || g.Genre.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) 
                                  || g.Platform.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                            .ToList();
        }

        public void Update(Game game)
        {
            if (game.Id <= 0)
                throw new ArgumentException("Gecersiz oyun Id");

            var currentGame = GetById(game.Id);

            if (currentGame is not null)
            {
                _gameRepository.Update(game);
            }
            
        }
    }

}
