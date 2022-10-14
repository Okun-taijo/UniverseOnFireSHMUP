using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StillTrying
{
    [RequireComponent(typeof(Collider2D))]
    public class BulletCollision : MonoBehaviour
    {
        [SerializeField] private int _damage;
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.TryGetComponent(out IDamageble damageble))
                damageble.TakeDamage(_damage);
            Destroy(gameObject);
        }

    }
}
