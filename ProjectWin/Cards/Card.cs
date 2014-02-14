using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWin.Cards
{
    public class Card
    {
        public String Name { get; private set; }
        public int Value { get; private set; }

        public Card(CardNames name)
        {
            Name = name.ToString();

            Value = Math.Min((int)name, 10);
        }
    }
}
