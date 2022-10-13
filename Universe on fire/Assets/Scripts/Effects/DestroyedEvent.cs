using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StillTrying
{
    public class DestroyedEvent : MonoBehaviour
    {
        public static event Action<Transform> OnEffectActivated;

        public void Activate()
        {
            OnEffectActivated?.Invoke(transform);
        }

    }
}
