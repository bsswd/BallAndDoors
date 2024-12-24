// Controls player with WASD or arrows

using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] int _acceleration;
    public Transform orientation;

    Rigidbody rigidbodyPlayer;

    float _horizontalInput;
    float _verticalInput;
    
    Vector3 _moveDirectionX;
    Vector3 _moveDirectionY;

    void Start()
    {
        rigidbodyPlayer = GetComponent<Rigidbody>();
    }
    
    void Update()
    {   
        PlayerInput();
        PlayerMovement();
    }

    public void PlayerInput()
    {
        _verticalInput = Input.GetAxis("Vertical");
        _horizontalInput = Input.GetAxis("Horizontal");
    }

    public void PlayerMovement()
    {
        _moveDirectionX = orientation.forward * _verticalInput;
        _moveDirectionY = orientation.right * _horizontalInput;

        rigidbodyPlayer.AddForce((_moveDirectionX + _moveDirectionY).normalized * _acceleration, ForceMode.Force);
    }
}