using UnityEngine;

public class KineticCube : MonoBehaviour
{
    public float floatAmplitude = 0.5f;
    public float floatFrequency = 1f;
    public float rotationSpeed = 45f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        // Floating motion using sine wave
        float y = Mathf.Sin(Time.time * floatFrequency) * floatAmplitude;
        transform.position = startPos + new Vector3(0, y, 0);

        // Continuous rotation
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
