using UnityEngine;

namespace Assignment29
{
    public class UnitySpecificScript : MonoBehaviour
    {
        private GameObject targetObject;

        void OnEnable() => print("GameObject Enabled");
        void OnDisable() => print("GameObject Disabled");

        void Start()
        {
            print("Game started!");

            // Find by name
            targetObject = GameObject.Find("TargetObject");
            if (targetObject != null)
                print($"Found object by name: {targetObject.name}");
            else
                print("No TargetObject found.");

            // Find by tag
            GameObject joker = GameObject.FindGameObjectWithTag("Joker");
            if (joker != null)
                print($"Found object by tag: {joker.name}");
            else
                print("No Joker object found.");

            // Find by type
            Light foundLight = GameObject.FindObjectOfType<Light>();
            if (foundLight != null)
                print($"Found object of type Light: {foundLight.name}");
            else
                print("No Light object found.");
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.D) && targetObject != null)
            {
                targetObject.SetActive(false);
                print("TargetObject deactivated!");
            }
        }
    }
}
