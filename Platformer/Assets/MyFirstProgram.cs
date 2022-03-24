using UnityEngine;
using Battle.Actors;
using Battle.Abilities;

public class MyFirstProgram : MonoBehaviour
{
    private void Start()
    {
        Actor hero = new Actor("Илья Муромец", 100, 20, new IAbility[] { new DamageBuff(5), new HpBuff(10) });
        Actor[] enemies = { 
            new Actor("Злыдень", 50, 10), 
            new Actor("Орк", 30, 15, 
            new IAbility[] { new DamageBuff(5)}) };
        
        Debug.Log("Let the buttle begins!");

        for(int battleTurn = 1; battleTurn <5; battleTurn++)
        {
            Debug.Log($"Фаза боя{battleTurn}");

            bool isHeroDead = false;
            bool isAllEnemiesDead = true;

            foreach(Actor enemy in enemies)
            {
                if (enemy.IsDead()) continue;
                
                //enemy attack hero
                enemy.UseAbilyty();
                isHeroDead = Attack(enemy, hero);
                if (isHeroDead) break;

                // hero attack enemy
                Actor heroAsBuffer = (Actor)hero;
                hero.UseAbilyty();
                var isEnemyDead = Attack(hero, enemy);
                isAllEnemiesDead = isAllEnemiesDead && isEnemyDead;
            }
            if (isHeroDead || isAllEnemiesDead) break;
        }
    }
    
    bool Attack(Actor attacker, Actor defender)
    {
        defender.TakeDamage(attacker);
        defender.PrintStatus();
        
        return defender.IsDead();
    }
   
}


