using Battle.Actors;
namespace Battle.Abilities
{
    public class HpBuff : IAbility
    {
        public int HpBuffValue;
        public HpBuff(int hpBuffValue)
        {
            HpBuffValue = hpBuffValue;
        }
        public void Use(Actor target)
        {
            target.Hp += HpBuffValue;
            target.Log($"Применяет исцеление. Исцелено {HpBuffValue} Hp.");
        }
    }
        
}