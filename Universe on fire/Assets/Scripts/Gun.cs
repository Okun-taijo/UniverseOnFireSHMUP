using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private FirstBulletType _firstBullet;
    [SerializeField] private Transform _bulletStartPoint;
 
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        var bullet = Instantiate(_firstBullet, _bulletStartPoint.position, _bulletStartPoint.rotation);
    }
}
