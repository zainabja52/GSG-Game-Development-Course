
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Player p = new Player("Zainab", 50);
        Enemy e = new Enemy("Ghaidaa", 100);

        Debug.Log("Player Info: " + p.Name + " | Health = " + p.Health);
        Debug.Log("Enemy Info: " + e.Name + " | Health = " + e.Health);

        p.Heal(30);

        e.Attack(p, 40);
    }
}
