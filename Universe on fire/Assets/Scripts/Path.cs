using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

namespace StillTrying
{
    [CreateAssetMenu(fileName="Path", menuName ="GameSO/Path")]
    public class Path : ScriptableObject
    {
        public List<Vector2> Points = new List<Vector2>();
#if UNITY_EDITOR
        [ContextMenu("Save path")]
        private void GetPoints()
        {
            var enemyPath = FindObjectOfType<EnemysPathFinder>();
            if(enemyPath != null)
            {
                Points = enemyPath.GetPathPosition();
                EditorUtility.SetDirty(this);
                EditorSceneManager.MarkSceneDirty(SceneManager.GetActiveScene());
            }
        }
        [ContextMenu("Load path")]
        private void SetPoints()
        {
            GameObject path = new GameObject("Path");
            EnemysPathFinder scenePath = path.AddComponent<EnemysPathFinder>();
            for(int i=0; i < Points.Count; i++)
            {
                GameObject point = new GameObject($"Point{i}");
                point.transform.SetParent(path.transform);
                point.transform.position = Points[i];
                scenePath.AddPoint(point.transform);
            }
        }
#endif
    }
}
