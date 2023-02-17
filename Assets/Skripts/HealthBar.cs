using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;
using static UnityEditor.Experimental.GraphView.GraphView;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _healthBar;
    [SerializeField] private HealthPlayer _healthPlayer;
    
    private Coroutine _coroutine;
    private float _speedChange = 0.5f;

    private void Start()
    {
        _healthBar.value = _healthPlayer.PlayerHitPoints;
    }

    public void OnChangingHealth()
    {
        if (_healthBar.value != _healthPlayer.PlayerHitPoints)
        {
            if (_coroutine != null)
            {
                StopCoroutine(_coroutine);
            }

            _coroutine = StartCoroutine(ChangingHealthValue());
        }
    }

    private IEnumerator ChangingHealthValue()
    {
        _healthBar.DOValue(_healthPlayer.PlayerHitPoints, _speedChange);
        yield return null;
    }
}
