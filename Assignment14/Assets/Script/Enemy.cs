
using UnityEngine;

public class Enemy : Character
{
    public Enemy(string name, int health) : base(name, health)
    {
    }

    public void Attack(Character target, int amount)
    {
        target.Health -= amount;

        Debug.Log(Name + " attacked " + target.Name + " causing " + amount + " damage. " +
                  target.Name + "'s health is now " + target.Health);
    }
}
