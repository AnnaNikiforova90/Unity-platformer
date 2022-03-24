using Battle.Actors;
namespace Battle.Abilities
{
    public class DamageBuff : IAbility
    {
        public int DamageBuffValue;
        public DamageBuff(int damageBuffValue)
        {
            DamageBuffValue = damageBuffValue;
        }
        public void Use(Actor target)
        {
            target.Damage += DamageBuffValue;
            target.Log($" издаёт боевой клич! Урон увеличен на {DamageBuffValue}");
        }
    }

}