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

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
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
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
