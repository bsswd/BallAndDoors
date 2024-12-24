using UnityEngine;

public class Loose : MonoBehaviour
{
    [SerializeField] GameObject _looseMessage;
    [SerializeField] GameObject _restartButton;
    [SerializeField] Collider _player;
  
    void OnTriggerEnter(Collider other)
    {
        if (other !=_player)
        {
            _looseMessage.SetActive(true);
            _restartButton.SetActive(true);
        }
    }
}