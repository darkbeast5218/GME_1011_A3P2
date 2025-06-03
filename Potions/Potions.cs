using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Potions
{
    public class Potion
    {
        protected string potionType;
        protected int potencyLevel;
        protected bool isUsed;

        // Zero-argument constructor
        public Potion()
        {
            potionType = "Generic";
            potencyLevel = 0;
            isUsed = false;
        }

        // Argumented constructor
        public Potion(string potionType, int potencyLevel, bool isUsed)
        {
            this.potionType = potionType;
            this.potencyLevel = potencyLevel;
            this.isUsed = isUsed;
        }

        // Accessors
        public string GetPotionType() { return potionType; }
        public int GetPotencyLevel() { return potencyLevel; }
        public bool GetIsUsed() { return isUsed; }

        // Mutators
        public void SetPotionType(string type) { potionType = type; }
        public void SetPotencyLevel(int level) { potencyLevel = level; }
        public void SetIsUsed(bool used) { isUsed = used; }

        // ✅ NOW MARKED VIRTUAL so it can be overridden
        public virtual void UsePotion()
        {
            if (!isUsed)
            {
                isUsed = true;
                // Default effect
            }
        }
    }
}