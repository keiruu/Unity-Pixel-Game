using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPressed2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Button thebutton;
    public Animator animator;
    public Animator animator2;
    void Start()
    {
        Button btn = thebutton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void TaskOnClick(){
        animator.SetTrigger("TriggerPull");

        
        if(this.animator2.GetCurrentAnimatorStateInfo(0).IsName("idle_inventory")){
            animator.SetTrigger("TriggerPull");
        }else{
         if(this.animator2.GetCurrentAnimatorStateInfo(0).IsName("all_disappear")){
            
        }else{
            animator2.SetTrigger("TriggerAppear");
            Debug.Log("ia");
        }
        }
     
        Button btn = thebutton.GetComponent<Button>();
        btn.onClick.AddListener(ClickAgain);
    }

    void ClickAgain(){

        Button btn = thebutton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
    }


}
