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
        String suit; // Suit (Spade, Club, Heart, Diamond)
        Texture2D cardSprite; // Image for the card
        Vector2 vector; // Vector for moving sprite

        /// <summary>
        /// Main Card Object.
        /// </summary>
        public Card()
        {
            
        }

        /// <summary>
        /// Main Card Object
        /// </summary>
        /// <param name="s"></param>
        /// <param name="num"></param>
        /// <param name="img"></param>
        /// <param name="v"></param>
        public Card(String s, int num, Texture2D img, Vector2 v)
        {
            suit = s;
            value = num;
            cardSprite = img;
            vector = v;
        }

        public Card(String s, int num, Texture2D img)
        {
            suit = s;
            value = num;
            cardSprite = img;
            vector = new Vector2(0, 0);
        }
        /// <summary>
        /// Get the Suit of a Card
        /// </summary>
        /// <returns>suit</returns>
        public String getSuit()
        {
            return suit;
        }

        /// <summary>
        /// Set the suit of a Card
        /// </summary>
        /// <param name="t"></param>
        public void setSuit(String t)
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

        /// <summary>
        /// Get the image of the card
        /// </summary>
        /// <returns></returns>
        public Texture2D getSprite()
        {
            return cardSprite;
        }

        /// <summary>
        /// Set the image of a card
        /// </summary>
        /// <param name="img"></param>
        public void setSprite(Texture2D img)
        {
            cardSprite = img;
        }

        /// <summary>
        /// Get card vector
        /// </summary>
        /// <returns></returns>
        public Vector2 getVector()
        {
            return vector;
        }

        /// <summary>
        /// Set card vector
        /// </summary>
        /// <param name="v"></param>
        public void setVector(Vector2 v)
        {
            vector = v;
        }

    }
}
