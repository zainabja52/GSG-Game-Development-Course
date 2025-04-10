using UnityEngine;

public class SimpleCameraOrbit : MonoBehaviour
{
    public Transform target;
    public float distance = 7.0f;
    public float xSpeed = 120.0f;

    private float x = 0.0f;

    void Start()
    {
        Vector3 angles = transform.eulerAngles;
        x = angles.y;
    }

    void LateUpdate()
    {
        if (Input.GetMouseButton(1)) // Right mouse held
        {
            x += Input.GetAxis("Mouse X") * xSpeed * Time.deltaTime;
        }

        Quaternion rotation = Quaternion.Euler(20, x, 0);
        Vector3 negDistance = new Vector3(0.0f, 0.0f, -distance);
        Vector3 position = rotation * negDistance + target.position;

        transform.rotation = rotation;
        transform.position = position;
    }
}
