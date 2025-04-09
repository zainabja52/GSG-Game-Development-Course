using UnityEngine;

namespace Assignment35
{
    public class BoxingUnboxing : MonoBehaviour
    {
        void Start()
        {
            int health = 100;
            object boxed = health; // Boxing
            int unboxed = (int)boxed; // Unboxing
            unboxed += 50;

            Debug.Log($"Original int value: {health}");
            Debug.Log($"Boxed value: {boxed}");
            Debug.Log($"Unboxed and modified value: {unboxed}");
        }
    }
}
