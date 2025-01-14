using UnityEngine;

public class Launcher : MonoBehaviour
{
    [SerializeField]
    private GameObject projectile;
    [SerializeField]
    private float launchVelocity = 700f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject projectileInstance = Instantiate(projectile, transform.position,  
                transform.rotation);
            
            projectileInstance.GetComponent<Rigidbody>().AddForce(transform.forward * launchVelocity);
        }
        
    }
}
