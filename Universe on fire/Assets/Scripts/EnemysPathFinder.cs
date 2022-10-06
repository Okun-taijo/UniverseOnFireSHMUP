using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StillTrying
{
    public class EnemysPathFinder : MonoBehaviour
    {
        [SerializeField]private List<Transform> _pathPoints = new List<Transform>();

        private void Awake()
        {
            Destroy(gameObject);
        }
        public void AddPoint(Transform point)
        {
            _pathPoints.Add(point);
        }
        
       public List<Vector2> GetPathPosition()
        {
            List<Vector2> points = new List<Vector2>();

            foreach(var item in _pathPoints)
            {
                points.Add(item.position);
            }
            return points;
        }
   
    }
}
