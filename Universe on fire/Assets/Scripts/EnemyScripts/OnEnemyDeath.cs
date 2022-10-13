using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StillTrying
{
    public class OnEnemyDeath : MonoBehaviour
    {
        public virtual void Activate()
        {
            Destroy(gameObject, 0.2f);
        }
    }
}
