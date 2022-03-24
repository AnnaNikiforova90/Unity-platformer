using UnityEngine;
using Battle.Abilities;
namespace Battle.Actors
{
    public class Actor
    {
        private IAbility[] Abilities;
        
        private string Name;
        public int Hp;
        public int Damage;
        private int MaxHp;

        public Actor(string name, int hp, int damage, IAbility[] abilities = null)
        {
            Name = name;
            Hp = hp;
            Damage = damage;
            Abilities = abilities;

            Initialize();
        }

        public void TakeDamage(Actor attacker)
        {
            Hp -= attacker.Damage;
            Log($" был атакован {attacker.Name}");
        }
        public void PrintStatus()
        {
            if (IsDead())
                Log(" погибает!");
            else
                Log($" осталось {Hp}/{MaxHp} очков здоровья.");
        }
        private void Initialize()
        {
            MaxHp = Hp;
            Log("Вступает в битву");
        }

        public void Log(string message)
        {
            Debug.Log($"{Name}: {message}");
        }
        public bool IsDead()
        {
            return Hp <= 0;
        }

        public virtual void UseAbilyty()
        {
            if (Abilities != null)
            {
                foreach(IAbility ability in Abilities)
                {
                    ability.Use(this);
                }
            }
        }
    }
}
