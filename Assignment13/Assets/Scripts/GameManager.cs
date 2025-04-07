using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Player firstPlayer = new Player();
        firstPlayer.InitializePlayer("Zainab", 60);
        firstPlayer.Heal(15);

        Player secondPlayer = new Player();
        secondPlayer.InitializePlayer("Zahraa", 40);
        secondPlayer.Heal(true);

        Player.ShowPlayerCount();
    }
}
