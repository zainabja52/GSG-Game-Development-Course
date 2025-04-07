using UnityEngine;

public class Player
{
    public string playerName;
    public int health;

    public static int playerCount = 0;

    public void InitializePlayer(string name, int initialHealth)
    {
        this.playerName = name;
        this.health = initialHealth;
        Player.playerCount++;

        Debug.Log($"Welcome {playerName}! Starting health is set to {health}.");
    }

    public void Heal(int amount)
    {
        health += amount;
        Debug.Log($"{playerName} healed by {amount}. Health is now {health}.");
    }

    public void Heal(bool fullRestore)
    {
        if (fullRestore)
        {
            health = 100;
            Debug.Log($"{playerName} has been completely healed. Full health: {health}.");
        }
    }

    public static void ShowPlayerCount()
    {
        Debug.Log($"There are currently {playerCount} player(s).");
    }
}
