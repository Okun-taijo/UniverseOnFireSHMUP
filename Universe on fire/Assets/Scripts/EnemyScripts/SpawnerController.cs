using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StillTrying
{
    public class SpawnerController : MonoBehaviour
    {
        [SerializeField]private GameObject _intercepterSpawner;
       
        void Update()
        {
            if (transform.position.x <-26)
            {
                _intercepterSpawner.SetActive(true);
            }
        }
    }
}
