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

        //Test 
        Vector2 aceClubsV;
        Texture2D ClubsAceT;

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

            aceClubsV = new Vector2(45, 45);
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

            //testing
            ClubsAceT = Content.Load<Texture2D>("ClubsAce");

            //testDeck.getCard(0) = new Card("Club", 0, Content.Load<Texture2D>("ClubsAce"), new Vector2(25,50));
            testDeck.addCard(new Card("Club", 1, Content.Load<Texture2D>("ClubsAce")));
            testDeck.addCard(new Card("Club", 2, Content.Load<Texture2D>("ClubsTwo")));
            testDeck.addCard(new Card("Club", 3, Content.Load<Texture2D>("ClubsThree")));
            testDeck.addCard(new Card("Club", 4, Content.Load<Texture2D>("ClubsFour")));
            testDeck.addCard(new Card("Club", 5, Content.Load<Texture2D>("ClubsFive")));
            testDeck.addCard(new Card("Club", 6, Content.Load<Texture2D>("ClubsSix")));
            testDeck.addCard(new Card("Club", 7, Content.Load<Texture2D>("ClubsSeven")));
            testDeck.addCard(new Card("Club", 8, Content.Load<Texture2D>("ClubEight")));
            testDeck.addCard(new Card("Club", 9, Content.Load<Texture2D>("ClubNine")));
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
            ////////////////////////////////////////////////////////////////////////

            Texture2D[] cardArray = new Texture2D[52];
            cardArray[0] = Content.Load<Texture2D>("ClubsAce");
            cardArray[1] = Content.Load<Texture2D>("ClubsTwo");
            cardArray[2] = Content.Load<Texture2D>("ClubsThree");
            cardArray[3] = Content.Load<Texture2D>("ClubsFour");
            cardArray[4] = Content.Load<Texture2D>("ClubsFive");
            cardArray[5] = Content.Load<Texture2D>("ClubsSix");
            cardArray[6] = Content.Load<Texture2D>("ClubsSeven");
            cardArray[7] = Content.Load<Texture2D>("ClubsEight");
            cardArray[8] = Content.Load<Texture2D>("ClubsNine");
            cardArray[9] = Content.Load<Texture2D>("ClubsTen");
            cardArray[10] = Content.Load<Texture2D>("ClubsJack");
            cardArray[11] = Content.Load<Texture2D>("ClubsQueen");
            cardArray[12] = Content.Load<Texture2D>("ClubsKing");
            cardArray[13] = Content.Load<Texture2D>("DiamondsAce");
            cardArray[14] = Content.Load<Texture2D>("DiamondsTwo");
            cardArray[15] = Content.Load<Texture2D>("DiamondsThree");
            cardArray[16] = Content.Load<Texture2D>("DiamondsFour");
            cardArray[17] = Content.Load<Texture2D>("DiamondsFive");
            cardArray[18] = Content.Load<Texture2D>("DiamondsSix");
            cardArray[19] = Content.Load<Texture2D>("DiamondsSeven");
            cardArray[20] = Content.Load<Texture2D>("DiamondsEight");
            cardArray[21] = Content.Load<Texture2D>("DiamondsNine");
            cardArray[22] = Content.Load<Texture2D>("DiamondsTen");
            cardArray[23] = Content.Load<Texture2D>("DiamondsJack");
            cardArray[24] = Content.Load<Texture2D>("DiamondsQueen");
            cardArray[25] = Content.Load<Texture2D>("DiamondsKing");
            cardArray[26] = Content.Load<Texture2D>("HeartsAce");
            cardArray[27] = Content.Load<Texture2D>("HeartsTwo");
            cardArray[28] = Content.Load<Texture2D>("HeartsThree");
            cardArray[29] = Content.Load<Texture2D>("HeartsFour");
            cardArray[30] = Content.Load<Texture2D>("HeartsFive");
            cardArray[31] = Content.Load<Texture2D>("HeartsSix");
            cardArray[32] = Content.Load<Texture2D>("HeartsSeven");
            cardArray[33] = Content.Load<Texture2D>("HeartsEight");
            cardArray[34] = Content.Load<Texture2D>("HeartsNine");
            cardArray[35] = Content.Load<Texture2D>("HeartsTen");
            cardArray[36] = Content.Load<Texture2D>("HeartsJack");
            cardArray[37] = Content.Load<Texture2D>("HeartsQueen");
            cardArray[38] = Content.Load<Texture2D>("HeartsKing");
            cardArray[39] = Content.Load<Texture2D>("SpadesAce");
            cardArray[40] = Content.Load<Texture2D>("SpadesTwo");
            cardArray[41] = Content.Load<Texture2D>("SpadesThree");
            cardArray[42] = Content.Load<Texture2D>("SpadesFour");
            cardArray[43] = Content.Load<Texture2D>("SpadesFive");
            cardArray[44] = Content.Load<Texture2D>("SpadesSix");
            cardArray[45] = Content.Load<Texture2D>("SpadesSeven");
            cardArray[46] = Content.Load<Texture2D>("SpadesEight");
            cardArray[47] = Content.Load<Texture2D>("SpadesNine");
            cardArray[48] = Content.Load<Texture2D>("SpadesTen");
            cardArray[49] = Content.Load<Texture2D>("SpadesJack");
            cardArray[50] = Content.Load<Texture2D>("SpadesQueen");
            cardArray[51] = Content.Load<Texture2D>("SpadesKing");

            // TODO: use this.Content to load your game content here
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
                Rectangle r = new Rectangle((int)testDeck.getCard(0).getVector().X, (int)testDeck.getCard(0).getVector().Y, cardWidth, cardHeight);
                

                // If mouse pointer is within the bounds of the card then drag it.
                if (r.Contains(new Point(x, y)))
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
                    testDeck.getCard(0).setVector(new Vector2(x, y));
                }
            }

            // Debug: Where is the mouse, sprite, and vector at. // The problem is that the sprite X and Y values always remain at 0.
            System.Diagnostics.Debug.Print("Update: Mouse at: " + x + ", " + y+". Card at: "+testDeck.getCard(0).getSprite().Bounds+". Vector at: "+testDeck.getCard(0).getVector());


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
            //spriteBatch.Draw(ClubsAceT, aceClubsV, Color.White);

            Rectangle spritePosition = new Rectangle((int)testDeck.getCard(0).getVector().X, (int)testDeck.getCard(0).getVector().Y, (int)testDeck.getCard(0).getSprite().Width, (int)testDeck.getCard(0).getSprite().Height);
            spriteBatch.Draw(testDeck.getCard(0).getSprite(), spritePosition, Color.White);

            //spriteBatch.Draw(testDeck.getCard(0).getSprite(), testDeck.getCard(0).getVector(), Color.White);

            // Debug where is the sprite at
            System.Diagnostics.Debug.Print("Draw: Sprite at:" + spritePosition);

            spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
