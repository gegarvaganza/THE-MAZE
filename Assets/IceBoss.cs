using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBoss : MonoBehaviour
{
    public int HP = 100;
    public Animator animator;

    public void TakeDamage(int damageAmount)
    {
        HP -= damageAmount;
        if (HP <= 0)
        {
            animator.SetTrigger("IsDie2");
            GetComponent<Collider>().enabled = false;
        }
        else
        {
            animator.SetTrigger("IsTakeDamage2");
        }
    }
}
