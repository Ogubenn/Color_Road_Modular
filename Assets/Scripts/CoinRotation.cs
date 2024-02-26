using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    public float rotationSpeed = 50f; // D�nme h�z�
    public float movementDistance = 0.2f; // Hareket mesafesi
    public float movementSpeed = 1f; // Hareket h�z�

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        RotateObject();
        MoveObject();
    }

    void RotateObject()
    {
        // Nesneyi y ekseninde d�nd�r
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }

    void MoveObject()
    {
        // Yukar� ve a�a�� hareket
        float newY = startPosition.y + Mathf.Sin(Time.time * movementSpeed) * movementDistance;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
