using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    private float rangeZ = 2.1f;
    private float rangeX = 6.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Keep player within bounds
        if (transform.position.z > rangeZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, rangeZ);
        }
        if (transform.position.z < -rangeZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -rangeZ);
        }

        // Destroy objects out of bounds
        if (transform.position.x > rangeX)
        {
            Destroy(gameObject);
        }
        if (transform.position.x < -rangeX)
        {
            Destroy(gameObject);
        }
    }
}
