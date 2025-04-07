using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    int GetProduct(int fixedNumber, int current)
    {
        return fixedNumber * current;
    }

    void Start()
    {
        int fixedNumber = 5;

        for (int current = 1; current <= 10; current++)
        {
            int output = GetProduct(fixedNumber, current);
            Debug.Log(fixedNumber + " x " + current + " = " + output);
        }
    }
}
