using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StillTrying
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private GameObject _spawnedFirstEnemyType;
        [SerializeField] private GameObject _spawnedSecondEnemyType;
        [SerializeField] private float _spawnRate=2f;
        private float _timeToSpawn = 0f;
        private float _randomCoordinate;
        private Vector2 _randomSpawnPosition;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            if (_timeToSpawn < Time.time)
            {
                _timeToSpawn = Time.time + _spawnRate;
                _randomCoordinate = Random.Range(-29f, 5.2f);
                _randomSpawnPosition = new Vector2(_randomCoordinate, transform.position.y);
                Instantiate(_spawnedFirstEnemyType, _randomSpawnPosition, Quaternion.identity);
                Instantiate(_spawnedSecondEnemyType, _randomSpawnPosition, Quaternion.identity);
            }
        }
    }
}
