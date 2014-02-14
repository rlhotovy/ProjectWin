using ProjectWin.Cards;
using ProjectWin.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWin.Hands
{
    public class BlackJackHand : IBlackJackHand
    {
        public Player Holder { get; set; }
        public List<Card> Cards { get; set; }
        public int RawScore
        {
            get
            {
                return Cards.Sum(c => c.Value);
            }
            set
            {
                RawScore = value;
            }
        }
        public int Score
        {
            get
            {
                if (HasAce && RawScore <= 11)
                {
                    return RawScore + 10;
                }
                return RawScore;
            }
            set
            {
                Score = value;
            }
        }
        public bool IsSoft
        {
            get
            {
                if (HasAce && RawScore <= 11)
                {
                    return true;
                }
                return false;
            }
            set
            {
                IsSoft = value;
            }
        }
        public bool Busted 
        {
            get
            {
                if (Score > 21)
                {
                    return true;
                }
                return false;
            }
            set
            {
                Busted = value;
            }
        }
        public bool HasAce
        {
            get
            {
                var Ace = false;
                foreach (var card in Cards)
                {
                    if (card.Value == 1)
                    {
                        Ace = true;
                    }
                }
                return Ace;
            }
            set
            {
                HasAce = value;
            }
        }
        public bool Blackjack
        {
            get
            {
                if (Cards.Count == 2 && Score == 21)
                {
                    return true;
                }
                return false;
            }
            set
            {
                Blackjack = value;
            }
        }
    }
}
