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
    /// <summary>
    /// En klasse, som bruges til at repræsentere vores Player
    /// </summary>
    internal class Player
    {
        /// <summary>
        /// Player's sprite
        /// </summary>
        private Texture2D sprite;

        /// <summary>
        /// Loader content på Player klassen
        /// </summary>
        /// <param name="content"></param>
        public void LoadContent(ContentManager content)
        {
            //Loader et billed, som skal vises på skærmen når vores Player tegnes.
            sprite = content.Load<Texture2D>("1fwd");
        }

        /// <summary>
        /// Tegner Player klassen
        /// </summary>
        /// <param name="spriteBatch"></param>
        public void Draw(SpriteBatch spriteBatch)
        {
            //Tegner vores Player i toppen af venstre hjørne
            spriteBatch.Draw(sprite, new Vector2(0, 0), Color.White);
        }
    }
}
