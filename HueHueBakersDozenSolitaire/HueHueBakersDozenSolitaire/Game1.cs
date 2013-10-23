using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace HueHueBakersDozenSolitaire
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        // Dhruval's card dragging testing 
        //Card testDeck.getCard(0);
        Boolean dragging = false;
        int x;
        int y;
        int cardWidth = 72;
        int cardHeight = 97;
        int screenWidth = 800;
        int screenHeight = 480;
        Deck testDeck = new Deck();
        Card temp = new Card();
        Vector2[] testCardPlacement = new Vector2[52];
        ///////////////////////////////////

        Rectangle BackgroundR;
        Texture2D BGT;
        Vector2[] cardArrayV;
        int i, j, k;
        //Manuel was heres
        //Kyle was here. Cool sprites.
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            BackgroundR = new Rectangle(0, 0, graphics.PreferredBackBufferWidth, graphics.PreferredBackBufferHeight);

            // Make mouse pointer visible
            this.IsMouseVisible = true;

            //make array cycle from 0 to 51, correct positioning of cards.
            for (int k = 0; k <= 2; k++)
            {
                for (int i = 0; i <= 7; i++)
                {
                    for (int j = 0; j <= 4; j++)
                    {
                       
                        //cardArrayV[i] =  new Vector2(i*100*(k+1), j*10*(k+1+200));

                    }
                }
            }
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            BGT = Content.Load<Texture2D>("Background");
            spriteBatch = new SpriteBatch(GraphicsDevice);

            //testDeck.getCard(0) = new Card("Club", 0, Content.Load<Texture2D>("ClubsAce"), new Vector2(25,50));
            testDeck.addCard(new Card("Club", 1, Content.Load<Texture2D>("ClubsAce")));
            testDeck.addCard(new Card("Club", 2, Content.Load<Texture2D>("ClubsTwo")));
            testDeck.addCard(new Card("Club", 3, Content.Load<Texture2D>("ClubsThree")));
            testDeck.addCard(new Card("Club", 4, Content.Load<Texture2D>("ClubsFour")));
            testDeck.addCard(new Card("Club", 5, Content.Load<Texture2D>("ClubsFive")));
            testDeck.addCard(new Card("Club", 6, Content.Load<Texture2D>("ClubsSix")));
            testDeck.addCard(new Card("Club", 7, Content.Load<Texture2D>("ClubsSeven")));
            testDeck.addCard(new Card("Club", 8, Content.Load<Texture2D>("ClubsEight")));
            testDeck.addCard(new Card("Club", 9, Content.Load<Texture2D>("ClubsNine")));
            testDeck.addCard(new Card("Club", 10, Content.Load<Texture2D>("ClubsTen")));
            testDeck.addCard(new Card("Club", 11, Content.Load<Texture2D>("ClubsJack")));
            testDeck.addCard(new Card("Club", 12, Content.Load<Texture2D>("ClubsQueen")));
            testDeck.addCard(new Card("Club", 13, Content.Load<Texture2D>("ClubsKing")));
            testDeck.addCard(new Card("Diamond", 1, Content.Load<Texture2D>("DiamondsAce")));
            testDeck.addCard(new Card("Diamond", 2, Content.Load<Texture2D>("DiamondsTwo")));
            testDeck.addCard(new Card("Diamond", 3, Content.Load<Texture2D>("DiamondsThree")));
            testDeck.addCard(new Card("Diamond", 4, Content.Load<Texture2D>("DiamondsFour")));
            testDeck.addCard(new Card("Diamond", 5, Content.Load<Texture2D>("DiamondsFive")));
            testDeck.addCard(new Card("Diamond", 6, Content.Load<Texture2D>("DiamondsSix")));
            testDeck.addCard(new Card("Diamond", 7, Content.Load<Texture2D>("DiamondsSeven")));
            testDeck.addCard(new Card("Diamond", 8, Content.Load<Texture2D>("DiamondsEight")));
            testDeck.addCard(new Card("Diamond", 9, Content.Load<Texture2D>("DiamondsNine")));
            testDeck.addCard(new Card("Diamond", 10, Content.Load<Texture2D>("DiamondsTen")));
            testDeck.addCard(new Card("Diamond", 11, Content.Load<Texture2D>("DiamondsJack")));
            testDeck.addCard(new Card("Diamond", 12, Content.Load<Texture2D>("DiamondsQueen")));
            testDeck.addCard(new Card("Diamond", 13, Content.Load<Texture2D>("DiamondsKing")));
            testDeck.addCard(new Card("Hearts", 1, Content.Load<Texture2D>("HeartsAce")));
            testDeck.addCard(new Card("Hearts", 2, Content.Load<Texture2D>("HeartsTwo")));
            testDeck.addCard(new Card("Hearts", 3, Content.Load<Texture2D>("HeartsThree")));
            testDeck.addCard(new Card("Hearts", 4, Content.Load<Texture2D>("HeartsFour")));
            testDeck.addCard(new Card("Hearts", 5, Content.Load<Texture2D>("HeartsFive")));
            testDeck.addCard(new Card("Hearts", 6, Content.Load<Texture2D>("HeartsSix")));
            testDeck.addCard(new Card("Hearts", 7, Content.Load<Texture2D>("HeartsSeven")));
            testDeck.addCard(new Card("Hearts", 8, Content.Load<Texture2D>("HeartsEight")));
            testDeck.addCard(new Card("Hearts", 9, Content.Load<Texture2D>("HeartsNine")));
            testDeck.addCard(new Card("Hearts", 10, Content.Load<Texture2D>("HeartsTen")));
            testDeck.addCard(new Card("Hearts", 11, Content.Load<Texture2D>("HeartsJack")));
            testDeck.addCard(new Card("Hearts", 12, Content.Load<Texture2D>("HeartsQueen")));
            testDeck.addCard(new Card("Hearts", 13, Content.Load<Texture2D>("HeartsKing")));
            testDeck.addCard(new Card("Spades", 1, Content.Load<Texture2D>("SpadesAce")));
            testDeck.addCard(new Card("Spades", 2, Content.Load<Texture2D>("SpadesTwo")));
            testDeck.addCard(new Card("Spades", 3, Content.Load<Texture2D>("SpadesThree")));
            testDeck.addCard(new Card("Spades", 4, Content.Load<Texture2D>("SpadesFour")));
            testDeck.addCard(new Card("Spades", 5, Content.Load<Texture2D>("SpadesFive")));
            testDeck.addCard(new Card("Spades", 6, Content.Load<Texture2D>("SpadesSix")));
            testDeck.addCard(new Card("Spades", 7, Content.Load<Texture2D>("SpadesSeven")));
            testDeck.addCard(new Card("Spades", 8, Content.Load<Texture2D>("SpadesEight")));
            testDeck.addCard(new Card("Spades", 9, Content.Load<Texture2D>("SpadesNine")));
            testDeck.addCard(new Card("Spades", 10, Content.Load<Texture2D>("SpadesTen")));
            testDeck.addCard(new Card("Spades", 11, Content.Load<Texture2D>("SpadesJack")));
            testDeck.addCard(new Card("Spades", 12, Content.Load<Texture2D>("SpadesQueen")));
            testDeck.addCard(new Card("Spades", 13, Content.Load<Texture2D>("SpadesKing")));

            //This sets the vectors for all of the above mentioned cards.
            testCardPlacement[0] = new Vector2(25, 65);
            testCardPlacement[1] = new Vector2(25, 85);
            testCardPlacement[2] = new Vector2(25, 105);
            testCardPlacement[3] = new Vector2(25, 125);
            testCardPlacement[4] = new Vector2(120, 65);
            testCardPlacement[5] = new Vector2(120, 85);
            testCardPlacement[6] = new Vector2(120, 105);
            testCardPlacement[7] = new Vector2(120, 125);
            testCardPlacement[8] = new Vector2(210, 65);
            testCardPlacement[9] = new Vector2(210, 85);
            testCardPlacement[10] = new Vector2(210, 105);
            testCardPlacement[11] = new Vector2(210, 125);
            testCardPlacement[12] = new Vector2(300, 65);
            testCardPlacement[13] = new Vector2(300, 85);
            testCardPlacement[14] = new Vector2(300, 105);
            testCardPlacement[15] = new Vector2(300, 125);
            testCardPlacement[16] = new Vector2(390, 65);
            testCardPlacement[17] = new Vector2(390, 85);
            testCardPlacement[18] = new Vector2(390, 105);
            testCardPlacement[19] = new Vector2(390, 125);
            testCardPlacement[20] = new Vector2(485, 65);
            testCardPlacement[21] = new Vector2(485, 85);
            testCardPlacement[22] = new Vector2(485, 105);
            testCardPlacement[23] = new Vector2(485, 125);
            testCardPlacement[24] = new Vector2(580, 65);
            testCardPlacement[25] = new Vector2(580, 85);
            testCardPlacement[26] = new Vector2(580, 105);
            testCardPlacement[27] = new Vector2(580, 125);
            testCardPlacement[28] = new Vector2(75, 300);
            testCardPlacement[29] = new Vector2(75, 320);
            testCardPlacement[30] = new Vector2(75, 340);
            testCardPlacement[31] = new Vector2(75, 360);
            testCardPlacement[32] = new Vector2(165, 300);
            testCardPlacement[33] = new Vector2(165, 320);
            testCardPlacement[34] = new Vector2(165, 340);
            testCardPlacement[35] = new Vector2(165, 360);
            testCardPlacement[36] = new Vector2(255, 300);
            testCardPlacement[37] = new Vector2(255, 320);
            testCardPlacement[38] = new Vector2(255, 340);
            testCardPlacement[39] = new Vector2(255, 360);
            testCardPlacement[40] = new Vector2(350, 300);
            testCardPlacement[41] = new Vector2(350, 320);
            testCardPlacement[42] = new Vector2(350, 340);
            testCardPlacement[43] = new Vector2(350, 360);
            testCardPlacement[44] = new Vector2(445, 300);
            testCardPlacement[45] = new Vector2(445, 320);
            testCardPlacement[46] = new Vector2(445, 340);
            testCardPlacement[47] = new Vector2(445, 360);
            testCardPlacement[48] = new Vector2(530, 300);
            testCardPlacement[49] = new Vector2(530, 320);
            testCardPlacement[50] = new Vector2(530, 340);
            testCardPlacement[51] = new Vector2(530, 360);

            for (i = 0; i < 52; i++)
            {
                testDeck.getCard(i).setVector(testCardPlacement[i]);
            }
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // get location of the mouse
            x = Mouse.GetState().X;
            y = Mouse.GetState().Y;

            // Allows the game to exit
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                this.Exit();

            // If dragging = false mouse left button is pressed, check if mouse is within card bounds.
            if (!dragging && (Mouse.GetState().LeftButton == ButtonState.Pressed))
            {
                // Create a reference rectangle for measurement reasons.
                temp = testDeck.getCardAtBounds(x, y);

                // If card exist under mouse pointer.
                if (temp!=null)
                {
                    dragging = true;
                }
            }

            // Stop dragging if button is released and the last state of the button was pressed.
            if (Mouse.GetState().LeftButton == ButtonState.Released)
            {
                dragging = false;
            }

            // Pick the card up and move to mouse location when left clicked if true
            if (dragging)
            {
                if ((x > 0) && (y > 0) && (x + cardWidth < screenWidth) && (y + cardHeight < screenHeight))
                {
                    Vector2 v = new Vector2(x, y);
                    temp.setVector(v);
                }
            }

            // Debug: Where is the mouse, sprite, and vector at. // The problem is that the sprite X and Y values always remain at 0.
             try
                {
                    System.Diagnostics.Debug.Print("Update: Mouse at: " + x + ", " + y + ". Card at: " + temp.getSprite().Bounds + ". Vector at: " + temp.getVector());
                }
                catch (Exception)
                {
                    System.Diagnostics.Debug.Print("Update: Mouse at: " + x + ", " + y + ". Card is Null");
                }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();

            spriteBatch.Draw(BGT, BackgroundR, Color.White);
            
            for (int i = 0; i < 52; i = i + 1)
            {
                spriteBatch.Draw(testDeck.getCard(i).getSprite(), testDeck.getCard(i).getVector(), Color.White);
            }

            spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
