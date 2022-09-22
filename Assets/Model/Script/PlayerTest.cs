using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTest : MonoBehaviour
{
    [SerializeField]
    PlayerData _playerData;

    [SerializeField]
    int _damage;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out IDeathZone death))
        {
            _playerData.Damage(_damage);
        }
    }
}
