using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace HueHueBakersDozenSolitaire
{
  
    class Deck
    {
        Card[] cardArray;
        int currentEmptyLocation = 0;
        public Deck()
        {
            cardArray = new Card[52];

        }
        public void addCard(Card x)
        {
            cardArray[currentEmptyLocation] = x;
            currentEmptyLocation++;
        }

        public Card getCard(int position)
        {
            return cardArray[position];
        }

        public Card getCardAtVector(Vector2 v)
        {
            for(int i = 0;i<cardArray.Length;i++)
            {
                if( cardArray[i].getVector().Equals(v))
                {
                    return cardArray[i];
                }
            }
            return null;
        }
    }
}
