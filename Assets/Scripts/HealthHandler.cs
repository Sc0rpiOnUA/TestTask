using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthHandler : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField][Range(0,5)] private int _damage;
    public UnityEvent OnDead;
    public UnityEvent OnTakeDamage;
    public UnityEvent OnGiveDamage;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void TakeDamage(int damage)
    {
        Debug.Log(_health);
        _health -= damage;
        
        OnTakeDamage.Invoke();
        if (_health <= 0)
        {
            anim.SetBool("Dead", true);

            //OnDead.Invoke();
            Destroy(gameObject);
        }
    }

    public int GiveDamage()
    {
        OnGiveDamage.Invoke();
        return _damage;
    }
}
