using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelser
{
    internal class Player
    {
        private Texture2D sprite;

        public void LoadContent(ContentManager content)
        {
            sprite = content.Load<Texture2D>("1fwd");
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sprite,new Vector2(0,0), Color.White);
        }
    }
}
