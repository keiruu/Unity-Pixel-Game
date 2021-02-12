using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   
   public float moveSpeed = 5f;

   public Rigidbody2D rb;

    public Animator animator;
    
    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"),0.0f);
       

    if (movement != Vector3.zero)
    {
         animator.SetFloat("Horizontal", movement.x);
         animator.SetFloat("Vertical", movement.y);
    }

     animator.SetFloat("Speed", movement.sqrMagnitude);
      transform.position = transform.position + movement * Time.deltaTime;
    }

}