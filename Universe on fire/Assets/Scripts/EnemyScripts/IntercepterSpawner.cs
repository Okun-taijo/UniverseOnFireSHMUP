using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StillTrying
{
    public class IntercepterSpawner : EnemySpawner
    {
        

        // Update is called once per frame
        protected override void Update()
        {
           
            if (_timeToSpawn < Time.time)
            {
                _timeToSpawn = Time.time + _spawnRate;
                Instantiate(_spawnedFirstEnemyType,transform.position, Quaternion.identity);
                Instantiate(_spawnedSecondEnemyType, transform.position, Quaternion.identity);
            }
        }

      
    }
}
