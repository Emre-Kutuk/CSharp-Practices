﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class PlayingCard
    {
        public CardSuit suit;
        public int rank;

        public PlayingCard(int rank, CardSuit suit)
        {
            this.rank = rank;
            this.suit = suit;
        }

        public override string ToString()
        {
            if (this.rank < 11 && this.rank != 1)
                return (this.rank + " of " + this.suit);
            else if (this.rank == 1)
                return ("Ace of " + this.suit);
            else if (this.rank == 11)
                return ("Jack of " + this.suit);
            else if (this.rank == 12)
                return ("Queen of " + this.suit);
            else if (this.rank == 13)
                return ("King of " + this.suit);

            return null;
        }

    }
}
