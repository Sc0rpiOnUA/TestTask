using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    /*[SerializeField] Transform _gunSpownPoint;
    [SerializeField] GameObject _weaponPrefab;*/

    [SerializeField] Transform _bulletSpawnPoint;
    [SerializeField] GameObject _bulletPrefab;
    [SerializeField] Camera _mainCamera;
    [SerializeField] float _bulletSpeed;
    //[SerializeField] KeyCode _keyCode;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(_weaponPrefab, _gunSpownPoint);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
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

        Vector3 direction = targetPoint - _bulletSpawnPoint.position;

        GameObject currentBullet = Instantiate(_bulletPrefab, _bulletSpawnPoint.position, _bulletSpawnPoint.rotation);

        Vector3 force = new Vector3(0, 0, _bulletSpeed);
        currentBullet.transform.forward = direction.normalized;
        currentBullet.GetComponent<Rigidbody>().AddRelativeForce(force, ForceMode.VelocityChange);

        
        //currentBullet.GetComponent<Rigidbody>().AddForce(direction * _bulletSpeed, ForceMode.VelocityChange);
    }
}
