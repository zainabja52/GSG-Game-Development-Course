using UnityEngine;

public class ToyController : MonoBehaviour
{
    private Rigidbody rb;
    private Renderer rend;

    public float moveSpeed = 5f;
    public float jumpForce = 5f;

    public ParticleSystem jumpEffect;
    public AudioSource jumpSound;

    private float colorTimer = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();

        if (rb == null)
            Debug.LogError("Rigidbody is missing!");
        if (rend == null)
            Debug.LogError("Renderer is missing!");
    }

    void Update()
    {
        if (rb == null) return;

        // Movement
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(moveX, 0f, moveZ);
        rb.AddForce(move * moveSpeed);

        // Jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

            if (jumpEffect != null)
                jumpEffect.Play();

            if (jumpSound != null)
                jumpSound.Play();
        }

        // Change color on mouse click
        if (Input.GetMouseButtonDown(0) && rend != null)
        {
            rend.material.color = new Color(Random.value, Random.value, Random.value);
        }

        // Change color automatically every 3 seconds
        colorTimer += Time.deltaTime;
        if (colorTimer >= 3f && rend != null)
        {
            rend.material.color = new Color(Random.value, Random.value, Random.value);
            colorTimer = 0f;
        }
    }
}
