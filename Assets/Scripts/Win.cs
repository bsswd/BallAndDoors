// When player leaves room - win

using UnityEngine;

public class Win : MonoBehaviour
{
    [SerializeField] GameObject _winMessage;
    [SerializeField] GameObject _looseMessage;
    [SerializeField] GameObject _restartButton;

  
    void OnTriggerEnter(Collider other)
    {
        _winMessage.SetActive(true);
        _restartButton.SetActive(true);       
    }
}