using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace StillTrying
{
    public class ScoreCollector : MonoBehaviour
    {
        [SerializeField] private UnityEvent<int> ChangeScore;
        private static int _collectedScore;
        private void Awake()
        {
            ChangeScore.Invoke(_collectedScore);
        }
        private void OnEnable()
        {
            ScoreOfObject.OnScoreChange += ScoreOfObject_OnScoreChange;
        }
        private void OnDisable()
        {
            ScoreOfObject.OnScoreChange -= ScoreOfObject_OnScoreChange;
        }

        private void ScoreOfObject_OnScoreChange(int value)
        {
            _collectedScore += value;
            ChangeScore.Invoke(_collectedScore);
        }
    }
}
