using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using UniRx.Triggers;
using UniRx;
using System;
using System.Linq;

public class PlayerTest : MonoBehaviour
{
    [SerializeField]
    PlayerData _playerData;

    [SerializeField]
    int _damage;

    [Inject]
    IInputProbider _inputProvider;

    public void SetInputProvider(IInputProbider input) => _inputProvider = input;

    void Touch()
    {
        print("パーフェクト!");
    }
    private void Start()
    {
    }
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out IPerfect perfect))
        {
            perfect.Perfect();
            if (_inputProvider.IsTouch())
            {
                Touch();
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out IDeathZone death))
        {
            death.Death();
            Destroy(gameObject);
            _playerData.Damage(_damage);
        }
    }
}
