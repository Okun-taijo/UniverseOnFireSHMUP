using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StillTrying
{
    public class BossMove : EnemyMovement
    {
        protected override void FixedUpdate()
        {
            _rigidbody2D.MovePosition(Vector3.MoveTowards(transform.position, _path.Points[_index], _movementSpeed * Time.fixedDeltaTime));

            if (Vector3.Distance(transform.position, _path.Points[_index]) < 0.1f)
            {
                if (_index < _path.Points.Count - 1)
                {
                    _index++;
                }
                else
                    _index = 0;
            }
        }
    }
}
