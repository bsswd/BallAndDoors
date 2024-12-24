using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] int _acceleration;
    public Rigidbody rigidbodyPlayer;
    
    void Update()
    {
        var direction = new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical"));
        rigidbodyPlayer.AddForce(direction*_acceleration);
    }
}