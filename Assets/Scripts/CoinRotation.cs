using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    public float rotationSpeed = 50f; // Dönme hýzý
    public float movementDistance = 0.2f; // Hareket mesafesi
    public float movementSpeed = 1f; // Hareket hýzý

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
        // Nesneyi y ekseninde döndür
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }

    void MoveObject()
    {
        // Yukarý ve aþaðý hareket
        float newY = startPosition.y + Mathf.Sin(Time.time * movementSpeed) * movementDistance;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
