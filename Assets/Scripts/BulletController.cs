using UnityEngine;

public class bulletController : MonoBehaviour
{
    private Rigidbody rb;
    public float velocity;
    public Vector3 direction;
    
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.linearVelocity = direction*velocity;
        
    }
  
}
