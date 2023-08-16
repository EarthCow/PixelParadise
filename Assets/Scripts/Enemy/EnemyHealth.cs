using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    public int health = 100;

    public Animator animator;

    [SerializeField] FloatingHealthBar healthBar;

    private void Awake()
    {
        healthBar = GetComponentInChildren<FloatingHealthBar>();
    }

    private int maxHealth = 100;

    private void Start()
    {
        health = maxHealth;
        healthBar.UpdateHealthBar(health, maxHealth);
    }

    public void TakeDamage (int damage)
    {
        health -= damage;
        healthBar.UpdateHealthBar(health, maxHealth);
        if (health <= 0)
        {
            Die();
        }
    }

    void Die ()
    {
        animator.SetTrigger("Death");
    }

   
}
