using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager Instance;
    private GameInputs _gameInputs;

    private void Awake()
    {
        if(!Instance)
        {
            Instance = this;
            _gameInputs = new GameInputs();
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnEnable()
    {
        _gameInputs?.Enable();
    }

    private void OnDisable()
    {
        _gameInputs?.Disable();
    }

    public GameInputs GameInputs => _gameInputs;
}
