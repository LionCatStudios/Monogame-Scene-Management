using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended.Screens;
using MonoGame.Extended.Screens.Transitions;
namespace SceneManagement.src
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        public SpriteBatch _spriteBatch;

        private readonly ScreenManager screenManager;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            screenManager = new ScreenManager();
            Components.Add(screenManager);
        }
        private void LoadScreen1()
        {
            screenManager.LoadScreen(new Screen1(this), new FadeTransition(GraphicsDevice, Color.Black));
        }
        private void LoadScreen2()
        {
            screenManager.LoadScreen(new Screen2(this), new FadeTransition(GraphicsDevice, Color.Black));
        }
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            
            base.Initialize();
            LoadScreen1();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            KeyboardState keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.E))
            {
                LoadScreen1();
            }
            else if (keyboardState.IsKeyDown(Keys.F))
            {
                LoadScreen2();
            }
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
