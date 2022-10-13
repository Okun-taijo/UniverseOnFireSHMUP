using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StillTrying
{
    public class EnemyGun : Gun
    {
        [SerializeField] private float _shootCooldown;
        [SerializeField] private float _startShootCooldown;
        [SerializeField] private List<Transform> _bulletsStartPosition;
        protected override void Shoot()
        {
            foreach (var item in _bulletsStartPosition)
            {
                var bullet = Instantiate(_bulletPrefab, item.position, item.rotation);
                if (bullet = null)
                    Debug.Log("null");
                else
                {
                    bullet = Instantiate(_bulletPrefab, item.position, item.rotation);
                    bullet.SetActive(true);
                }
            }
        }
        void Update()
        {
            if (_shootCooldown <= 0)
            {
                Shoot();
                _shootCooldown = _startShootCooldown;
            }
            else
            {
                _shootCooldown -= Time.deltaTime;
            }
           
        }
    }
}
