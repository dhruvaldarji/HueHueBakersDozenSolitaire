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

        /// <summary>
        /// Returns the card at a given vector
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Return a card if given point is in card bounds
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public Card getCardAtBounds(int x, int y) 
        {
            for (int i = 0; i < cardArray.Length; i++)
            {
                Rectangle r = new Rectangle((int)cardArray[i].getVector().X, (int)cardArray[i].getVector().Y, 72, 97);

                if (r.Contains(new Point(x,y)))
                {
                    return cardArray[i];
                }
            }
            return null;
        }

        /// <summary>
        /// return length of the deck.
        /// </summary>
        /// <returns></returns>
        public int getDeckSize()
        {
            return cardArray.Length;
        }
    }
}
