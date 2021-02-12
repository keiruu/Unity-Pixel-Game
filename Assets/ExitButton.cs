using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{
    // Start is called before the first frame update
    public Button thebutton;
    public Animator animator, animator2;
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

        animator.SetTrigger("Item");
        animator2.SetTrigger("transition");
        Button btn = thebutton.GetComponent<Button>();
		btn.onClick.AddListener(ClickAgain);
    }

    void ClickAgain(){
        animator.SetTrigger("Item");
        animator2.SetTrigger("transition");
        Button btn = thebutton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
    }

}
