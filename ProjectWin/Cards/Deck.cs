using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWin.Cards
{
    public class Deck
    {
        public List<Card> Cards { get; private set; }
        public int BJackCount { get; private set; }

        public Deck(int numberOfDecks)
        {
            Cards = new List<Card>();
            for (int i = 0; i < 4 * numberOfDecks; i++)
            {
                foreach (var name in Enum.GetValues(typeof(CardNames)))
                {
                    Cards.Add(new Card((CardNames)name));
                }
            }
        }

        public Deck() : this(1)
        {
        }

        public void Wash() // randomly permutes the card list
        {
            if (Cards.Count == 0)
            {
                return;
            }
            var rnd = new Random();
            for (int i = 0; i < this.Cards.Count; i++)
            {
                var chosenIndex = rnd.Next(0, Cards.Count - 1 - i);
                var chosenCard = Cards[chosenIndex];
                Cards.RemoveAt(chosenIndex);
                Cards.Add(chosenCard);
            }
        }

        public void Shuffle() // for a "clean shuffle" where the deck is split in half and reconstrcuted by adding cards, one at a time, from alternate half decks
        {
            if (Cards.Count % 2 == 0)
            {
                var leftSide = Cards.GetRange(0, Cards.Count / 2);
                var rightSide = Cards.GetRange(Cards.Count / 2, Cards.Count / 2);
                var bound = Cards.Count / 2;
                Cards = new List<Card>();
                for (int i = 0; i < bound; i++)
                {
                    Cards.Add(leftSide[i]);
                    Cards.Add(rightSide[i]);
                }
                return;
            }

            //for odd size decks, we'll just take the top card off, shuffle the smaller deck, and add the top card back
            var topCard = Draw();
            if (topCard.Value <= 6)
            {
                BJackCount++;
            }
            if (topCard.Value >= 10)
            {
                BJackCount--;
            }

            Shuffle();
            Cards.Add(topCard);
        } 

        public Card Draw()
        {
            var topCard = Cards[0];

            if (topCard.Value >= 10)
            {
                BJackCount++;
            }

            if (topCard.Value <= 6)
            {
                BJackCount--;
            }

            Cards.RemoveAt(0);
            return topCard;
        }

        public void ShowDeck()
        {
            foreach (var card in Cards)
            {
                Console.WriteLine(card.Name + ", Value = " + card.Value);
            }
            Console.WriteLine();
            Console.WriteLine("Deck size = " + Cards.Count);
            Console.WriteLine("Count = " + BJackCount);
        }
    }
}
