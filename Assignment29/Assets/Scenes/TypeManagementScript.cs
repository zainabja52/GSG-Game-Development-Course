using UnityEngine;
using System.Collections.Generic;

namespace Assignment29
{
    public class TypeManagementScript : MonoBehaviour
    {
        void Start()
        {
            Animal myAnimal = new Cat(); // Upcasting
            myAnimal.MakeSound();        // Meow!
            myAnimal.Move();             // Animal moves.

            Cat myCat = myAnimal as Cat; // Downcasting
            if (myCat != null)
            {
                myCat.MakeSound();      // Meow!
                myCat.Move();           // Cat runs quickly.
            }

            List<ICanFight> fighters = new List<ICanFight>
            {
                new Cat(),
                new Warrior()
            };

            foreach (var fighter in fighters)
            {
                fighter.Attack();

                if (fighter is Cat)
                    Debug.Log("The object is a Cat.");
                else if (fighter is Warrior)
                    Debug.Log("The object is a Warrior.");
            }
        }
    }

    public class Animal
    {
        public virtual void MakeSound() => Debug.Log("Animal sound");
        public virtual void Move() => Debug.Log("Animal moves.");
    }

    public class Cat : Animal, ICanFight
    {
        public override void MakeSound() => Debug.Log("Meow!");
        public override void Move() => Debug.Log("Cat runs quickly.");
        public void Attack() => Debug.Log("Cat attacks with claws!");
    }

    public class Warrior : ICanFight
    {
        public void Attack() => Debug.Log("Warrior attacks with a sword!");
    }

    public interface ICanFight
    {
        void Attack();
    }
}
