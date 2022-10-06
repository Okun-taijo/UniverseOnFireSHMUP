using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StillTrying
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class EnemyMovement : MonoBehaviour
    {
        [SerializeField] private const float _movementSpeed = 5f;
        [SerializeField] private Path _path;
        private int _index;
        private Rigidbody2D _rigidbody2D;

        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            _rigidbody2D.MovePosition(Vector3.MoveTowards(transform.position, _path.Points[_index], _movementSpeed * Time.fixedDeltaTime));
          
            if (Vector3.Distance(transform.position, _path.Points[_index]) < 0.1f)
            {
                if (_index < _path.Points.Count-1)
                {
                    _index++;
                }
                else
                    Destroy(gameObject);
            }
        }
    }
}
