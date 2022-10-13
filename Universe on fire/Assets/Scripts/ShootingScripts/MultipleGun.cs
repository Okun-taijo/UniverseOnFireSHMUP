using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StillTrying
{
    public class MultipleGun : Gun
    {
        [SerializeField] private List<Transform> _bulletsStartPosition;
        protected override void Shoot()
        {
           foreach(var item in _bulletsStartPosition)
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
            if (Input.GetMouseButtonDown(0))
            {
                Shoot();
            }
        }
    }
}
