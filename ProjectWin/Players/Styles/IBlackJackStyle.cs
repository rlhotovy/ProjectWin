using ProjectWin.Cards;
using ProjectWin.Hands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWin.Players.Styles
{
    interface IBlackJackStyle
    {
        IBlackJackHand Hand { get; set; }
        Card ObservedCard { get; set; }
        bool Hit { get; set; }
    }
}
