using ProjectWin.Cards;
using ProjectWin.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWin.Hands
{
    public interface IBlackJackHand
    {
        Player Holder { get; set; }
        List<Card> Cards { get; set; }
        int RawScore { get; set; }
        int Score { get; set; }
        bool IsSoft { get; set; }
        bool Busted { get; set; }
        bool HasAce { get; set; }
        bool Blackjack { get; set; }
    }
}
