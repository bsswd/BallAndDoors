// Visualizes press/unpress button and simulate door opens

using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] GameObject _targetDoor;

    void OnTriggerEnter(Collider other)
    {
        transform.localPosition -= new Vector3(0, 0.2f, 0);
        transform.localScale -= new Vector3(0.1f,0.1f,0.1f);

        _targetDoor.SetActive(false);  
    }

    void OnTriggerExit(Collider other)
    {
        transform.localPosition += new Vector3(0, 0.2f, 0);
        transform.localScale += new Vector3(0.1f,0.1f,0.1f);

        _targetDoor.SetActive(true);           
    }
}