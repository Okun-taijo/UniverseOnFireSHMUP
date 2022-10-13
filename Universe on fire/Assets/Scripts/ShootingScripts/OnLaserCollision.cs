using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StillTrying
{
    public class OnLaserCollision : MonoBehaviour
    {
        // Start is called before the first frame update
        [SerializeField] private int _damage;
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.TryGetComponent(out IDamageble damageble))
                damageble.TakeDamage(_damage);
        }
    }
}
