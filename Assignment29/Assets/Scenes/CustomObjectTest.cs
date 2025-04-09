using UnityEngine;

namespace Assignment29
{
    public class CustomObjectTest : MonoBehaviour
    {
        void Start()
        {
            CustomObject obj1 = new CustomObject(1, "Example");
            print(obj1);

            // comparison
            /*
            CustomObject obj2 = new CustomObject(1, "Example");
            print(obj1 == obj2); // false without operator overload
            print(obj1 != obj2);
            */
        }
    }
}
