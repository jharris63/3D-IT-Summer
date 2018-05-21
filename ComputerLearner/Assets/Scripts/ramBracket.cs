using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ramBracket : MonoBehaviour {

    public Animator animator;
    public bool open = false;

    public void Open()
    {
        if(open == false)
        {
            animator.SetBool("open", true);
        }
        else if(open == true)
        {
            animator.SetBool("open", false);
        }
    }
}
