using ProjectWin.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWin.Hands
{
    public class DealerHand : BlackJackHand
    {
        public Card UpCard { get { return Cards[0]; } set { UpCard = value; } }
    }
}
