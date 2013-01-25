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
    class Player:Actor
    {
        // Constants
        private const float MoveStickScale = 1.0f;
        
        //Varibles
        private float hMovement;

        private void GetInput(
            KeyboardState keyboardState,
            GamePadState gamePadState)
        {
            //Getting analog horizontal movement
            hMovement = gamePadState.ThumbSticks.Left.X * MoveStickScale;

            //Ignoring small movements 
            if (Math.Abs(hMovement) < 0.5f)
                hMovement = 0.0f;

            //Button presses
            if (gamePadState.IsButtonDown(Buttons.DPadDown) ||
                keyboardState.IsKeyDown(Keys.Right))
            {
                hMovement = -1.0f;
            }
            else if (gamePadState.IsButtonDown(Buttons.DPadDown) ||
              keyboardState.IsKeyDown(Keys.Right))
            {
                hMovement = 1.0f;
            }
        }
    }
}
