using UnityEngine;
using System.Collections.Generic;

namespace Assignment35
{
    public class ListMethodsExample : MonoBehaviour
    {
        void Start()
        {
            // Part 4 - Sort in reverse order
            List<int> numbers = new List<int> { 3, 1, 4, 1, 5, 9 };
            numbers.Sort((x, y) => y.CompareTo(x));
            Debug.Log(string.Join(", ", numbers));

            // Part 5 - Find all even numbers
            List<int> numbers2 = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6 };
            List<int> filteredNumbers = numbers2.FindAll(x => x % 2 == 0);
            Debug.Log(string.Join(", ", filteredNumbers));
        }
    }
}
