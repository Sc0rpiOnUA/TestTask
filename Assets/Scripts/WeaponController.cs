using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    /*[SerializeField] Transform _gunSpownPoint;
    [SerializeField] GameObject _weaponPrefab;*/

    [SerializeField] Transform _bulletSpownPoint;
    [SerializeField] GameObject _bulletPrefab;
    [SerializeField] Camera _mainCamera;
    [SerializeField] float _shootForce;
    //[SerializeField] KeyCode _keyCode;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(_weaponPrefab, _gunSpownPoint);
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Instantiate(_bulletPrefab, _bulletSpownPoint);
            Shot();
        };
        
    }

    private void Shot()
    {
        Ray ray = _mainCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;

        Vector3 targetPoint = ray.GetPoint(175);
        if (Physics.Raycast(ray, out hit))
        {
            targetPoint = hit.point;
        }
        /*else
        {
            targetPoint = 
        }*/

        Vector3 direction = targetPoint - _bulletSpownPoint.position;

        GameObject currentBullet = Instantiate(_bulletPrefab, _bulletSpownPoint.position, Quaternion.identity);
        currentBullet.transform.forward = direction.normalized;
        currentBullet.GetComponent<Rigidbody>().AddForce(direction * _shootForce, ForceMode.Impulse);
    }
}
