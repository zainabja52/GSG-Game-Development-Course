using UnityEngine;
using Assignment18;

public class CharacterTest : MonoBehaviour
{
    void Start()
    {
        Character[] characters = new Character[2];

        characters[0] = new Soldier(); // Default constructor
        characters[1] = new Officer("Zainab", 90, new Position(5, 10, 2)); // Parameterized

        foreach (Character character in characters)
        {
            character.DisplayInfo();
        }

        Debug.Log("Before attack, Soldier Health: " + characters[0].Health);
        characters[1].Attack(20, characters[0], "shooting");
        Debug.Log("After attack, Soldier Health: " + characters[0].Health);
    }
}
