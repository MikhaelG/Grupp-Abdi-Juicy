using UnityEngine;

public class Character2DController : MonoBehaviour
{
    public float MovementSpeed = 1;

    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float movementX = Input.GetAxis("Horizontal");
        float movementY = Input.GetAxis("Vertical");
        transform.position += new Vector3(movementX, movementY, 0) * Time.deltaTime * MovementSpeed;
    }
}
