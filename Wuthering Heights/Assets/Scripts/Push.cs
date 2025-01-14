using UnityEngine;

public class Push : MonoBehaviour
{
    
    private Rigidbody rb;
    [SerializeField]
    private float forceAmount = 10f;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ApplyImpulse();
        }
    }
    
    void ApplyImpulse()
    {
        Vector3 direction = transform.forward;  
        rb.AddForce(direction * forceAmount, ForceMode.Impulse);
    }
}
