using UnityEngine;
using System.Collections;

public class SidePanel : MonoBehaviour {

    public GameObject panel;
    private Animator animator;
    private Animation animation;
    //private AnimatorStateInfo currentState;
    
    // Use this for initialization
	void Start () 
    {
        animator = panel.GetComponent<Animator>();
        //currentState 
	}
	
	// Update is called once per frame
	void Update () 
    {
        //if (animator.GetBool("isSlideIn") == true)
        //    animator.SetBool("isSlideIn", false);
        //animator.GetBool("isSlideIn");
	}

    public void Menu()
    {
        if (animator.GetBool("isSlideOut") == true && animator.GetBool("isIdleOut") == true)
        {
            animator.SetBool("isSlideIn", true);
            animator.SetBool("isIdleIn", true);
            animator.SetBool("isSlideOut", false);
            animator.SetBool("isIdleOut", false);
            Time.timeScale = 0;
        }
        else if (animator.GetBool("isSlideIn") == true && animator.GetBool("isIdleIn") == true)
        {
            animator.SetBool("isSlideOut", true);
            animator.SetBool("isIdleOut", true);
            animator.SetBool("isSlideIn", false);
            animator.SetBool("isIdleIn", false);
            Time.timeScale = 1;
        }
    }

    /*public void MainButtonClicked(Animator currAnimator)
    {
        currAnimator.SetBool("Activated", !currAnimator.GetBool("Activated"));
    }*/

}
