using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    class DeckOfCard
    {
        Cards[] cards;
        string[] suits = { "Club", "Heart", "Diamond", "Spade" };
        string[] rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

        //when creatin the object the constructor will be called.
        //Initialization of card take place
        public DeckOfCard()
        {
            cards = InitializeCard();
        }

        //initialize card method
        public Cards[] InitializeCard()
        {
            Cards[] card = new Cards[52];
            int cardIndex = 0;
            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < rank.Length; j++)
                {
                    //store the cards with suita and rank in given order
                    card[cardIndex] = new Cards(suits[i], rank[j]);
                    cardIndex++;
                }
            }
            return card;
        }

        //method to shuffle the card 
        public void shuffle(Cards[] cards)
        {
            Random random = new Random();
            Cards card;
            for (int i = 0; i < 52; i++)
            {
                //use two random index and swap that two place 
                int index = random.Next(52);
                int index2 = random.Next(52);
                card = cards[index];
                cards[index] = cards[index2];
                cards[index2] = card;
            }
        }

        //method allocate the cards to the player
        public Cards[,] alotCards(Cards[,] players)
        {
            int playersIndex = 0;
            shuffle(this.cards);
            for (int i = 0; i < players.GetLength(0); i++)
            {
                for (int j = 0; j < players.GetLength(1); j++)
                {
                    //distribute the cards to each player in shuffled order
                    players[i, j] = cards[playersIndex];
                    playersIndex++;
                }
            }
            return players;
        }

        //display the distributed cards 
        public void display(Cards[,] players)
        {
            for (int i = 0; i < players.GetLength(0); i++)
            {
                Console.WriteLine("Player" + (i + 1) + " Cards: ");
                for (int j = 0; j < players.GetLength(1); j++)
                {
                    Console.WriteLine(players[i, j].suit + "     " + players[i, j].rank + " ");
                }
                Console.WriteLine("========================");
            }
        }
    }
}
