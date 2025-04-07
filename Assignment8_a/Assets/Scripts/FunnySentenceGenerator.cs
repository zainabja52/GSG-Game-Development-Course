using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunnySentenceGenerator : MonoBehaviour
{
    void Start()
    {
        string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        System.Random random = new System.Random();
        string sentence = "";
        int count = 0;

        while (count < 7)
        {
            sentence += words[random.Next(words.Length)] + " "; // Randomly pick words and form a sentence
            count++;
        }

        Debug.Log(sentence.Trim()); // Print the funny sentence
    }
}
