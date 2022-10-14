using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace StillTrying
{
    public class HealthBar : MonoBehaviour
    {
       [SerializeField] private Slider _slider;
       [SerializeField] private PlayerHealth _health;

        private void Start()
        {
            SetMaxHealth(_health._maxHealth);
        }
        private void Update()
        {
            SetHealth(_health._currentHealth);
        }
        private void SetMaxHealth(int health)
        {
            _slider.maxValue = health;
            _slider.value = health;
        }
        private void SetHealth(int health)
        {
            _slider.value = health;
        }
    }
}
