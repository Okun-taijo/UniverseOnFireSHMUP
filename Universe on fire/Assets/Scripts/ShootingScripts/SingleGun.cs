using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StillTrying
{
    public class SingleGun : Gun
    {
        [SerializeField] protected Transform _bulletStartPoint;
        protected override void Shoot()
        {
              var bullet = Instantiate(_bulletPrefab, _bulletStartPoint.position, _bulletStartPoint.rotation);                 
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
