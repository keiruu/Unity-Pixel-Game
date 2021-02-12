using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPressed3 : MonoBehaviour
{
     // Start is called before the first frame update
    public Button thebutton;
    public Animator animator;
    
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

        animator.SetTrigger("TriggerAppear");
        animator.SetBool("Appear", true);
        Button btn = thebutton.GetComponent<Button>();
        btn.onClick.AddListener(ClickAgain);
    }

    void ClickAgain(){
       
        //animator.SetTrigger("TriggerDisappear");
        if(animator.GetBool("Appear"))
        {        
            animator.SetBool("Appear", false);
        }
        Button btn = thebutton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
    }


}
