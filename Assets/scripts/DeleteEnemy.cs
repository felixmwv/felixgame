using UnityEngine;

public class DestroyingSphere : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        if (other.CompareTag("floor"))
        {
            Destroy(gameObject);
        }
    }
}
