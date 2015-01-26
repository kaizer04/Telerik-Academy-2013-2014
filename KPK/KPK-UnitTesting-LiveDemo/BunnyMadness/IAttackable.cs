namespace BunnyMadness
{
    public interface IAttackable
    {
        int Health { get; set; }
        
        bool IsAlive { get; }

        void Attack(IAttackable attackedObject, int weaponDamage);
    }
}
