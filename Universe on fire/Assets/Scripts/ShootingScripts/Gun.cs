using StillTrying;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Gun : MonoBehaviour
{
    [SerializeField] protected GameObject _bulletPrefab;

   
  
    protected abstract void Shoot();
    
    
}
