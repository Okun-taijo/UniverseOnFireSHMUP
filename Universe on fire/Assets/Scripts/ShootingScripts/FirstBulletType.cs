using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstBulletType : MonoBehaviour
{
    [SerializeField] protected float _bulletSpeed = 20f;
    [SerializeField] protected float _lifeTime = 1f;



    // Start is called before the first frame update
    protected void Start()
    {
        Destroy(gameObject, _lifeTime);
    }

    // Update is called once per frame
    protected virtual void FixedUpdate()
    {
        transform.position += transform.right * _bulletSpeed * Time.fixedDeltaTime;
       
        if (transform.position.x >= -30)
        {
             Destroy(gameObject); 
        }
    }
   
 
}
