using UnityEngine;
using System;

namespace Assignment29
{
    public class BasicsScript : MonoBehaviour
    {
        void Start()
        {
            var number = 5;
            var name = "Unity Student";
            var isActive = true;

            string message = $"The number {number} is {(number % 2 == 0 ? "even" : "odd")}.";
            Debug.Log(message);

            Debug.Log($"Current Date: {DateTime.Now.ToShortDateString()}");
            Debug.Log($"Current Time: {DateTime.Now.ToLongTimeString()}");
            Debug.Log($"Current Day: {DateTime.Now.DayOfWeek}");
        }
    }
}
