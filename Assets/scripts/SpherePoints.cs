using UnityEngine;

public class SpherePoints : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.name == "emmer")
        {
            keepScore.Score += 100;
        }

    }
    
}