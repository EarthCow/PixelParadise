using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100F;
    public float health;
    public Animator animator;

    private bool isDead;

    public GameManagerScript gameManager;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

public void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0 && !isDead)
        {
            animator.SetTrigger("death");
            isDead = true;
            gameManager.gameOver();
        } else {
            animator.SetTrigger("hurt");
            
        }
    }
}
