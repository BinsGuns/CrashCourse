using UnityEngine;
using UnityEngine.InputSystem;

public class CarController : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 100f;
   
    
    private Vector2 movementInput;

    void Update()
    {
        // Get movement input
        Vector3 movement = new Vector3(0, 0, movementInput.y) * speed * Time.deltaTime;
        transform.Translate(movement, Space.Self);

        // Get rotation input
        float rotationInput = movementInput.x;
        float rotation = rotationInput * rotationSpeed * Time.deltaTime;

        // Apply rotation
        transform.Rotate(Vector3.up, rotation);
    }

    public void OnMove(InputValue value)
    {
        movementInput = value.Get<Vector2>();
    }
}
