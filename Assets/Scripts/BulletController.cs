using UnityEngine;

public class bulletController : MonoBehaviour
{
    private Rigidbody rb;
    public float velocity;
    
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.linearVelocity = new Vector3(0, velocity, 0);
        
    }
  
}
