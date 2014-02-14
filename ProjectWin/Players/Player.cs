using ProjectWin.Hands;
using ProjectWin.Players.Styles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWin.Players
{
    public class Player 
    {
        IBlackJackStyle Style { get; set; }
        public bool Hit
        {
            get
            {
                return Style.Hit;
            }
            set
            {
                Hit = value;
            }
        }
    }
}
