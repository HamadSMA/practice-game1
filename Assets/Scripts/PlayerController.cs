using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float verticalInput;
    private bool leftClick;
    public GameObject bulletPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
    }

    // Update is called once per frame
    void Update()

    {
        verticalInput = Input.GetAxis("Mouse Y");
        transform.Translate(Vector3.up * verticalInput * speed * Time.deltaTime);

        leftClick = Input.GetMouseButtonDown(0);
        if (leftClick)
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
    }

}
