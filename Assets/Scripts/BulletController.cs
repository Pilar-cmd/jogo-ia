using UnityEngine;

public class bulletController : MonoBehaviour
{
    private Rigidbody rb;
    public float velocity;
    
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.linearVelocity = new Vector3(velocity, 0, 0);
        
    }
  
}
