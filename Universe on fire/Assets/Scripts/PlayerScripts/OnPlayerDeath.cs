using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StillTrying
{
    public class OnPlayerDeath : OnEnemyDeath
    {
        public override void  Activate()
        {
            Destroy(gameObject);
        }
    }
}
