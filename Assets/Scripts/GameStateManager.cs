using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class GameStateManager : MonoBehaviour
{
    //Singleton pattern
    public static GameStateManager Instance;

    private bool _isDead = false;
    private GameObject _player;

    public void Awake()
    {
        if (Instance != null)
        { 
            Destroy(Instance.gameObject);
            return;
        }
        Instance = this;
    }

    private void Start()
    {
        _player = FindObjectOfType<PlayerInput>().gameObject;
    }

    public void Die()
    {
        Destroy(_player.gameObject);
        _isDead = true;
    }
}