using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 10f;
    private Rigidbody2D _rb;
    private Vector2 _moveVelocity;
    Gun[] gunsArray;
    private bool _shooting;
   
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        gunsArray = transform.GetComponentsInChildren<Gun>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        _moveVelocity = moveInput.normalized * _moveSpeed;

        _shooting = Input.GetMouseButtonDown(0);
        if(_shooting)
        {
            foreach(Gun gun in gunsArray)
            {
                gun.Shoot();
            }
        }
    }

    void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + _moveVelocity * Time.fixedDeltaTime);
    }


}



