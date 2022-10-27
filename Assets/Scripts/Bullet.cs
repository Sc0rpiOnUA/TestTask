using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletLife = 3;
    void Awake()
    {
        Destroy(gameObject, bulletLife);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            //enemylife--
            Destroy(gameObject);
        }
        else 
            Destroy(gameObject, 2);
    }
}
