using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Potions;

namespace Potions
{
    public class SpeedPotion : Potion
    {
        public SpeedPotion() : base("Speed", 10, false) { }

        public SpeedPotion(int potencyLevel) : base("Speed", potencyLevel, false) { }

        public override void UsePotion()
        {
            if (!isUsed)
            {
                isUsed = true;
                // Increase player speed by potencyLevel for a few seconds
            }
        }
    }
}
