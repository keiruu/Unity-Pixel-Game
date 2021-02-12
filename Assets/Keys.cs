using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keys : MonoBehaviour {

    [SerializeField]
    private GameObject pickUp;
    public Animator anim;
    private bool pickUpAllowed;

	// Use this for initialization
	private void Start () {
        pickUp.gameObject.SetActive(false);
        anim.SetBool("pick", false);
	}
	
	// Update is called once per frame
	private void Update () {
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.E)){
          anim.SetTrigger("pick");
          PickUp();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("mainCharacter"))
        {
            pickUp.gameObject.SetActive(true);
            pickUpAllowed = true;
        }        
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("mainCharacter"))
        {
            pickUp.gameObject.SetActive(false);
            pickUpAllowed = false;
        }
    }

    private void PickUp()
    {
       
        gameObject.GetComponent<Renderer>().enabled = false;
     
        Destroy(gameObject);
          
    }

}
