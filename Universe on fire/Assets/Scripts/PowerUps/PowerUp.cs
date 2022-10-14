using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace StillTrying
{
    [RequireComponent(typeof(CircleCollider2D))]
    public abstract class PowerUp : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private UnityEvent _activated; 
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.TryGetComponent(out PlayerShip playerShip))
            {
                Activate(playerShip.gameObject);
                _activated.Invoke();
                gameObject.SetActive(false);
            }
        }

        protected virtual void Activate(GameObject player)
        {

        }

        private void Update()
        {
            transform.Translate(Vector3.left * _speed * Time.deltaTime);
            if (transform.position.x < -47)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
