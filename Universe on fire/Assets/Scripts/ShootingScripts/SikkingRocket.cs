using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StillTrying
{
    public class SikkingRocket : FirstBulletType
    {
       
        protected override void FixedUpdate()
        {
            transform.position = Vector2.MoveTowards(transform.position, GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().position, _bulletSpeed * Time.fixedDeltaTime);
        }
            
    }
}
