using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace HueHueBakersDozenSolitaire
{
    class Tableu
    {
        /// <summary>
        /// List of cards in Tableu
        /// </summary>
        public List<Card> tableuList;

        /// <summary>
        /// Name of Tableu
        /// </summary>
        public int tableuName;
        
        /// <summary>
        /// Texture of Tableu
        /// </summary>
        public Texture2D tableuTexture;

        /// <summary>
        /// Vector of Tableu
        /// </summary>
        public Vector2 tableuVector;

        /// <summary>
        /// Construct a new Tableu with Texture at Vector
        /// </summary>
        public Tableu()
        {
            tableuList = new List<Card>();
            tableuVector = new Vector2(0, 0);
            tableuName = 0;
        }
        
        /// <summary>
        /// Construct new Tableu at Vector (0,0)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="t"></param>
        /// <param name="v"></param>
        public Tableu(int name, Texture2D t, Vector2 v)
        {
            tableuList = new List<Card>();
            tableuName = name;
            tableuTexture = t;
            tableuVector = v;
        }

        /// <summary>
        /// String representation of Tableu
        /// </summary>
        /// <returns></returns>
        public String toString()
        {
            return "Tableu " + tableuName;
        }

        public int getTableuSize()
        {
            return tableuList.Count;
        }

        /// <summary>
        /// Add card c to tableu
        /// </summary>
        /// <param name="x"></param>
        public void addCardToTableu(Card c)
        {
            c.setVector(new Vector2((int)tableuVector.X, (int)tableuVector.Y+(getTableuSize()*10)));
            tableuList.Add(c);
        }

        /// <summary>
        /// Remove card c from tableu
        /// </summary>
        /// <param name="x"></param>
        public void removeCard(Card c)
        {
            for (int i = 0; i < tableuList.Count; i++)
            {
                if (tableuList.ElementAt(i).Equals(c))
                {
                    tableuList.RemoveAt(i);
                }
            }

        }

        /// <summary>
        /// Return card at position
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Card getTableuCard(int i)
        {
            return tableuList.ElementAt(i);
        }

        /// <summary>
        /// Check if vector is within bounds of tableu
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public Boolean contains(Vector2 v)
        {
            int height = ((tableuList.Count-1)*10+87);
            Rectangle c = new Rectangle((int)tableuVector.X, (int)tableuVector.Y, 72, 97);
            if (c.Contains((int)v.X, (int)v.Y))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Get Tableu Vector
        /// </summary>
        /// <returns></returns>
        public Vector2 getTableuVector()
        {
            return tableuVector;
        }

        /// <summary>
        /// Set Tableu vector
        /// </summary>
        /// <param name="v"></param>
        public void setTableuVector(Vector2 v)
        {
            tableuVector = v;
        }

        /// <summary>
        /// Get Tableu Texture
        /// </summary>
        /// <returns></returns>
        public Texture2D getTableuTexture()
        {
            return tableuTexture;
        }

        /// <summary>
        /// Set Tableu vector
        /// </summary>
        /// <param name="t"></param>
        public void setTableuTexture(Texture2D t)
        {
            tableuTexture = t;
        }

        /// <summary>
        /// Get Tableu Name
        /// </summary>
        /// <returns></returns>
        public int getTableuName()
        {
            return tableuName;
        }

        /// <summary>
        /// Set Tableu vector
        /// </summary>
        /// <param name="n"></param>
        public void setTableuName(int n)
        {
            tableuName = n;
        }

    }
}
