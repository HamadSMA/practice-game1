using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    private float rangeZ = 2.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > rangeZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, rangeZ);
        }
        if (transform.position.z < -rangeZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -rangeZ);
        }
    }
}
