using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkObj : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject check;
    public Animator anim;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(check.activeSelf == false){
             anim.SetBool("pick", false);
        }
    }
}
