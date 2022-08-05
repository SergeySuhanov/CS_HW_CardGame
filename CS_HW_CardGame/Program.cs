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
            game.PrintDeck();

            Console.ReadLine();
        }
    }

    class Game
    {
        string[] Suits = { "Spade", "Heart", "Diamond", "Club" };
        string[] Ranks = { "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
        Player[] Players;
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
                    index = j + (i * j);
                    Deck[index].Suit = Suits[i];
                    Deck[index].Rank = Ranks[j];
                }
            }
        }

        public void PrintDeck()
        {
            foreach(Karta card in Deck)
            {
                Console.WriteLine(card.Rank);
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
