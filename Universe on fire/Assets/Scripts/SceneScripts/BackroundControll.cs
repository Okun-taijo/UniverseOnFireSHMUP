using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackroundControll : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _backgroundRenderer;
    private float _screenScrollSpeed =1f;
    private float _positionMinX;
    private Vector2 _restartPosition;

    private void Awake()
    {
        _restartPosition = transform.position;
        _positionMinX = _backgroundRenderer.bounds.size.x * 4 - _restartPosition.x;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * _screenScrollSpeed * Time.deltaTime);
        if (transform.position.x <= -_positionMinX)
        {
            transform.position = _restartPosition;
        }
    }
}
