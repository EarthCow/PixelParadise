using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDamage : MonoBehaviour
{
    public int damage;
    public PlayerHealth playerHealth;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            playerHealth.TakeDamage(damage);
            
            collision.rigidbody.velocity = new Vector2(Mathf.Sign(collision.rigidbody.rotation) * 50, 10);
            // collision.rigidbody.AddForce();
        }
    }
}
