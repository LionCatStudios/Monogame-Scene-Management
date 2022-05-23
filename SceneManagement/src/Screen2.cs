using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.Screens;
using MonoGame.Extended.Screens.Transitions;
namespace SceneManagement.src
{
    public class Screen2 : GameScreen
    {
        private new Game1 Game => (Game1)base.Game;
        private Texture2D sprite;
        public Screen2(Game1 game) : base(game) { }
        public override void LoadContent()
        {
            sprite = Game.Content.Load<Texture2D>("Health_Kit (16 x 16)");
            base.LoadContent();
        }
        public override void Update(GameTime gameTime)
        {

        }
        public override void Draw(GameTime gameTime)
        {
            Game.GraphicsDevice.Clear(Color.Blue);
            Game._spriteBatch.Begin();
            Game._spriteBatch.Draw(sprite, new Vector2(0, 0), Color.White);
            Game._spriteBatch.End();
        }
    }
}
