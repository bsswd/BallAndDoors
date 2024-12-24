using UnityEngine;

public class UIVisibility : MonoBehaviour
{
    [SerializeField] GameObject _looseMessage;
    [SerializeField] GameObject _winMessage;
    [SerializeField] GameObject _restartButton;

    void Start()
    {
        // Hide UI elements
        _looseMessage.SetActive(false);
        _winMessage.SetActive(false);
        _restartButton.SetActive(false);  
    }
}