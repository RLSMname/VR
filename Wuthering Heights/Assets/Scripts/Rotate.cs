using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField]
    float rotationSpeed = 30f;

    void Update()
    {
        //transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.World);
    }
}
