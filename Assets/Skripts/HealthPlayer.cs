using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthPlayer : MonoBehaviour
{
    [SerializeField] private float _playerHitPoints;
    [SerializeField] private float _change = 10;

    private float _maxHealth = 100;
    private float _minHealth = 0;
    public float PlayerHitPoints => _playerHitPoints;
    public float MaxHealth => _maxHealth;
    public UnityAction ChangingHealth;

    public void TakeDamage()
    {
        if (_playerHitPoints > _minHealth)
        {
            _playerHitPoints -= _change;
        }

        ChangingHealth?.Invoke();
    }

    public void TakeHeal()
    {
        if (_playerHitPoints < _maxHealth)
        {
            _playerHitPoints += _change;
        }

        ChangingHealth?.Invoke();
    }
}
