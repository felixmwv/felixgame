using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;

    private Rigidbody body;
    void Start()
    {
        body = GetComponent<Rigidbody>();

        transform.position = Vector3.zero;
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.A)) {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
    }
}