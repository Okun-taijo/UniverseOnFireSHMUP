using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StillTrying
{
    [RequireComponent(typeof(DestroyEffectGenerator))]
    public class DestroyEffectsSpawner : MonoBehaviour
    {
        private DestroyEffectGenerator _destroyGenerator;
        
        private void Awake()
        {
            _destroyGenerator = GetComponent<DestroyEffectGenerator>();
        }

        private void OnEnable()
        {
            DestroyedEvent.OnEffectActivated += DestroyedEvent_OnEffectActiveted;
        }
        private void OnDisable()
        {
            DestroyedEvent.OnEffectActivated -= DestroyedEvent_OnEffectActiveted;
        }
        private void DestroyedEvent_OnEffectActiveted(Transform obj)
        {
            GameObject effect = _destroyGenerator.GetFreeObject();
            effect.transform.position = obj.position;
            effect.SetActive(true);
        }
    }

  
}
