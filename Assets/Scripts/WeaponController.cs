using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [SerializeField] Transform _gunSpownPoint;
    [SerializeField] GameObject _weaponPrefab;
    [SerializeField] Transform _bulletSpownPoint;
    [SerializeField] GameObject _bulletPrefab;
    [SerializeField] KeyCode _keyCode;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(_weaponPrefab, _gunSpownPoint);
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(_bulletPrefab, _bulletSpownPoint);
        };
        
    }

    public void Shot()
    {
        Instantiate(_bulletPrefab, _bulletSpownPoint);
    }
}
