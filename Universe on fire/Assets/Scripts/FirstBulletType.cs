using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstBulletType : MonoBehaviour
{
    [SerializeField] private float _bulletSpeed = 20f;
    [SerializeField] private float _lifeTime = 1f;
   
 
    
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, _lifeTime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += transform.right * _bulletSpeed * Time.fixedDeltaTime;
   
    }
   
 
}
