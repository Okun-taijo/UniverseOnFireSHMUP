using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StillTrying
{
    public class LevelName : MonoBehaviour
    {
        private const string _key = "SceneName";

        public void SetName()
        {
            PlayerPrefs.SetString(_key, name);
            PlayerPrefs.Save();
        }
        public string GetName()
        {
            if (PlayerPrefs.HasKey(_key))
            {
                return PlayerPrefs.GetString(_key);
            }
            return null;
        }
    }
}
