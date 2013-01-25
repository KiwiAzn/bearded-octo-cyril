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


namespace GameJam
{
    class Actor
    {

        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }
        public Vector2 position;
                    
        public Vector2 Velocity
        {
            get { return Velocity; }
            set { Velocity = value; }
        }
        Vector2 velocity;

        public void Update(GameTime gameTime, KeyboardState keyboard)
        {
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {

        }

    }
}
