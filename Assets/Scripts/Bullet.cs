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
        GameObject targetGameObject = collision.collider.gameObject;
        Debug.Log("Collided with " + targetGameObject);
        if (targetGameObject.CompareTag("Enemy"))
        {
            //enemylife--
            targetGameObject.GetComponent<HealthHandler>().TakeDamage(1);

            Destroy(gameObject);
        }
        else 
            Destroy(gameObject, 0.5f);
    }
}
