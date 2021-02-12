using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPressed : MonoBehaviour
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

       // animator.Play("openbag");
        animator.SetTrigger("TriggerOpen");
        if(animator.GetCurrentAnimatorStateInfo(0).IsTag("1")){
            animator2.SetBool("Appear", false);
        }else{
            animator2.SetBool("Appear", true);
        }
        Button btn = thebutton.GetComponent<Button>();
        btn.onClick.AddListener(ClickAgain);
    }

    void ClickAgain(){
       // animator.Play("close bag");
       //animator.SetTrigger("TriggerClose");
    
        Button btn = thebutton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
    }


}
