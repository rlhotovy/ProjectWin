using ProjectWin.Cards;
using ProjectWin.Hands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWin.Players.Styles
{
    class Conservative : IBlackJackStyle
    {
        public IBlackJackHand Hand { get; set; }
        public Card ObservedCard { get; set; }
        public bool Hit
        {
            get
            {
                if (!(ObservedCard.Value > 1 && ObservedCard.Value < 7))
                {
                    return ((Hand.Score < 16 || (Hand.Score <= 17 && Hand.IsSoft)));
                }
                return false;
            }
            set
            {
                Hit = value;
            }
        }

    }
}
