using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Card
    {
        public string stringVal;
        public string suit;
        public int val;

        public Card(string StringVal, string Suit, int Value)
        {
            stringVal = StringVal;
            suit = Suit;
            val = Value;
        }
    }

    class Deck
    {
        public List<Card> cards;

        public Deck()
        {
            cards = new List<Card>();
            string[] stringVal = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
            string[] suit = {"Clubs", "Spades", "Hearts", "Diamonds"};
            int[] val = {1,2,3,4,5,6,7,8,9,10,11,12,13};
            for(int i = 0; i < suit.Length; i++)
            {
                for(int j = 0; j < stringVal.Length; j++)
                {
                    Card card = new Card(stringVal[j], suit[i], val[j]);
                    cards.Add(card);
                }
            }
        }

        public Card deal()
        {
            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }

        public void reset()
        {
            cards = new List<Card>();
            string[] stringVal = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
            string[] suit = {"Clubs", "Spades", "Hearts", "Diamonds"};
            int[] val = {1,2,3,4,5,6,7,8,9,10,11,12,13};
            for(int i = 0; i < suit.Length; i++)
            {
                for(int j = 0; j < stringVal.Length; j++)
                {
                    Card card = new Card(stringVal[j], suit[i], val[j]);
                    cards.Add(card);
                }
            }
        }

        public void shuffle()
        {
            Random rand = new Random();
            for(int i = 0; i < cards.Count; i++)
            {
                int idx = rand.Next(0, 52);
                Card temp = cards[idx];
                cards[idx] = cards[i];
                cards[i] = temp;
            }
        }
        public void show()
        {
            foreach (var card in cards)
            {
                Console.WriteLine("Value: " + card.stringVal + " Suit: " + card.suit + " Number: " + card.val);
            }
        }
    }

    class Player
    {
        public string Name;
        public List<Card> hand;

        public Player(string name)
        {
            Name = name;
            hand = new List<Card>();
        }

        public void draw(Deck deck)
        {
            hand.Add(deck.deal());
        }

        public Card discard(int index)
        {
            if(index < hand.Count)
            {
                Card card = hand[index];
                hand.RemoveAt(index);
                return card;
            }
            else
            {
                return null;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.deal();
            deck.reset();
            deck.shuffle();
            deck.show();
            Player p1 = new Player("Bob");
            p1.draw(deck);
            Console.WriteLine(p1.discard(0));
            Console.WriteLine(p1.discard(0));
        }
    }
}
