using UnityEngine;

public class Player : Character
{
    public Player(string name, int health) : base(name, health)
    {
    }

    public void Heal(int amount)
    {
        Health += amount;

        Debug.Log(Name + " received healing of " + amount + " points. Current health: " + Health);
    }
}
