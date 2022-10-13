using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StillTrying
{
    public class DestroyEffectGenerator : MonoBehaviour
    {
        private const int _count = 4;

        [SerializeField] private ParticleSystem _particlePrefab;

        List<GameObject> _effects = new List<GameObject>();

        private void Awake()
        {
            for(int i =0; i<_count; i++)
            {
                Create();
            }
        }

        private GameObject Create()
        {
            GameObject effect = Instantiate(_particlePrefab.gameObject, transform);
            _effects.Add(effect);

            return effect;
        }

        public GameObject GetFreeObject()
        {
            foreach(var item in _effects)
            {
                if (item.activeInHierarchy == false)
                {
                    return item;
                }
            }
            return Create();
        }
    }
}
