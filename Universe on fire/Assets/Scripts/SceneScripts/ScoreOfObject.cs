using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StillTrying
{
    public class ScoreOfObject : MonoBehaviour
    {
        public static event Action<int> OnScoreChange;
        [SerializeField] private int _score;

        public void Activate()
        {
            OnScoreChange?.Invoke(_score);
        }
    }
}
