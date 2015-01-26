namespace BunnyMadness
{
    using System;

    public class Bunny : IAttackable
    {
        private const int InitialHealth = 100;
        
        public Bunny()
        {
            this.Health = InitialHealth;
        }
        
        public int Health { get; set; }

        public bool IsAlive 
        {
            get
            { 
                return this.Health > 0 ? true : false;
            }
        }

        public void Attack(IAttackable attackedObject, int weaponDamage)
        {
            if (weaponDamage < 0)
            { 
                throw new ArgumentOutOfRangeException("Weapon damage cannot be lessthan zero");
            }
            
            attackedObject.Health -= weaponDamage;
        }
    }
}
