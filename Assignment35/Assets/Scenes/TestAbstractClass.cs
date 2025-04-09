using UnityEngine;

namespace Assignment35
{
    public class TestAbstractClass : MonoBehaviour
    {
        void Start()
        {
            AbstractBaseClass obj = new DerivedClassExample();
            obj.PerformAction();
            obj.PrintInfo();
        }
    }
}
