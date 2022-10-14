using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StillTrying
{
    public class MultiGunActivator : PowerUp
    {
        [SerializeField] private GameObject _gun;
        protected override void Activate(GameObject player)
        {
            _gun.SetActive(true);
        }
    }
}
