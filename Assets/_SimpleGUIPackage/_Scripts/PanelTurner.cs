using UnityEngine;
using System.Collections;

public class PanelTurner : MonoBehaviour {

    private Animator anim;

    private bool isPaused = false;

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play("Idle");
    }
    
    /*public void Turner()
    {
        if (gameObject.transform.rotation.y == 0.0f)
        {
            gameObject.transform.Rotate(0, -90.0f, 0);
            Time.timeScale = 1.0f;
        }
        else
        {
            gameObject.transform.Rotate(0, 90.0f, 0);
            Time.timeScale = 0.0f;
        }
    }
     */

    public void PauseGame()
    {
        //anim.enabled = false;

        if (anim.GetBool("isIdle") == true)
        {
            if (anim.GetBool("isIn") == false)
            {
                //anim.Play("SlideIn");
                //anim.SetBool("isIn", true);
                Time.timeScale = 0;
            }
        }
        /*    anim.enabled = true;
            isPaused = false;
            anim.Play("SlideOut");
            Time.timeScale = 1;
         * */
    }
}
