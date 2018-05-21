using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stickInsert : MonoBehaviour {

    public Animator animator;
    public bool rotate = false;
    public bool wrong = false;
    public bool right = false;
    public bool done = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        animator.SetBool("rotate", rotate);

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("wrong")|| animator.GetCurrentAnimatorStateInfo(0).IsName("1wrong")|| animator.GetCurrentAnimatorStateInfo(0).IsName("2wrong")|| animator.GetCurrentAnimatorStateInfo(0).IsName("3wrong"))
        {
            wrong = true;
            done = true;
        }

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("right")|| animator.GetCurrentAnimatorStateInfo(0).IsName("1right")|| animator.GetCurrentAnimatorStateInfo(0).IsName("2right")|| animator.GetCurrentAnimatorStateInfo(0).IsName("3right"))
        {
            right = true;
            done = true;
        }

    }

    public void Rotate()
    {
        rotate = !rotate;
    }

    public void Insert()
    {
        animator.SetBool("insert", true);
    }
}
