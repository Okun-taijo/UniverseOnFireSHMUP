using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StillTrying
{
    public class Shield : MonoBehaviour
    {
        [SerializeField] private CircleCollider2D _collider;
        [SerializeField] private SpriteRenderer _spriteRender;
        private float _currentTime;
        private bool _isEnabled;
        private Transform _target;
        public bool IsEnabled => _isEnabled;
        public void Activate(float _lifeTime, Transform target)
        {
            _currentTime += _lifeTime;
            if (_isEnabled == false)
            {
                 _target=target; 
                transform.position = target.position;
                ShowShield(true);
                StartCoroutine(Timer());
            }
        }

   

        private void ShowShield(bool value)
        {
            _collider.enabled = value;
            _spriteRender.enabled = value;
            _isEnabled = value;
        }
        private IEnumerator Timer()
        {
            float waitToStep = 0.5f;
            WaitForSeconds wait = new WaitForSeconds(waitToStep);
            while (_currentTime > 0)
            {
                _currentTime -= waitToStep;
                yield return wait;
            }
            _currentTime = 0;
            ShowShield(false);
            transform.SetParent(null);
        }
        private void Update()
        {
            if (_isEnabled)
                transform.position = _target.position;
        }
    }
}
