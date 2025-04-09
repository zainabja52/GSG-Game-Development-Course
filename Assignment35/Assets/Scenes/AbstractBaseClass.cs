using UnityEngine;

namespace Assignment35
{
    public abstract class AbstractBaseClass
    {
        public abstract void PerformAction();

        public void PrintInfo()
        {
            Debug.Log("This is a concrete method in the abstract base class.");
        }
    }
}
