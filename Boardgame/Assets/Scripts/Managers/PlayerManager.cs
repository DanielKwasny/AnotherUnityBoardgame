using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : Singleton<PlayerManager>
{

    [SerializeField]
    PlayerController[] _playerControllers;

    public PlayerController[] PlayerControllers => _playerControllers;

    int _currentPlayerIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetCurrentPlayer(int index)
    {
        _currentPlayerIndex = index;
    }

    public PlayerController GetCurrentPlayerController()
    {
        return _playerControllers[_currentPlayerIndex];
    }
}
