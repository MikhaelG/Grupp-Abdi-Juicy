using UnityEngine;
//Mikhael
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
        float movementX = Input.GetAxis("Horizontal"); //Horizontal axis
        float movementY = Input.GetAxis("Vertical");   //Vertical axis
        transform.position += new Vector3(movementX, movementY, 0) * Time.deltaTime * MovementSpeed; //hastigheten
    }
}
