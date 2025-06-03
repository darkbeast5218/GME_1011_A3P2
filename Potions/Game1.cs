using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System; 

namespace Potions 
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        // Potion textures
        private Texture2D healthPotionTexture;
        private Texture2D manaPotionTexture;
        private Texture2D speedPotionTexture;
        private Texture2D emptyPotionTexture; 

        // Potion objects
        private HealthPotion healthPotion;
        private ManaPotion manaPotion;
        private SpeedPotion speedPotion;

        // Potion positions (where they appear on screen)
        private Vector2 healthPotionPosition = new Vector2(120, 100);
        private Vector2 manaPotionPosition = new Vector2(400, 100);
        private Vector2 speedPotionPosition = new Vector2(260, 225);

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            // Set preferred back buffer size (window size)
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 480; 
            _graphics.ApplyChanges();
        }

        protected override void Initialize()
        {
            // No playerPosition to initialize anymore
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // Load each specific potion texture
            healthPotionTexture = Content.Load<Texture2D>("Potion_of_Healing");
            manaPotionTexture = Content.Load<Texture2D>("Potion_of_Mana");
            speedPotionTexture = Content.Load<Texture2D>("Potion_of_Speed");
            emptyPotionTexture = Content.Load<Texture2D>("Empty_Potion"); 

            // Create potion instances
            healthPotion = new HealthPotion(50);
            manaPotion = new ManaPotion(30);
            speedPotion = new SpeedPotion(10);
        }

        protected override void Update(GameTime gameTime)
        {
            KeyboardState ks = Keyboard.GetState();

            // Exit the game if Escape is pressed
            if (ks.IsKeyDown(Keys.Escape))
                Exit();

            // Potion Usage with Keybinds
            if (ks.IsKeyDown(Keys.H) && !healthPotion.GetIsUsed())
            {
                healthPotion.UsePotion(); 
            }

            if (ks.IsKeyDown(Keys.M) && !manaPotion.GetIsUsed())
            {
                manaPotion.UsePotion();
            }

            if (ks.IsKeyDown(Keys.S) && !speedPotion.GetIsUsed())
            {
                speedPotion.UsePotion();
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue); 

            _spriteBatch.Begin();

            
            if (!healthPotion.GetIsUsed())
            {
                _spriteBatch.Draw(healthPotionTexture, healthPotionPosition, Color.White);
            }
            else
            {
                _spriteBatch.Draw(emptyPotionTexture, healthPotionPosition, Color.White);
            }

            // Draw Mana Potion
            if (!manaPotion.GetIsUsed())
            {
                _spriteBatch.Draw(manaPotionTexture, manaPotionPosition, Color.White);
            }
            else
            {
                _spriteBatch.Draw(emptyPotionTexture, manaPotionPosition, Color.White);
            }

            // Draw Speed Potion
            if (!speedPotion.GetIsUsed())
            {
                _spriteBatch.Draw(speedPotionTexture, speedPotionPosition, Color.White);
            }
            else
            {
                _spriteBatch.Draw(emptyPotionTexture, speedPotionPosition, Color.White);
            }

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}