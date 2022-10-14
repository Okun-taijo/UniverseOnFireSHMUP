using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StillTrying
{
    public class ShieldBonus : PowerUp
    {
        [SerializeField] private Shield _shieldPrefab;
        [SerializeField] private float _lifeTime = 2f;
        private static Shield _currentShield;

        private void ShieldCheck()
        {
            if (_currentShield == null)
                _currentShield = Instantiate(_shieldPrefab);   
        }

        protected override void Activate(GameObject player)
        {
            ShieldCheck();
            
           

            _currentShield.Activate(_lifeTime, player.transform);
        }
    }
}
