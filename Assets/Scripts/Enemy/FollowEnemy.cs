using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowEnemy : MonoBehaviour
{
    public float speed;
    public Transform target;
    public float minimumDistance;
    public Animator animator;

    float horizontalMove = 0f;

    private void Update() 
    {

        if (Vector2.Distance(transform.position, target.position) > minimumDistance)
        {
            horizontalMove = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, target.position, horizontalMove);
        } else

        {
            horizontalMove = 0f;
            // ATTACK CODE


        }

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
    }
   
}
