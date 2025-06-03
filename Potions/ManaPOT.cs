using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Potions;

namespace Potions
{
    public class ManaPotion : Potion
    {
        public ManaPotion() : base("Mana", 30, false) { }

        public ManaPotion(int potencyLevel) : base("Mana", potencyLevel, false) { }

        public override void UsePotion()
        {
            if (!isUsed)
            {
                isUsed = true;
                // Restore mana by potencyLevel
            }
        }
    }
}
