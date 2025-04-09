using UnityEngine;
using System.Collections.Generic;

namespace Assignment26
{
    public class CreatureManager : MonoBehaviour
    {
        void Start()
        {
            // Create creatures
            Kangaroo kangaroo = new Kangaroo();
            Duck duck = new Duck();

            // Base creature list
            List<Creature> creatures = new List<Creature> { kangaroo, duck };

            // Interface-based lists
            List<IRunnable> runners = new List<IRunnable> { kangaroo, duck };
            List<IJumpable> jumpers = new List<IJumpable> { kangaroo };
            List<ISwimmable> swimmers = new List<ISwimmable> { duck };

            // Speak
            foreach (Creature creature in creatures)
            {
                creature.Speak();
            }

            // Run
            foreach (IRunnable runner in runners)
            {
                runner.Run();
            }

            // Jump
            foreach (IJumpable jumper in jumpers)
            {
                jumper.Jump();
            }

            // Swim
            foreach (ISwimmable swimmer in swimmers)
            {
                swimmer.Swim();
            }
        }
    }
}
