using UnityEngine;

namespace Assignment27
{
    public class Assignment27 : MonoBehaviour
    {
        void Start()
        {
            int a = 5;
            int b = 10;
            int c;

            Debug.Log("Original value of a (before call by value): " + a);
            CallByValue(a);
            Debug.Log("Value of a (after call by value): " + a); // Should remain unchanged

            Debug.Log("Original value of b (before call by reference): " + b);
            CallByReference(ref b);
            Debug.Log("Value of b (after call by reference): " + b); // Should be modified

            CallByOut(out c);
            Debug.Log("Value of c (after call by out): " + c); // Should show assigned value
        }

        // Call by Value
        void CallByValue(int valueParam)
        {
            valueParam += 10;
            Debug.Log("Inside CallByValue, modified value: " + valueParam);
        }

        // Call by Reference
        void CallByReference(ref int refParam)
        {
            refParam += 10;
            Debug.Log("Inside CallByReference, modified value: " + refParam);
        }

        // Using out keyword
        void CallByOut(out int outParam)
        {
            outParam = 42;
            Debug.Log("Inside CallByOut, assigned value: " + outParam);
        }
    }
}
