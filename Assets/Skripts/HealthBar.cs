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

    private float _speedChange = 0.5f;

    private void Start()
    {
        _healthBar.value = _healthPlayer.PlayerHitPoints;
    }

    public void OnChangingHealth()
    {
        _healthBar.DOValue(_healthPlayer.PlayerHitPoints, _speedChange);
    }
}
