using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Transform cameraTransform;
    [SerializeField] float mouseSensitivity = 3f;
    [SerializeField] float movementSpeed = 3f;
    [SerializeField] float playerMass = 1f;
    private Vector2 _look;
    private CharacterController _characterController;
    private Vector3 _velocity;
    
    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    
    private void Update()
    {
        UpdateLook();
        UpdateMovement();
        UpdateGravity();
    }

    private void UpdateLook()
    {
        _look.x += Input.GetAxis("Mouse X") * mouseSensitivity;
        _look.y += Input.GetAxis("Mouse Y") * mouseSensitivity;
        _look.y = Mathf.Clamp(_look.y, -40f, 40f);
        cameraTransform.localRotation = Quaternion.Euler(-_look.y, 0, 0);
        transform.localRotation = Quaternion.Euler(0, _look.x, 0);
    }

    private void UpdateMovement()
    {
        var x = Input.GetAxis("Horizontal");
        var y = Input.GetAxis("Vertical");
        var input = new Vector3();
        input += transform.forward * y;
        input += transform.right * x;
        input = input.normalized;
        
        //transform.Translate(input * movementSpeed * Time.deltaTime, Space.World);
        _characterController.Move((input * movementSpeed + _velocity)* Time.deltaTime);
    }

    private void UpdateGravity()
    {
        var gravity = Physics.gravity * playerMass * Time.deltaTime;
        _velocity.y = _characterController.isGrounded ? -1f : _velocity.y + gravity.y;

    }
}
