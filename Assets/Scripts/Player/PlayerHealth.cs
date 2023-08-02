using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100F;
    public float health;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

public void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            animator.SetTrigger("death");
        } else {
            animator.SetTrigger("hurt");
            
        }
    }
}
