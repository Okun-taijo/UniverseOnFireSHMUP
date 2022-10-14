using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace StillTrying
{
    public class PlayerHealth : ObjectHealth
    {
        [SerializeField]
        private UnityEvent<int> _onHealthChange;

        protected override void Start()
        {
            base.Start();
            _onHealthChange.Invoke(GetCurrentHealth());
        }
        public override void TakeDamage(int damage)
        {
            base.TakeDamage(damage);
           

        }
      
    }
}
