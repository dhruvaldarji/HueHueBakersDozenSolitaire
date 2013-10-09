using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace HueHueBakersDozenSolitaire
{
    class Card
    {
        int value; // Num/Char (A,2,3,4,5,6,7,8,9,10,J,Q,K)
        int suit; // Suit (Spade, Club, Heart, Diamond)

        /// <summary>
        /// Main Card Object.
        /// </summary>
        public Card()
        {
            
        }

        /// <summary>
        /// Main Card Object.
        /// </summary>
        /// <param name="s">Provides Card Suit.</param>
        /// <param name="v">Provides Card Value</param>
        public Card(int s, int v)
        {
            suit = s;
            value = v;
        }

        /// <summary>
        /// Get the Suit of a Card
        /// </summary>
        /// <returns>suit</returns>
        public int getSuit()
        {
            return suit;
        }

        /// <summary>
        /// Set the suit of a Card
        /// </summary>
        /// <param name="t"></param>
        public void setSuit(int t)
        {
            suit = t;
        }

        /// <summary>
        /// Get the value of a card.
        /// </summary>
        /// <returns>value</returns>
        public int getValue()
        {
            return value;
        }

        /// <summary>
        /// Set the value of a card.
        /// </summary>
        /// <param name="v"></param>
        public void setValue(int v)
        {
            value = v;
        } 
    }
}
