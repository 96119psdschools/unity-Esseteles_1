using UnityEngine;

public class Collectible : MonoBehaviour
{
    public GameObject onCollectEffect;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 1, 0);
        
    }  
    void OnTriggerEnter(Collider other) {


    if(other.CompareTag("Player")) {
        // Destroy the collectible
        Destroy(gameObject);
    
            // Instantiate the particle effect
        Instantiate(onCollectEffect, transform.position, transform.rotation);

    }
       

    }

}
