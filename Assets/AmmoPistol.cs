using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPistol : MonoBehaviour
{
    public int damageAmount = 20;
    private void Start()
    {
        Destroy(gameObject, 10);
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(transform.GetComponent<Rigidbody>());
        if(other.tag == "IceMonster")
        {
            transform.parent = other.transform;
            other.GetComponent<IceMonster>().TakeDamage(damageAmount);
        }
    }
}
