using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Potions;

namespace Potions
{
    public class HealthPotion : Potion
    {
        public HealthPotion() : base("Health", 50, false) { }

        public HealthPotion(int potencyLevel) : base("Health", potencyLevel, false) { }

        public override void UsePotion()
        {
            if (!isUsed)
            {
                isUsed = true;
                // Heal player by potencyLevel
            }
        }
    }
}
