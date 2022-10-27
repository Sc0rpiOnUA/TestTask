using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ZombieAI : MonoBehaviour
{
    [SerializeField] [Range(0,3)] private float _speed;
    public float _followRange;
    public float _attackRange;
    private Collider[] triggerRange;
    private Animator anim;
    private HealthHandler healthHandler;
  

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        healthHandler = GetComponent<HealthHandler>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if ((FindPlayerAtRange(_followRange) != null)&&(FindPlayerAtRange(_attackRange)==null))
        {
            anim.SetFloat("WalkSpeed",_speed*25);
            anim.SetBool("Walk",true);
            transform.position = Vector3.MoveTowards(transform.position, FindPlayerAtRange(_followRange).transform.position,_speed);
            transform.LookAt(FindPlayerAtRange(_followRange).transform);
        }
        else if (FindPlayerAtRange(_attackRange) != null)
        {
            anim.SetBool("Attack", true);
            anim.SetBool("Walk", false);

            
        }
        else
        {
            anim.SetBool("Attack", false);
            anim.SetBool("Walk", false);
        }
       
    }
    public GameObject FindPlayerAtRange(float range)
    {
        triggerRange = Physics.OverlapSphere(transform.position, range);

        foreach (Collider collider in triggerRange)
        {
            if (collider.transform.tag == "Player")
            {
                return collider.gameObject;
            }
        }
        return null;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, _followRange);
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position,_attackRange);
    }

}
