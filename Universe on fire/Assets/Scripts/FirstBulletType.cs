using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstBulletType : MonoBehaviour
{
    [SerializeField] private float _bulletSpeed = 20f;
    public Vector2 Direction = new Vector2(1,0);
    private Vector2 _velocity;
    public SpriteRenderer BulletSprite;
 
    
    // Start is called before the first frame update
    void Start()
    {
        BulletSprite = GetComponent<SpriteRenderer>();
        Destroy(gameObject, 1);
    }

    // Update is called once per frame
    void Update()
    {
        _velocity = Direction * _bulletSpeed;
   
    }
    private void FixedUpdate()
    {
        Vector2 position = transform.position;
        position += _velocity * Time.fixedDeltaTime;
        transform.position = position;
    }
 
}
