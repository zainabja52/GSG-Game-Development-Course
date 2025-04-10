using UnityEngine;

public class PopupController : MonoBehaviour
{
    private bool isOpen = false;
    private Vector3 closedScale;
    private Vector3 openScale;
    public float animationSpeed = 5f;

    void Start()
    {
        closedScale = transform.localScale;
        openScale = new Vector3(closedScale.x, closedScale.y * 2f, closedScale.z);
    }

    void Update()
    {
        if (Input.GetMouseButton(0)) // Left mouse held
        {
            isOpen = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            isOpen = false;
        }

        transform.localScale = Vector3.Lerp(transform.localScale, isOpen ? openScale : closedScale, Time.deltaTime * animationSpeed);
    }
}
