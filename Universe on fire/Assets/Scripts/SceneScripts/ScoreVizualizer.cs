using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace StillTrying
{
    public class ScoreVizualizer : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _scoreText;

        public void VisualValue(int value)
        {
            _scoreText.text = value.ToString();
        }
    }
}
