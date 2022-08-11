using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.CreateDeck();
            game.ShuffleDeck();
            game.PrintDeck();

            Console.ReadLine();
        }
    }

    class Game
    {
        string[] Suits = { "Spade", "Heart", "Diamond", "Club" };
        string[] Ranks = { "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
        List<Player> Players = new List<Player>();
        Karta[] Deck;
        public Game()
        {
            Deck = new Karta[36];
        }
        public void CreateDeck()
        {
            int index;
            for (int i = 0; i < Suits.Length; i++)
            {
                for (int j = 0; j < Ranks.Length; j++)
                {
                    index = j + (i * Ranks.Length);
                    Deck[index] = new Karta(Suits[i], Ranks[j]);
                }
            }
        }

        public void ShuffleDeck()
        {
            var rand = new Random();
            int shifts = 150;
            int randIndexOne, randIndexTwo;
            for (int i = 0; i < shifts; i++)
            {
                randIndexOne = rand.Next(36);
                randIndexTwo = rand.Next(36);
                Karta temp = Deck[randIndexOne];
                Deck[randIndexOne] = Deck[randIndexTwo];
                Deck[randIndexTwo] = temp;
            }
        }

        public void CreatePlayers(int playersNumber)
        {
            int cardsPerPlayer = 36 / playersNumber;
            for (int i = 0; i < playersNumber; i++)
            {
                Player johnDoe = new Player(cardsPerPlayer); 
                Players.Add
            }
        }

        public void PrintDeck()
        {
            foreach(Karta card in Deck)
            {
                Console.WriteLine($"{card.Rank} of {card.Suit}");
            }
        }
    }

    class Player
    {
        Karta[] Cards;
    }

    class Karta
    {
        public string Suit;
        public string Rank;
        
        public Karta()
        {
            Suit = "";
            Rank = "";
        }
        public Karta(string _suit, string _rank)
        {
            Suit = _suit;
            Rank = _rank;
        }
    }
}
